# 🏗️ UCAM System Architecture

**College/University Admission Management System** | Design & Decision Engine

<div align="center">

![Architecture](https://img.shields.io/badge/Pattern-Dual%20Solution%20Architecture-red?style=for-the-badge)
![Design](https://img.shields.io/badge/Framework-VB.NET%20WinForms-black?style=for-the-badge)

[📖 Back to README](./UCAM_README.md) • [🗄️ Database](./UCAM_DATABASE.md)

</div>

---

## SYSTEM OVERVIEW

> **Note Correction:** Current Student Application in this image design is no longer ~Html/Php~ but a VB.NET winforms local but does not prevent stack change 

![Preview](https://github.com/Mickekofi/Ucam/blob/master/image_architecture.png)


### Dual Solution Architecture

UCAM is built as **TWO separate VB.NET WinForms applications** running on the same MySQL database:

```
┌─────────────────────────────┐      ┌──────────────────────────────┐
│  College Admission Form     │      │ College Admission Management │
│  (Student Portal)           │      │ (Admin Portal)               │
├─────────────────────────────┤      ├──────────────────────────────┤
│ • Application submission    │      │ • Department management      │
│ • WAEC results upload       │      │ • Criteria configuration     │
│ • Program choice selection  │      │ • Auto-admit engine          │
│ • Status checking           │      │ • Manual decision overrides   │
│ • PDF receipt generation    │      │ • Audit log review           │
│ • Email confirmation        │      │ • Report generation          │
│                             │      │ • User administration        │
│  Database.vb (Student)      │      │  Database.vb (Admin)         │
└─────────────────────────────┘      └──────────────────────────────┘
           ↓                                    ↓
            └──────────┬────────────────────────┘
                       ↓
                  MySQL Database
                   (ucam_db)
                  9 Core Tables
```

---

## SOLUTION 1: COLLEGE ADMISSION FORM.SLN

### Purpose
Student-facing application for submitting admissions and checking status.

### Project Structure

```
College Admission Form.sln/
│
├── My Project/
│   └── [Form resources & settings]
│
├── StudentUser/
│   └── [Student-specific forms & models]
│
├── Database.vb
│   └── Connection string configuration for student access
│
├── Form1.vb
│   └── Main student application form
│
└── [Helper Classes]
    ├── DataValidation.vb
    ├── PDFGenerator.vb (for receipts)
    ├── EmailNotifier.vb
    └── etc.
```

### Key Features

**Application Submission:**
```
Student → Form1.vb → Personal Details
                   → Academic Info
                   → WAEC Results Entry
                   → Program Selection (1st, 2nd, 3rd)
                   → Submit
                   → PDF Receipt Generated
                   → Email Confirmation Sent
                   → Status: "Pending"
```

**Status Checking:**
```
Student → Form1.vb → Input Student ID
                   → Queries admissions table
                   → Shows:
                     • Current decision status
                     • Admitted to which program (if applicable)
                     • 1st, 2nd, 3rd choice results
                     • Rejection reason (if rejected)
```

### Database.vb Configuration

Located in root of solution:

```vb
' Update this connection string for your environment
Private Const connectionString As String = _
    "server=localhost;database=ucam_db;uid=root;password=;"
```

Change values based on your setup:
- `localhost` → MySQL server address
- `ucam_db` → Your database name
- `root` → Your MySQL username
- `` → Your MySQL password (empty if none)

### Student Workflow

1. **Open Application**
2. **Fill Application Form**
   - Full name, email, phone
   - Index number (WAEC ID)
   - Date of birth
   - School attended

3. **Enter WAEC Results**
   - Add each subject and grade
   - Data stored as JSON in waec_results_json

4. **Select Programs**
   - Choose 1st choice program
   - Choose 2nd choice program (backup)
   - Choose 3rd choice program (safety)

5. **Submit Application**
   - Click Submit button
   - PDF receipt generates automatically
   - Email confirmation sent instantly
   - Application saved to database

6. **Check Status Anytime**
   - Enter student ID
   - View current decision
   - See which choice admitted to (if any)

---

## SOLUTION 2: COLLEGE ADMISSION MANAGEMENT.SLN

### Purpose
Admin application for managing admissions, configuring criteria, and running auto-admit engine.

### Project Structure

```
College Admission Management.sln/
│
├── My Project/
│   └── [Solution resources & settings]
│
├── Database.vb
│   └── Connection string configuration for admin access
│
├── [Admin Forms & Logic]
│   ├── AdminDashboard.vb
│   ├── DepartmentManagement.vb
│   ├── ProgramManagement.vb
│   ├── CriteriaConfiguration.vb
│   ├── ApplicationReview.vb
│   ├── AutoAdmitEngine.vb
│   ├── UserManagement.vb
│   └── AuditLogViewer.vb
│
└── [Helper Classes]
    ├── AdmissionDecisionEngine.vb
    ├── CriteriaParser.vb
    ├── ScoreCalculator.vb
    └── etc.
```

### Role-Based Access Control

#### Super Admin Privileges

```vb
If user.role = "super_admin" Then
    ' Full system access
    CanCreateDepartment() → True
    CanCreateProgram() → True
    CanManageAdmins() → True
    CanConfigureCriteria() → True
    CanViewAllApplications() → True
    CanRunAutoAdmit() → True
    CanViewAuditLogs() → True
    CanOverrideDecisions() → True
    CanAccessAllDepartments() → True
End If
```

#### Department Admin Privileges

```vb
If user.role = "department_admin" Then
    ' Scoped to assigned department only
    CanViewApplications() → Only own department
    CanMakeDecisions() → Only own department
    CanOverrideDecisions() → Only own department
    CanViewAuditLogs() → Only own department
    
    CanCreateDepartment() → False
    CanCreateProgram() → False
    CanManageAdmins() → False
    CanConfigureCriteria() → False
    CanRunAutoAdmit() → Super Admin only
    CanAccessOtherDepartments() → False
End If
```

### Database.vb Configuration

Located in root of solution (separate from Form.sln):

```vb
' Update this connection string for admin access
Private Const connectionString As String = _
    "server=localhost;database=ucam_db;uid=root;password=;"
```

Same database as student app, but admin app has different access permissions.

---

## AUTO-ADMIT ENGINE (Core Intelligence)

### How It Works

The auto-admit engine automatically makes admission decisions based on `criteria_json` stored in departments table.

### Decision Flow Diagram

```
Student Application Submitted
    ↓
┌─ AUTO-ADMIT ENGINE STARTS ─┐
│                             │
│ 1. Get Department Criteria  │
│    (from criteria_json)     │
│    • core_subjects list     │
│    • min_aggregate score    │
│    • subject requirements   │
│    • tie-breaker rules      │
│                             │
│ 2. Extract Student WAEC     │
│    (from waec_results_json) │
│    • Read all subject grades│
│    • Map grades to numbers  │
│                             │
│ 3. Calculate Aggregate      │
│    • Sum core subject grades│
│    • Add elective grades    │
│    • Apply formula          │
│                             │
│ 4. Evaluate 1st Choice      │
│    ├─ Get 1st choice program│
│    ├─ Check aggregate >= min│
│    ├─ Check subject reqs met│
│    └─ IF ALL PASS:          │
│        → ADMIT to 1st       │
│        → Exit engine        │
│                             │
│ 5. IF 1st REJECTED:         │
│    ├─ Evaluate 2nd choice   │
│    └─ IF ALL PASS:          │
│        → ADMIT to 2nd       │
│        → Exit engine        │
│                             │
│ 6. IF 2nd REJECTED:         │
│    ├─ Evaluate 3rd choice   │
│    └─ IF ALL PASS:          │
│        → ADMIT to 3rd       │
│        → Exit engine        │
│                             │
│ 7. IF ALL REJECTED:         │
│    └─ REJECT applicant      │
│       Log reason in flow_log│
│                             │
└─────────────────────────────┘
    ↓
Log Decision (admission_flow_log)
    ↓
Update Status (program_choices)
    ↓
Store Decision (admissions table)
    ↓
Notify Student (email)
```

### Decision Criteria Evaluation

**Criteria JSON Evaluation:**

```json
{
  "min_aggregate": 12,
  "subject_requirements": [
    {"subject": "Mathematics", "max_grade": "C6"}
  ]
}
```

**Student Data:**

```json
{
  "aggregate": 15,
  "subjects": [
    {"subject": "Mathematics", "grade": "B3"}
  ]
}
```

**Decision Logic:**

```
Check: aggregate (15) >= min_aggregate (12)? ✓ PASS
Check: Math grade (B3) <= required (C6)? ✓ PASS (B3 is better than C6)
Result: ADMIT
```

### Tie-Breaker Rules

When students have equal aggregate scores:

```json
"tie_breakers": [
  "aggregate_asc",      // Rank by aggregate (ascending = better)
  "math_grade_asc",     // Then by Math grade (ascending = better)
  "dob_older_first"     // Then by DOB (older students first)
]
```

**Application:**
```
Student A: Aggregate 12, Math B3, DOB 2005-01-15
Student B: Aggregate 12, Math C4, DOB 2005-03-20

Step 1: Compare aggregate → Both 12 → TIED
Step 2: Compare Math → A=B3, B=C4 → A wins (B3 is better)
Result: Student A ranks higher
```

---

## APPLICATION FLOW FOR SUPER ADMIN

### Initial System Setup

```
1. Open College Admission Management.sln
2. Login as Super Admin (initial credentials)
3. Create Departments
   • Name: "School of Sciences"
   • Set quota: 100
   • Configure criteria_json

4. Create Programs under departments
   • "BSc Computer Science" under Sciences
   • "BSc Physics" under Sciences
   • Set min_aggregate for each

5. Create Department Admins
   • Username: "sci_admin1"
   • Role: department_admin
   • Assign to: School of Sciences

6. Admins now can login and review applications
```

---

## APPLICATION FLOW FOR DEPARTMENT ADMIN

### Review & Make Decisions

```
1. Open College Admission Management.sln
2. Login as Department Admin
3. Dashboard shows:
   • Applications for own department
   • Current decision status
   • Auto-admit decisions already made

4. Filter & Sort
   • View 1st choice applicants
   • View 2nd choice applicants
   • View rejected applicants

5. For Each Applicant:
   • View full WAEC results
   • See auto-admit decision
   • Optionally override decision
   • Add notes/reason
   • Confirm

6. Generate Reports
   • Export admitted students list
   • Email notifications to admitted students
   • Send rejection letters to others
```

---

## DATABASE CONNECTIVITY

### College Admission Form.sln

**Database.vb** handles:
- Student data retrieval (personal info, WAEC results)
- Program list for student choices
- Application submission (INSERT to students, program_choices)
- Status checking (SELECT from admissions)
- Email notification queries

### College Admission Management.sln

**Database.vb** handles:
- Admin authentication (SELECT from users)
- Department/program management (CRUD)
- Criteria configuration (UPDATE criteria_json)
- Application review (SELECT from students, program_choices)
- Decision logging (INSERT to admissions, admission_flow_log)
- Audit logging (INSERT to logs)
- User management (CRUD on users table)

### No App.config

Both solutions use **Database.vb** for configuration:
- No App.config file
- Connection string hardcoded in Database.vb (update manually)
- Each solution has its own Database.vb file
- Same database, different access patterns

---

## SEPARATION OF POWER DESIGN

### Why Two Solutions?

```
College Admission Form.sln
├─ READ: students, program_choices, admissions
├─ WRITE: students (new), program_choices, admissions (read status only)
└─ CANNOT: Modify criteria, access admin functions

College Admission Management.sln
├─ WRITE: departments, programs, users, criteria_json
├─ EXECUTE: auto-admit engine
├─ OVERRIDE: admission decisions
└─ LOG: all admin actions
```

### Security Benefits

✓ Students cannot access admin functions  
✓ Admins cannot accidentally modify student form flow  
✓ Clear separation of concerns  
✓ Easier to deploy securely (Form app on public LAN, Management on admin LAN)  
✓ Role-based access within Management app (Super Admin vs Department Admin)  

---

## AUDIT TRAIL ARCHITECTURE

### Two Audit Tables

**1. LOGS TABLE** - Admin actions
```
User 1 → "Created program BSc CS" → IP: 192.168.1.5 → 2024-01-15 10:30:00
User 2 → "Override admission decision" → IP: 192.168.1.8 → 2024-01-15 11:15:00
User 1 → "Updated criteria for Sciences" → IP: 192.168.1.5 → 2024-01-15 14:45:00
```

**2. ADMISSION_FLOW_LOG TABLE** - Student decision flow
```
Student 5, 1st choice → Rejected → "Math grade D7 requires C6" → 2024-01-15 12:00:00
Student 5, 2nd choice → Passed → "All criteria met" → 2024-01-15 12:00:05
Student 5, 3rd choice → Pending → "Not evaluated yet" → [Future]
```

### Compliance Ready

- Complete audit trail of every admin action
- Complete decision history for every student
- Timestamps and IP addresses logged
- Enables investigation and verification
- Proof of fair, transparent process

---

## TECHNICAL ARCHITECTURE

### Tech Stack

| Component | Technology |
|-----------|-----------|
| **IDE** | Visual Studio 2022 |
| **Language** | VB.NET |
| **UI** | Windows Forms (WinForms) |
| **Database** | MySQL 5.7+ |
| **Server** | Apache (optional) |
| **OS** | Windows 10+ |

### Design Patterns Used

1. **Separation of Concerns** - Two solutions for different roles
2. **Role-Based Access Control** - Super Admin vs Department Admin
3. **JSON for Flexibility** - criteria_json and waec_results_json
4. **Audit Trail** - Complete logging for compliance
5. **Decision Engine** - Centralized admission logic
6. **Tie-Breaker Rules** - Fair ranking when scores equal

---

<div align="center">

**UCAM Architecture Documentation v1.0**

College/University Admission Management System

*Last Updated: Current*

</div>
