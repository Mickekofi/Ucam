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
‎A Full hybrid Web(client) +plus Desktop(Admin) **College/University Admission Management Software** with an *Open Enterprise Grade Architecture Systems Design.*


> Before we throw dozens of words & docs at you…

> **Let’s Answer Your Question❓ in 2 Minutes:**

---

### ❓ Q1. What Special Features Have We Added That Most Systems in Ghana & Africa have not yet Seen ?

Simply we say;
####  1. A Decentralized Management Architecture  
####  2. Scalable User Permission System  
####  3. Controlled Role-Based Access  

Together, we call this:

## 🔐 R1 **Separation of Power Role Based Access Design**

Implemented via clearly defined roles:

- **Super Admins** : Global oversight & auditing
- **Department Admins** : Local, scoped access to their own department data

> ✓ Ensures accountability, clarity, scalability, and structured control.

---

##  R2. Smart Admission Decision Flow (1st, 2nd, 3rd Choice Ranking)

- If **1st choice** rejects → automatically flows to **2nd choice**
- If **2nd choice** rejects → automatically flows to **3rd choice**
- If **all 3 choices** reject → applicant is **politely rejected**

> ✓ Makes admission more dynamic, intelligent, and fair

---

## 🏛 R3. Departmental Autonomy + Central Control

- Each **department** sees **only their applicants**
- **Super Admin** sees **all data globally** and can audit any activity

> ✓ Prevents overload  
> ✓ Boosts clarity  
> ✓ Strengthens data security and accountability

---

## 📄 R4. Dynamic WAEC Results Stored in JSON Format

We use JSON format instead of hardcoded database fields to store WAEC results.

### Benefits:
- ✓ **Dynamic filtering** and **rule-based parsing**
- ✓ **AI-ready** scoring engine for future expansion
- ✓ **Easy schema updates** without altering table structures

---

## 📧 R5. Automation: Emails + PDF Receipts

As soon as an applicant submits:

- ✓ An **automated email** is sent
- ✓ A **PDF receipt** is generated and stored
- ✓ The student has **instant proof of submission**

> Enhances transparency, user trust, and system professionalism.

---

## ⚙️ R6. Auto-Admit Engine (Underrated Genius)

A unique module that auto-admits qualified applicants based on subject-grade criteria.

-  Uses `criteria_json` rules for fast validation
- ✓ Reduces manual workload
- ✓ Minimizes human bias
- ✓ Enables real-time admission

> A simple, scalable **semi-AI decision engine** without expensive AI tools.

---

##  R7. LAN-Based Multi-Client VB.NET Administration App

- The system works **locally over LAN**
- **Multiple department admins** can log in from different computers
- ✓ No internet needed  
- ✓ Fast, secure, and cost-effective deployment

---

## R8 Audit Logs & Admission Flow Tracking

Every action is logged in:

- `logs` table  
- `admission_flow_log` table

Each entry contains:

- 🕒 Timestamp  
- 🌐 IP Address  
- 👤 Responsible Admin  
- 📋 Decision Reason  

> ✓ Full transparency for accountability and auditing (even for regulators)

---

## Summary Table of Features

| Feature                             | Description                                                             |
|-------------------------------------|-------------------------------------------------------------------------|
| ☞ Separation of Roles              | Super Admin vs Department Admins                                        |
| ☞ Smart Flow Logic                 | 1st → 2nd → 3rd Choice Admission Routing                                |
| ☞ Dynamic WAEC Results             | Stored as JSON, ready for rules-based parsing and future AI scoring     |
| ☞ Automated Acknowledgements       | Email + PDF receipt generated instantly                                 |
| ☞ Auto-Admit Decision Engine       | Semi-AI logic to admit applicants who meet defined criteria             |
| ☞ LAN Deployment                   | No internet dependency – works locally across a campus or office        |
| ☞ Auditable Logs                   | Tracks actions and decisions for full accountability                    |

---


