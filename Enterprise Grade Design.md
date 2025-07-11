# 🧑‍💻 Technical Developer Documentation

This section is intended for **developers and technical teams** deploying, customizing, or maintaining the Intelligent College Admission Management System (ICAMS).

---

## 🧩 System Modules Overview

### 🌐 Web-Based Frontend (Student Side)

| Component                 | Tech                                      |
|---------------------------|-------------------------------------------|
| Form Submission           | HTML/CSS, PHP (with PDO)                  |
| Grade & Choice Input      | Web Form                                  |
| Data Validation & Storage | PHP server-side logic                     |
| Database                  | Central MySQL (LAN or tunnel)             |
| Email Notification        | PHP + SMTP (e.g., Gmail or school domain) |

---

### 🖥️ Desktop-Based Admin Panel (Department Side)

| Component                 | Tech                      |
|---------------------------|---------------------------|
| VB.NET WinForms GUI       | Visual Studio Community   |
| MySQL Connection          | MySQL .NET Connector      |
| Excel Report Generator    | EPPlus or Interop         |
| Admission Filtering Logic | Custom coded in VB.NET    |
| Login & User Tracking     | Role-based access control |
| Sync & Quota Monitor      | Real-time via LAN         |

---

## 🚀 Technology Stack Summary

| Layer                | Tool/Tech                                   |
|----------------------|---------------------------------------------|
| UI (Student)         | HTML, CSS                                   |
| Server Logic         | PHP (with PDO)                              |
| Admin Interface      | VB.NET WinForms                             |
| Database             | MySQL 8+                                    |
| Communication        | LAN (using IP + Port)                       |
| Reporting            | Excel (VB.NET EPPlus or Interop)            |
| Mailing              | PHPMailer / System.Net.Mail                 |
| Tunneling (Optional) | Ngrok / Cloudflare Tunnel for public access |

---

## 🏗️ LAN Deployment Architecture

| Component           | Description                                                              |
|---------------------|--------------------------------------------------------------------------|
| 🧠 MySQL Server     | Hosted on central PC in the LAN                                          |
| 🖥️ VB.NET Clients  | Connect via local IP (e.g. `192.168.1.10`)                               |
| 🌐 Web Interface    | Served from same PC (XAMPP/Apache), accessible via LAN browser or Ngrok  |
| 📤 Emails           | Sent using local SMTP or cloud SMTP (Gmail, SendGrid, etc.)              |

---

## 🧱 System Architecture Diagram (Described Textually)

```text
            ┌────────────────────────────┐
            │     Student Browser        │
            │    (Form Submission)       │
            └────────────┬───────────────┘
                         │
                         ▼
          ┌───────────────────────────────┐
          │    PHP Web Server (Apache)    │
          │    - Handles Form Input       │
          │    - Sends Email + PDF        │
          └────────────┬──────────────────┘
                         │
                         ▼
             ┌────────────────────┐
             │  MySQL 8+ Database │
             └────────┬───────────┘
                      │
       ┌──────────────┼───────────────┐
       ▼                              ▼
┌─────────────┐              ┌────────────────┐
│ VB.NET Admin│              │ VB.NET Super   │
│ (Dept User) │              │ Admin App      │
└─────────────┘              └────────────────┘

🖧 All components communicate via LAN or tunnel
