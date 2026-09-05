‎=<p align="center">
‎  
‎    <img src="https://github.com/Mickekofi/Ucam/blob/master/ucam_logo.png" width="130">
‎  </a>
‎  
‎  <h1 align="center"><strong>College/University Admission Management System</strong></h1>
‎  </a>
‎  <p align="center">
‎    <a href="">
‎      <img src="https://img.shields.io/badge/Join-Community-blue.svg" alt="MIT License">
‎    </a>
‎    <a href="https://wa.me/233505994829?text=*Ucam_From_Github_User_💬Message_:*%20">
‎      <img src="https://img.shields.io/badge/Contact-Engineers-red.svg" alt="Build Status">
‎    </a>
‎  </p>
‎</p>
‎
‎---

# ඏ U C A M 
---

## 📋 OVERVIEW

![Preview](https://github.com/Mickekofi/Ucam/blob/master/image1.png)

**UCAM** is a complete admission management solution for universities and colleges. It handles student applications, automated admissions decisions, and departmental oversight through two separate desktop applications.

### Two Solutions in One Project

This project contains **TWO separate VB.NET WinForms applications**:

#### 1. 👨‍🎓 **College Admission Form.sln**

![Preview](https://github.com/Mickekofi/Ucam/blob/master/app.jpg)

- **For**: Students
- **Purpose**: Apply online, submit WAEC results, select program preferences, check admission status
- **Database.vb**: Configure for student-facing database access
- **Access**: Can run locally or be deployed for remote access

#### 2. 🏛️ **College Admission Management.sln**
![Preview](https://github.com/Mickekofi/Ucam/blob/master/image3.jpg)

![Preview](https://github.com/Mickekofi/Ucam/blob/master/image10.jpg)

- **For**: System Administrators and Department Heads
- **Purpose**: Manage admissions, configure criteria, review applications, auto-admit qualified students
- **Database.vb**: Configure for administrative database access
- **Access**: Local network deployment for admin staff
- **Roles**:
  - **Super Admin**: Full system control
  ![Preview](https://github.com/Mickekofi/Ucam/blob/master/image3.jpg)
  ![Preview](https://github.com/Mickekofi/Ucam/blob/master/image5.jpg)
  ![Preview](https://github.com/Mickekofi/Ucam/blob/master/image4.jpg)
  ![Preview](https://github.com/Mickekofi/Ucam/blob/master/image8.jpg)
  ![Preview](https://github.com/Mickekofi/Ucam/blob/master/image6.jpg)
  ![Preview](https://github.com/Mickekofi/Ucam/blob/master/image7.jpg)

  - **Department Admin**: Department-specific admission management
  ![Preview](https://github.com/Mickekofi/Ucam/blob/master/image9.jpg)

---

## 🎯 KEY FEATURES

### R1. Separation of Power Role-Based Access Design

![Preview](https://github.com/Mickekofi/Ucam/blob/master/image2.jpg)



```
Super Admin
├─ Global oversight & auditing
├─ Create departments and programs
├─ Manage department admin users
├─ Configure admission criteria
└─ View all applications across system



Department Admin
├─ Local, scoped access to own department
├─ Review applicants for their department
├─ Make manual admission decisions
├─ Override auto-admit decisions (if permitted)
└─ Generate department reports
```

> ✓ Ensures accountability, clarity, scalability, and structured control

---

### R2. Smart Admission Decision Flow (1st, 2nd, 3rd Choice Ranking)

![Preview](https://github.com/Mickekofi/Ucam/blob/master/image9.jpg)





Applicants select 3 program preferences:

```
Student applies with:
├─ 1st Choice Program
├─ 2nd Choice Program
└─ 3rd Choice Program

Auto-Admit Engine evaluates:
│
├─ Does 1st choice criteria match? → ADMIT to 1st choice ✓
├─ If NO: Does 2nd choice match? → ADMIT to 2nd choice ✓
├─ If NO: Does 3rd choice match? → ADMIT to 3rd choice ✓
└─ If NO: REJECT applicant ✗
```

> ✓ Makes admission dynamic, intelligent, and fair

---

### R3. Departmental Autonomy + Central Control

![Preview](https://github.com/Mickekofi/Ucam/blob/master/image7.jpg)

![Preview](https://github.com/Mickekofi/Ucam/blob/master/image10.jpg)


- Each **department** sees **only their applicants**
- **Super Admin** sees **all data globally** and can audit any activity
- Department admins cannot access other departments' data

> ✓ Prevents data overload  
> ✓ Boosts clarity  
> ✓ Strengthens data security and accountability

---

### R4. Dynamic WAEC Results Stored in JSON Format

![Preview](https://github.com/Mickekofi/Ucam/blob/master/image5.jpg)

WAEC examination results stored as JSON (not hardcoded fields):

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
    }
  ]
}
```

**Benefits:**
- ✓ Dynamic filtering and rule-based parsing
- ✓ AI-ready scoring engine for future expansion
- ✓ Easy schema updates without database restructuring

---

### R5. Automated Acknowledgements: Emails + PDF Receipts

> no image

When student submits application:

- ✓ **Automated email** confirmation is sent
- ✓ **PDF receipt** is generated instantly
- ✓ Student has **immediate proof of submission**

> Enhances transparency, user trust, and system professionalism

---

### R6. Auto-Admit Engine (Decision Intelligence)

![Preview](https://github.com/Mickekofi/Ucam/blob/master/image9.jpg)

Unique module that automatically admits qualified applicants:

- Uses `criteria_json` rules for instant validation
- Evaluates WAEC results against program requirements
- Applies aggregate scoring and subject-grade thresholds
- Implements tie-breaker rules for equal scores

**Benefits:**
- ✓ Reduces manual workload
- ✓ Minimizes human bias
- ✓ Enables real-time admission decisions
- ✓ Semi-AI decision engine without expensive AI tools

**Decision Criteria Includes:**
- Aggregate formula calculation
- Subject-specific grade requirements
- Weighted scoring system
- Tie-breaker logic (aggregate ascending, math grade ascending, age preference)

---

### R7. Dual-Client Architecture

```
┌─────────────────────────┬─────────────────────────┐
│  Admission Form App      │  Admission Management   │
│  (Student Portal)        │  (Admin Portal)         │
├─────────────────────────┼─────────────────────────┤
│ • Apply for programs    │ • Create departments    │
│ • Upload WAEC results   │ • Set admission criteria│
│ • Check admission status│ • Manage admin users    │
│ • View decisions        │ • Auto-admit students   │
│                         │ • Review applications   │
│                         │ • Generate reports      │
│                         │ • View audit logs       │
└─────────────────────────┴─────────────────────────┘
         ↓                          ↓
        Single MySQL Database
```

- Both apps work **locally over LAN** or deployed separately
- **No internet required** for local deployment
- Fast, secure, and cost-effective

---

### R8. Audit Logs & Admission Flow Tracking

Every action is logged in:

- `logs` table - System-wide activity logging
- `admission_flow_log` table - Admission decision tracking

Each entry contains:

- 🕒 Timestamp of action
- 🌐 IP address of user
- 👤 Responsible admin/user
- 📋 Decision or action taken
- 📝 Reason/notes for decision

> ✓ Full transparency for accountability and auditing (even for regulators)

---

## 🚀 QUICK START

### System Requirements

| Component | Requirement |
|-----------|-------------|
| **Operating System** | Windows 10 or Higher |
| **IDE** | Visual Studio 2022 |
| **.NET Framework** | 4.7.2+ |
| **Web Server** | Apache (with MySQL support) |
| **Database** | MySQL 5.7+ |
| **RAM** | 4GB minimum (8GB+ recommended) |
| **Storage** | 500MB+ available space |

### Prerequisites

**Install MySQL**
- Download from https://www.mysql.com/downloads/
- Or use via Apache bundle (XAMPP, WAMP, etc.)

**Install Visual Studio 2022**
- Download from https://visualstudio.microsoft.com/
- Include .NET desktop development workload
- Include VB.NET support

**Install Apache (Optional for web deployment)**
- For local LAN deployment, Apache not required
- For remote access, configure Apache with PHP

### Database Setup

**Step 1: Import Database Schema**

1. Open MySQL command line or MySQL Workbench
2. Create database (optional - import creates it):
   ```sql
   CREATE DATABASE ucam_db;
   ```

3. Import the schema:
   ```bash
   mysql -u root -p ucam_db < Ucam/plan_files/UCAM_db.sql
   ```

   Or import via MySQL Workbench:
   - File → Run SQL Script
   - Select: `Ucam/plan_files/UCAM_db.sql`
   - Execute

4. Verify tables created:
   ```sql
   USE ucam_db;
   SHOW TABLES;
   ```

   Should show 9 tables: departments, programs, users, students, program_choices, admissions, admission_flow_log, logs, settings

---

### Installation: College Admission Management.sln (Admin App)

**Step 1: Open Solution in Visual Studio 2022**
```
File → Open → College Admission Management.sln
```

**Step 2: Configure Database.vb**

1. Open `Database.vb` file in the project
2. Find the connection string (line where MySQL connection is defined)
3. Update connection details:
   ```vb
   ' Example configuration
   Private connectionString As String = "server=localhost;database=ucam_db;uid=root;password=;"
   ```
   
   Replace with your settings:
   - `localhost` - MySQL server address
   - `ucam_db` - Your database name
   - `root` - Your MySQL username
   - Leave empty or add password if set

**Step 3: Build Solution**
```
Build → Build Solution
(Or press Ctrl+Shift+B)
```

**Step 4: Run Application**
```
Debug → Start Debugging
(Or press F5)
```

**Step 5: First Login**

1. Application starts
2. Login with default Super Admin credentials (if created during setup)
3. Or check database for initial user credentials

---

### Installation: College Admission Form.sln (Student App)

**Step 1: Open Solution in Visual Studio 2022**
```
File → Open → College Admission Form.sln
```

**Step 2: Configure Database.vb**

1. Open `Database.vb` file in this solution (different from Management app)
2. Update connection string (same database, different configuration if needed):
   ```vb
   Private connectionString As String = "server=localhost;database=ucam_db;uid=root;password=;"
   ```

**Step 3: Build Solution**
```
Build → Build Solution
```

**Step 4: Run Application**
```
Debug → Start Debugging
```

**Step 5: Student Portal Ready**

1. Application opens
2. Students can now fill application forms
3. Submit applications with WAEC results
4. Check admission status

---

## 👥 USER ROLES & WORKFLOWS

### 👨‍🎓 Student: How to Apply

1. **Open College Admission Form.sln application**
2. **Fill Application Form:**
   - Personal details (name, email, phone, DOB)
   - Academic information (index number, SHS attended)
   - WAEC examination results (subjects and grades)
3. **Select Program Preferences:**
   - Choose 1st choice program
   - Choose 2nd choice program (backup)
   - Choose 3rd choice program (final backup)
4. **Upload Documents:**
   - Certificate/diploma scans (if required)
5. **Submit Application:**
   - Click Submit
   - **PDF receipt** downloads automatically
   - **Confirmation email** sent instantly
6. **Check Status:**
   - Anytime via "Check Admission Status" feature
   - View decision for 1st, 2nd, or 3rd choice

---

### 🤖 Auto-Admit Engine: Automatic Decision

The Management app runs auto-admit process:

1. **Evaluation Against Criteria:**
   - Reads `criteria_json` from department
   - Checks student's WAEC results from `waec_results_json`
   - Calculates aggregate score

2. **Decision Logic:**
   - **1st Choice**: Does student meet criteria? → AUTO-ADMIT
   - **If Rejected**: Check 2nd choice criteria → AUTO-ADMIT if qualifies
   - **If Rejected**: Check 3rd choice criteria → AUTO-ADMIT if qualifies
   - **If All Rejected**: Generate rejection message

3. **Results Stored:**
   - Decision recorded in `admissions` table
   - Flow logged in `admission_flow_log` table
   - Student notified (email + status update)

---

### 🧑‍💼 Department Admin: Manage Department Admissions

1. **Open College Admission Management.sln**
2. **Login as Department Admin**
   - Uses credentials assigned by Super Admin
   - Can only see own department's applicants

3. **Review Applicants:**
   - View list of applicants for your department
   - Filter by: 1st choice, 2nd choice, 3rd choice
   - See auto-admit decisions already made

4. **Manual Actions (if needed):**
   - Override auto-admit decisions (with reason)
   - Manually admit borderline cases
   - Reject applicants with notes
   - Add decision reason to notes

5. **Generate Reports:**
   - Export admitted students list (Excel/PDF)
   - View admission statistics
   - Track decision timeline

---

### 👩‍💻 Super Admin: Full System Control

1. **Open College Admission Management.sln**
2. **Login as Super Admin**
   - Full access to entire system

3. **Manage Departments:**
   - Create new departments
   - Set department quotas
   - Configure department email

4. **Manage Programs:**
   - Create programs under departments
   - Set program prerequisites
   - Enable/disable programs

5. **Configure Admission Criteria:**
   - Set `criteria_json` for each department
   - Define aggregate formula
   - Set subject-specific requirements
   - Configure tie-breaker rules

6. **Manage Users:**
   - Create department admin accounts
   - Assign admins to departments
   - Reset admin passwords
   - View all user activity

7. **View All Applications:**
   - Access all student applications
   - View decisions across all departments
   - Monitor auto-admit engine results

8. **View Audit Logs:**
   - Access `logs` table for system activity
   - View `admission_flow_log` for all decisions
   - Export audit reports
   - Track IP addresses and timestamps

---

## 📁 PROJECT STRUCTURE

```
UCAM/
│
├── College Admission Management.sln
│   ├── My Project
│   ├── Dependencies
│   ├── Database.vb              # Configure for admin access
│   ├── Users[Admin Forms & Logic]
│   └── [Helper Classes]
│
├── College Admission Form.sln
│   ├── My Project
│   ├── StudentUser
│   ├── Database.vb              # Configure for student access
│   ├── Form1.vb                 # Main application form
│   ├── [Student Forms]
│   └── [Helper Classes]
│
├── plan_files/
│   └── UCAM_db.sql              # Database schema (9 tables)
│
└── Assets/
    ├── ucam_logo.png
    └── [Screenshots]
```

**Important:** Each solution has its **own Database.vb** file. Configure both separately based on your environment.

---

## 🔧 TECH STACK

| Component | Technology |
|-----------|-----------|
| **IDE** | Visual Studio 2022 |
| **Language** | VB.NET |
| **UI Framework** | Windows Forms (WinForms) |
| **Database** | MySQL 5.7+ |
| **Database Connector** | MySQL Connector/NET |
| **Server** | Apache (optional for web access) |
| **Operating System** | Windows 10+ |

---

## 📚 DOCUMENTATION

- **[DATABASE.md](./DATABASE.md)** - Complete database schema, tables, and relationships
- **[ARCHITECTURE.md](./ARCHITECTURE.md)** - System design, role-based architecture, decision engine flow

---

## 🎓 Academic Origin

**Project From:** University of Education, Winneba  
**Department:** BSc. Information & Communications Technology Education (ICTE)  
**Supervised By:** Dr. Daniel Danso Essel

---

## 📞 CONTACT & SUPPORT

For questions or support:
- **WhatsApp**: [Contact Engineers](https://wa.me/233507326320?text=*UCAM_From_Github_💬Message_:*%20)
- **GitHub**: Open an issue in the repository

---

<div align="center">

### Built with ❤️ for Ghana and Africa

**UCAM** | Solving Local Admission Challenges with Global-Class Solutions

</div>
