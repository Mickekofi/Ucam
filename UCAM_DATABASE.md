# 🗄️ UCAM Database Documentation

**College/University Admission Management System** | Database Schema & Design

<div align="center">

![Database](https://img.shields.io/badge/Database-MySQL%205.7%2B-blue?style=for-the-badge)
![Schema](https://img.shields.io/badge/Tables-9%20Core-gold?style=for-the-badge)
![Engine](https://img.shields.io/badge/Engine-InnoDB-0047AB?style=for-the-badge)

[📖 Back to README](./UCAM_README.md) • [🏗️ Architecture](./UCAM_ARCHITECTURE.md)

</div>

---

## DATABASE OVERVIEW

**Database Name**: `ucam_db` (configurable in Database.vb)

**Total Tables**: 9

**Schema File Location**: `Ucam/plan_files/UCAM_db.sql`

---

## TABLE STRUCTURE

### 1. DEPARTMENTS

Stores university/college departments that admit students.

```sql
CREATE TABLE departments (
    department_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100),
    quota INT DEFAULT 100,
    criteria_json JSON,
    active_year YEAR,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

**Purpose**: Organize programs by academic departments

**Fields**:
- `department_id`: Unique identifier
- `name`: Department name (e.g., "School of Sciences", "Faculty of Engineering")
- `email`: Department contact email
- `quota`: Total admission quota for department this year
- `criteria_json`: **Admission decision criteria** (stored as JSON object)
- `active_year`: Academic year this department accepts applicants
- `created_at`: Timestamp when created

**criteria_json Structure**:
```json
{
  "aggregate_formula": {
    "core_subjects": ["English", "Mathematics", "Integrated Science", "Social Studies"],
    "electives_required": 2,
    "grade_map": {
      "A1": 1, "B2": 2, "B3": 3, "C4": 4, "C5": 5, 
      "C6": 6, "D7": 7, "E8": 8, "F9": 9
    },
    "aggregate_max": 24,
    "min_aggregate": 12
  },
  "subject_requirements": [
    {"subject": "Mathematics", "max_grade": "C6"}
  ],
  "weights": {"Math": 1.0},
  "tie_breakers": ["aggregate_asc", "math_grade_asc", "dob_older_first"]
}
```

---

### 2. PROGRAMS

Academic programs offered by departments.

```sql
CREATE TABLE programs (
    program_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    department_id INT,
    min_aggregate INT,
    active BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (department_id) REFERENCES departments(department_id) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

**Purpose**: Define specific programs (degrees) students can apply for

**Fields**:
- `program_id`: Unique identifier
- `name`: Program name (e.g., "BSc Computer Science", "BA Education")
- `department_id`: Which department offers this program
- `min_aggregate`: Minimum WAEC aggregate score required
- `active`: Whether program is accepting applications

**Example Programs**:
- BSc Computer Science (min_aggregate: 12)
- BA Education (min_aggregate: 10)
- BEng Civil Engineering (min_aggregate: 14)

---

### 3. USERS

Admin users who manage the admission process.

```sql
CREATE TABLE users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    role ENUM('department_admin', 'super_admin') DEFAULT 'department_admin',
    department_id INT,
    last_login DATETIME,
    FOREIGN KEY (department_id) REFERENCES departments(department_id) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

**Purpose**: Store admin user accounts with role-based access

**Fields**:
- `user_id`: Unique identifier
- `username`: Login username (unique)
- `password_hash`: Hashed password
- `role`: User role:
  - `super_admin`: Full system access
  - `department_admin`: Department-specific access
- `department_id`: For department_admin - which department they manage
- `last_login`: Timestamp of last login

**Role Permissions**:
- **Super Admin**: Create departments, programs, admins; view all applications; configure criteria
- **Department Admin**: Review applicants; make decisions; override auto-admit; view own department only

---

### 4. STUDENTS

Student applicants to the system.

```sql
CREATE TABLE students (
    student_id INT AUTO_INCREMENT PRIMARY KEY,
    full_name VARCHAR(100) NOT NULL,
    email VARCHAR(100),
    phone_number VARCHAR(15),
    index_number VARCHAR(15) NOT NULL UNIQUE,
    dob DATE,
    gender ENUM('Male', 'Female'),
    waec_results_json JSON,
    application_year YEAR,
    status ENUM('Pending', 'Admitted', 'Rejected', 'Resubmitted') DEFAULT 'Pending',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

**Purpose**: Store student personal and academic information

**Fields**:
- `student_id`: Unique identifier
- `full_name`: Student's full name
- `email`: Contact email
- `phone_number`: Contact phone
- `index_number`: Student's WAEC index number (unique per student)
- `dob`: Date of birth (used for tie-breaker logic)
- `gender`: Male or Female
- `waec_results_json`: **WAEC exam results stored as JSON**
- `application_year`: Year of application
- `status`: Current application status
- `created_at`: When application created

**waec_results_json Structure**:
```json
{
  "subjects": [
    {"subject": "English", "grade": "C6"},
    {"subject": "Mathematics", "grade": "B3"},
    {"subject": "Integrated Science", "grade": "B2"},
    {"subject": "Social Studies", "grade": "A1"},
    {"subject": "Physics", "grade": "C4"},
    {"subject": "Chemistry", "grade": "C5"}
  ]
}
```

---

### 5. PROGRAM_CHOICES

Student's ranked preferences for programs.

```sql
CREATE TABLE program_choices (
    choice_id INT AUTO_INCREMENT PRIMARY KEY,
    student_id INT NOT NULL,
    program_id INT NOT NULL,
    choice_rank TINYINT NOT NULL,
    result ENUM('Pending', 'Admitted', 'Rejected') DEFAULT 'Pending',
    decision_notes TEXT,
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    FOREIGN KEY (program_id) REFERENCES programs(program_id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

**Purpose**: Track each student's 3 program preferences and admission decisions

**Fields**:
- `choice_id`: Unique identifier
- `student_id`: Which student
- `program_id`: Which program
- `choice_rank`: 1 (first), 2 (second), or 3 (third) choice
- `result`: Current decision for this choice
- `decision_notes`: Reason for decision

**Example**:
- Student 1 → Program 5 (BSc CS) → choice_rank 1 → result: Admitted
- Student 1 → Program 12 (BSc IT) → choice_rank 2 → result: Pending
- Student 1 → Program 8 (BSc Math) → choice_rank 3 → result: Pending

---

### 6. ADMISSIONS

Final admission decisions made for students.

```sql
CREATE TABLE admissions (
    admission_id INT AUTO_INCREMENT PRIMARY KEY,
    student_id INT NOT NULL,
    program_id INT NOT NULL,
    choice_rank INT,
    decision_by_user INT,
    status ENUM('Admitted', 'Rejected') DEFAULT 'Admitted',
    date_decided DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    FOREIGN KEY (program_id) REFERENCES programs(program_id) ON DELETE CASCADE,
    FOREIGN KEY (decision_by_user) REFERENCES users(user_id) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

**Purpose**: Store final admission decisions

**Fields**:
- `admission_id`: Unique identifier
- `student_id`: Which student
- `program_id`: Which program admitted/rejected for
- `choice_rank`: Was this 1st, 2nd, or 3rd choice?
- `decision_by_user`: Which admin made decision (null if auto-admit)
- `status`: Final status (Admitted or Rejected)
- `date_decided`: When decision made

**Notes**:
- If auto-admit engine made decision → `decision_by_user` is NULL
- If department admin made decision → `decision_by_user` is their user_id

---

### 7. ADMISSION_FLOW_LOG

Detailed log of admission decision flow.

```sql
CREATE TABLE admission_flow_log (
    log_id INT AUTO_INCREMENT PRIMARY KEY,
    student_id INT NOT NULL,
    department_id INT NOT NULL,
    choice_rank INT,
    decision ENUM('Rejected', 'Passed'),
    note TEXT,
    timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    FOREIGN KEY (department_id) REFERENCES departments(department_id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

**Purpose**: Track the admission flow process for each student through each choice

**Fields**:
- `log_id`: Unique identifier
- `student_id`: Which student
- `department_id`: Which department being evaluated
- `choice_rank`: Position (1st, 2nd, or 3rd choice)
- `decision`: Passed or Rejected (at this step)
- `note`: Reason for decision (e.g., "WAEC aggregate 15, minimum required 12" or "Math grade D7, requires C6")
- `timestamp`: When this decision was made

**Flow Example**:
- Student 1, 1st choice → Rejected → "Math grade D7 does not meet C6 requirement"
- Student 1, 2nd choice → Passed → "All criteria met"
- (2nd choice becomes final admission)

---

### 8. LOGS

General system activity logging for audit trail.

```sql
CREATE TABLE logs (
    log_id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT,
    action TEXT NOT NULL,
    target_id INT,
    ip_address VARCHAR(45),
    timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

**Purpose**: Audit trail of all admin actions

**Fields**:
- `log_id`: Unique identifier
- `user_id`: Which admin performed action
- `action`: Description of action (e.g., "Created department", "Override admit decision")
- `target_id`: ID of record affected
- `ip_address`: IP address of admin
- `timestamp`: When action occurred

**Example Logs**:
- User 2 → "Created program BSc Computer Science" → target_id: 5
- User 3 → "Override admission decision" → target_id: 15 (student_id)
- User 1 → "Updated department criteria" → target_id: 3 (department_id)

---

### 9. SETTINGS

System-wide configuration settings.

```sql
CREATE TABLE settings (
    setting_key VARCHAR(100) PRIMARY KEY,
    setting_value TEXT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
```

**Purpose**: Store global configuration values

**Fields**:
- `setting_key`: Configuration key name
- `setting_value`: Configuration value

**Example Settings**:
- `admission_cycle_year` → "2024"
- `auto_admit_enabled` → "true"
- `email_notifications_enabled` → "true"
- `max_choices_per_student` → "3"

---

## DATABASE RELATIONSHIPS

### Entity-Relationship Diagram (Text Format)

```
DEPARTMENTS (Independent)
  ├─ 1 department_id ─┬─→ N PROGRAMS (1-to-Many)
  │                   ├─→ N USERS (1-to-Many)
  │                   └─→ N ADMISSION_FLOW_LOG (1-to-Many)
  └─ Stores: criteria_json for admission decisions

PROGRAMS (Depends on DEPARTMENTS)
  └─ N PROGRAM_CHOICES (1-to-Many)

USERS (Depends on DEPARTMENTS)
  ├─ 1 user_id ─→ N LOGS (1-to-Many)
  ├─ 1 user_id ─→ N ADMISSIONS (1-to-Many)
  └─ Roles: super_admin (all data), department_admin (own dept)

STUDENTS (Independent)
  ├─ 1 student_id ─┬─→ N PROGRAM_CHOICES (1-to-Many)
  │                ├─→ N ADMISSIONS (1-to-Many)
  │                └─→ N ADMISSION_FLOW_LOG (1-to-Many)
  └─ Stores: waec_results_json with exam grades

PROGRAM_CHOICES (Junction - Links STUDENTS to PROGRAMS)
  ├─ N → 1 STUDENTS (Many-to-One)
  ├─ N → 1 PROGRAMS (Many-to-One)
  └─ Tracks: 1st, 2nd, 3rd choice preferences

ADMISSIONS (Final Decisions)
  ├─ N → 1 STUDENTS
  ├─ N → 1 PROGRAMS
  └─ N → 1 USERS (who made decision)

ADMISSION_FLOW_LOG (Decision Audit)
  ├─ N → 1 STUDENTS
  └─ N → 1 DEPARTMENTS

LOGS (System Audit)
  └─ N → 1 USERS

SETTINGS (Configuration)
  └─ Independent key-value store
```

---

## JSON DATA STRUCTURES

### criteria_json (Stored in DEPARTMENTS.criteria_json)

Defines admission criteria for a department:

```json
{
  "aggregate_formula": {
    "core_subjects": [
      "English",
      "Mathematics",
      "Integrated Science",
      "Social Studies"
    ],
    "electives_required": 2,
    "grade_map": {
      "A1": 1, "B2": 2, "B3": 3, "C4": 4, "C5": 5,
      "C6": 6, "D7": 7, "E8": 8, "F9": 9
    },
    "aggregate_max": 24,
    "min_aggregate": 12
  },
  "subject_requirements": [
    {"subject": "Mathematics", "max_grade": "C6"},
    {"subject": "English", "max_grade": "C6"}
  ],
  "weights": {
    "Math": 1.0,
    "English": 0.5
  },
  "tie_breakers": [
    "aggregate_asc",
    "math_grade_asc",
    "dob_older_first"
  ]
}
```

**Fields Explained**:
- `aggregate_formula`: How to calculate overall score
  - `core_subjects`: Mandatory subjects
  - `electives_required`: How many electives needed
  - `grade_map`: Grade to numeric value mapping
  - `aggregate_max`: Highest possible aggregate
  - `min_aggregate`: Minimum aggregate to pass

- `subject_requirements`: Subject-specific minimum grades
  - Each subject must achieve max_grade or better

- `weights`: Subject importance for scoring
  - Higher weight = more important in final score

- `tie_breakers`: How to rank students with same aggregate
  - `aggregate_asc`: Lower aggregate scores rank higher
  - `math_grade_asc`: Better math grades rank higher
  - `dob_older_first`: Older students rank higher

---

### waec_results_json (Stored in STUDENTS.waec_results_json)

Student's WAEC examination results:

```json
{
  "subjects": [
    {
      "subject": "English",
      "grade": "C6"
    },
    {
      "subject": "Mathematics",
      "grade": "B3"
    },
    {
      "subject": "Integrated Science",
      "grade": "B2"
    },
    {
      "subject": "Social Studies",
      "grade": "A1"
    },
    {
      "subject": "Physics",
      "grade": "C4"
    },
    {
      "subject": "Chemistry",
      "grade": "C5"
    }
  ]
}
```

**Flexibility**: Students can have any number of subjects. Auto-admit engine:
- Extracts core subjects required by department
- Calculates aggregate from core + required electives
- Validates against subject-specific requirements

---

## KEY RELATIONSHIPS

| Relationship | Type | Purpose |
|---|---|---|
| DEPARTMENTS → PROGRAMS | 1-to-Many | Department offers multiple programs |
| DEPARTMENTS → USERS | 1-to-Many | Super admin creates department admins |
| PROGRAMS → PROGRAM_CHOICES | 1-to-Many | Program appears in multiple student choices |
| STUDENTS → PROGRAM_CHOICES | 1-to-Many | Student makes 3 program choices |
| STUDENTS → ADMISSIONS | 1-to-Many | Student receives decisions for multiple programs |
| USERS → ADMISSIONS | 1-to-Many | Admin makes multiple admission decisions |
| USERS → LOGS | 1-to-Many | Admin actions logged |
| STUDENTS → ADMISSION_FLOW_LOG | 1-to-Many | Student flow tracked through choices |
| DEPARTMENTS → ADMISSION_FLOW_LOG | 1-to-Many | Department tracks applicants |

---

## IMPORTANT NOTES

### Cascade Deletes
- Deleting a STUDENT cascades to: PROGRAM_CHOICES, ADMISSIONS, ADMISSION_FLOW_LOG
- Deleting a PROGRAM cascades to: PROGRAM_CHOICES, ADMISSIONS
- This ensures referential integrity

### JSON Fields
- `criteria_json` and `waec_results_json` allow flexible data without schema changes
- The Management app's auto-admit engine parses these JSON fields for decisions
- Easy to add new evaluation rules without altering table structure

### Audit Trail
- `logs` table tracks ALL admin actions with IP and timestamp
- `admission_flow_log` shows EACH step of student's admission journey
- Together enable complete compliance auditing

---

<div align="center">

**UCAM Database Documentation v1.0**

College/University Admission Management System

*Last Updated: Current*

</div>
