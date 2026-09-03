# Re-create the full schema SQL file after code execution state reset

-- Create the database
CREATE DATABASE IF NOT EXISTS intelligent_admission;
USE intelligent_admission;

-- Students Table
CREATE TABLE IF NOT EXISTS students (
    student_id INT AUTO_INCREMENT PRIMARY KEY,
    full_name VARCHAR(100) NOT NULL,
    email VARCHAR(100),
    phone_number VARCHAR(15),
    index_number VARCHAR(15) NOT NULL UNIQUE,
    dob DATE,
    gender ENUM('Male', 'Female'),
    waec_results_json TEXT,
    application_year YEAR,
    status ENUM('Pending', 'Admitted', 'Rejected', 'Resubmitted') DEFAULT 'Pending',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Programs Table
CREATE TABLE IF NOT EXISTS programs (
    program_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    department_id INT,
    min_aggregate INT,
    active BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (department_id) REFERENCES departments(department_id)
);

-- Departments Table
CREATE TABLE IF NOT EXISTS departments (
    department_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100),
    quota INT DEFAULT 100,
    criteria_json TEXT,
    active_year YEAR,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Program Choices Table
CREATE TABLE IF NOT EXISTS program_choices (
    choice_id INT AUTO_INCREMENT PRIMARY KEY,
    student_id INT,
    program_id INT,
    choice_rank TINYINT,
    result ENUM('Pending', 'Admitted', 'Rejected') DEFAULT 'Pending',
    decision_notes TEXT,
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    FOREIGN KEY (program_id) REFERENCES programs(program_id) ON DELETE CASCADE
);

-- Users Table
CREATE TABLE IF NOT EXISTS users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    role ENUM('department_admin', 'super_admin') DEFAULT 'department_admin',
    department_id INT,
    last_login DATETIME,
    FOREIGN KEY (department_id) REFERENCES departments(department_id)
);

-- Admissions Table
CREATE TABLE IF NOT EXISTS admissions (
    admission_id INT AUTO_INCREMENT PRIMARY KEY,
    student_id INT,
    program_id INT,
    choice_rank INT,
    decision_by_user INT,
    status ENUM('Admitted', 'Rejected') DEFAULT 'Admitted',
    date_decided DATETIME,
    FOREIGN KEY (student_id) REFERENCES students(student_id),
    FOREIGN KEY (program_id) REFERENCES programs(program_id),
    FOREIGN KEY (decision_by_user) REFERENCES users(user_id)
);

-- Logs Table
CREATE TABLE IF NOT EXISTS logs (
    log_id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT,
    action TEXT,
    ip_address VARCHAR(45),
    timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (user_id) REFERENCES users(user_id)
);

-- Settings Table
CREATE TABLE IF NOT EXISTS settings (
    key VARCHAR(100) PRIMARY KEY,
    value TEXT
);

-- Admission Flow Log Table
CREATE TABLE IF NOT EXISTS admission_flow_log (
    log_id INT AUTO_INCREMENT PRIMARY KEY,
    student_id INT,
    department_id INT,
    choice_rank INT,
    decision ENUM('Rejected', 'Passed'),
    note TEXT,
    timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (student_id) REFERENCES students(student_id),
    FOREIGN KEY (department_id) REFERENCES departments(department_id)
);