## 🧭 How Schools Use This System (Step-by-Step for Non-Technical Users)

This guide explains how **students**, **department admins**, and **super admins** can use the system — no IT skills needed.

---

### 👨‍🎓 1. Student: How to Apply for Admission

1. **Visit the Application Portal:**
   - Open the link provided by the school (e.g. `http://localhost/intelligent_portal/` or a public Ngrok/Cloudflare link).

2. **Fill the Online Form:**
   - Enter personal details, SHS subjects and WAEC grades.
   - Choose your 1st, 2nd, and 3rd program preferences.
   - Upload any required documents.

3. **Submit Application:**
   - Click **Submit** after reviewing.
   - A **PDF receipt** is downloaded automatically.
   - A **confirmation email** is sent instantly.

4.  **Done!** The system now takes over with auto-screening.

---

### 🤖 2. Auto-Admit System: Smart, Instant Admission

If a student’s **WAEC grades match the admission criteria** of their:

- **1st choice** → The system **automatically admits** the student.
- ❌ If rejected → Automatically moves to **2nd choice**
- ❌ If rejected again → Moves to **3rd choice**
- ❌ If all 3 fail → A polite rejection message is generated.

 Criteria is stored in the system as smart rules (e.g., must get at least C6 in Math and English for BSc programs).

> 🎯 This eliminates bias, saves time, and ensures fair admission.

---

### 🧑‍💼 3. Department Admin: What You Can Do

1. **Open the Admin App:**
   - Double-click the Windows application (no browser needed).
   - Login using your assigned Department Admin credentials.

2. **Monitor Applicants in Your Department:**
   - View applicants who selected your department as 1st, 2nd, or 3rd choice.
   - See whether they were **auto-admitted** or still **pending**.

3. **Manually Review or Adjust Decisions (If Needed):**
   - For applicants who didn’t meet auto-admit criteria, you can:
     - Admit manually
     - Reject with a reason
   - You can also override auto decisions in special cases (if permitted).

4. **Export Reports:**
   - Download Excel or PDF list of admitted students.
   - Track all admission activities in a readable format.

---

### 👩‍💻 4. Super Admin: System Control & Monitoring

1. **Login to the Super Admin Dashboard**
   - Use the same app, but login as a Super Admin.

2. **Manage the Entire Admission Process:**
   - View all applicants across departments
   - Monitor all decisions (manual or automatic)
   - Update or add department-specific criteria

3. **Manage Admin Accounts:**
   - Create or remove department admin users
   - Reset passwords
   - Enable/disable programs

4. **View Logs & Reports:**
   - Every action is logged with:
     - Timestamp
     - Admin who took the action
     - Reason for decision
   - Logs are accessible and exportable

---

### 🧾 Summary of Roles

| Role              | Capabilities                                                                 |
|-------------------|------------------------------------------------------------------------------|
| 👨‍🎓 Student         | Applies online, receives PDF + email confirmation                            |
| 🤖 Auto-Admit Bot   | Automatically admits qualified students based on WAEC + subject criteria     |
| 🧑‍💼 Department Admin | Views and manages department-specific applicants; can override auto-decisions |
| 👩‍💻 Super Admin     | Full control over all departments, users, audit logs, and admission rules     |

---



- **Students** need only a browser or smartphone  
- **Admins** just open a desktop app and log in

> The system is designed for *ease, fairness, speed, and automation*. Schools without IT departments can still run full digital admissions — smoothly.



## ඏ Designed For:

- Universities, Colleges and Technical Universities
- Admission Committees
- Centralized/Decentralized School Systems
- Offline Environments with Local Networks

> Built with ❤️ for **Ghana and Africa**, to solve local problems with global-class solutions.

*A Project From the University of Education, Winneba* 

> Graded and Supervised by Doctor, Daniel Danso Essel [ ‎☞ D.D.E ](https://www.uew.edu.gh/dict/staff/ddessel)

> 
