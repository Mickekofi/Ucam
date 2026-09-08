-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 28, 2026 at 06:17 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ucam_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `admissions`
--

CREATE TABLE `admissions` (
  `admission_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `program_id` int(11) NOT NULL,
  `choice_rank` int(11) DEFAULT NULL,
  `decision_by_user` int(11) DEFAULT NULL,
  `status` enum('Admitted','Rejected') DEFAULT 'Admitted',
  `date_decided` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `admission_flow_log`
--

CREATE TABLE `admission_flow_log` (
  `log_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `department_id` int(11) NOT NULL,
  `choice_rank` int(11) DEFAULT NULL,
  `decision` enum('Rejected','Passed') DEFAULT NULL,
  `note` text DEFAULT NULL,
  `timestamp` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `departments`
--

CREATE TABLE `departments` (
  `department_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `quota` int(11) DEFAULT 100,
  `criteria_json` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`criteria_json`)),
  `active_year` year(4) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `departments`
--

INSERT INTO `departments` (`department_id`, `name`, `email`, `quota`, `criteria_json`, `active_year`, `created_at`) VALUES
(2, 'ICTEducation', 'i@gmail.com', 500, '{\r\n  \"aggregate_formula\": {\r\n    \"core_subjects\": [\r\n      \"English\",\r\n      \"Mathematics\",\r\n      \"Integrated Science\",\r\n      \"Social Studies\"\r\n    ],\r\n    \"electives_required\": 1,\r\n    \"grade_map\": {\r\n      \"A1\": 1,\r\n      \"B2\": 2,\r\n      \"B3\": 3,\r\n      \"C4\": 4,\r\n      \"C5\": 5,\r\n      \"C6\": 6,\r\n      \"D7\": 7,\r\n      \"E8\": 8,\r\n      \"F9\": 9\r\n    },\r\n    \"aggregate_max\": 24,\r\n    \"min_aggregate\": 12\r\n  },\r\n  \"subject_requirements\": [\r\n    {\r\n      \"subject\": \"Mathematics\",\r\n      \"max_grade\": \"C6\"\r\n    }\r\n  ],\r\n  \"weights\": {},\r\n  \"tie_breakers\": [\r\n    \"aggregate_asc\",\r\n    \"math_grade_asc\",\r\n    \"dob_older_first\"\r\n  ]\r\n}', '2026', '2026-07-27 23:58:49'),
(3, 'Business Department', 'b@gmail.com', 500, '{\r\n  \"aggregate_formula\": {\r\n    \"core_subjects\": [\r\n      \"English\",\r\n      \"Mathematics\",\r\n      \"Integrated Science\",\r\n      \"Social Studies\"\r\n    ],\r\n    \"electives_required\": 1,\r\n    \"grade_map\": {\r\n      \"A1\": 1,\r\n      \"B2\": 2,\r\n      \"B3\": 3,\r\n      \"C4\": 4,\r\n      \"C5\": 5,\r\n      \"C6\": 6,\r\n      \"D7\": 7,\r\n      \"E8\": 8,\r\n      \"F9\": 9\r\n    },\r\n    \"aggregate_max\": 24,\r\n    \"min_aggregate\": 20\r\n  },\r\n  \"subject_requirements\": [\r\n    {\r\n      \"subject\": \"Elective Mathematics\",\r\n      \"max_grade\": \"C6\"\r\n    }\r\n  ],\r\n  \"weights\": {},\r\n  \"tie_breakers\": [\r\n    \"aggregate_asc\",\r\n    \"math_grade_asc\",\r\n    \"dob_older_first\"\r\n  ]\r\n}', '2026', '2026-07-28 14:19:06');

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

CREATE TABLE `logs` (
  `log_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `action` text NOT NULL,
  `target_id` int(11) DEFAULT NULL,
  `ip_address` varchar(45) DEFAULT NULL,
  `timestamp` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `programs`
--

CREATE TABLE `programs` (
  `program_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `department_id` int(11) DEFAULT NULL,
  `min_aggregate` int(11) DEFAULT NULL,
  `active` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `programs`
--

INSERT INTO `programs` (`program_id`, `name`, `department_id`, `min_aggregate`, `active`) VALUES
(1, 'Bsc Computing', 2, 20, 1),
(2, 'Bsc Human Resource', 3, 20, 1);

-- --------------------------------------------------------

--
-- Table structure for table `program_choices`
--

CREATE TABLE `program_choices` (
  `choice_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `program_id` int(11) NOT NULL,
  `choice_rank` tinyint(4) NOT NULL,
  `result` enum('Pending','Admitted','Rejected') DEFAULT 'Pending',
  `decision_notes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `program_choices`
--

INSERT INTO `program_choices` (`choice_id`, `student_id`, `program_id`, `choice_rank`, `result`, `decision_notes`) VALUES
(1, 1, 2, 1, 'Pending', NULL),
(2, 1, 2, 3, 'Pending', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `settings`
--

CREATE TABLE `settings` (
  `setting_key` varchar(100) NOT NULL,
  `setting_value` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `student_id` int(11) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `phone_number` varchar(15) DEFAULT NULL,
  `index_number` varchar(15) NOT NULL,
  `dob` date DEFAULT NULL,
  `gender` enum('Male','Female') DEFAULT NULL,
  `waec_results_json` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL CHECK (json_valid(`waec_results_json`)),
  `application_year` year(4) DEFAULT NULL,
  `status` enum('Pending','Admitted','Rejected','Resubmitted') DEFAULT 'Pending',
  `passport_photo_path` varchar(500) DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`student_id`, `full_name`, `email`, `phone_number`, `index_number`, `dob`, `gender`, `waec_results_json`, `application_year`, `status`, `passport_photo_path`, `created_at`) VALUES
(1, 'Richmond Asiedu', 'Richmondasiedu630@gmail.com', '0557037737', '5251570179', '2004-07-28', 'Male', '{\"English\":\"B2\",\"Mathematics\":\"B2\",\"Integrated Science\":\"C4\",\"Social Studies\":\"B3\",\"Elective ICT\":\"B2\",\"Elective Mathematics\":\"B3\",\"Elective Biology\":\"C6\",\"Elective Chemistry\":\"B2\"}', '2026', 'Pending', '\\Users\\EVANS\\Downloads\\Int-elligent Schools(New)\\Int-elligent Schools(New)\\Int-elligent Schools\\College Admission Form\\bin\\Debug\\net9.0-windows\\PassportPhotos\\5251570179_passport.jpg', '2026-07-28 14:34:36');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `role` enum('department_admin','super_admin') DEFAULT 'department_admin',
  `department_id` int(11) DEFAULT NULL,
  `last_login` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password_hash`, `role`, `department_id`, `last_login`) VALUES
(1, 'SuperAdmin', '1234', 'super_admin', NULL, NULL),
(2, 'admin', '12345', 'super_admin', NULL, '2026-07-28 14:16:35'),
(3, 'ICTAdmin', '1234', 'department_admin', 2, '2026-07-28 03:18:17'),
(4, 'BAdmin', '12345', 'department_admin', 3, '2026-07-28 14:26:05');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admissions`
--
ALTER TABLE `admissions`
  ADD PRIMARY KEY (`admission_id`),
  ADD KEY `student_id` (`student_id`),
  ADD KEY `program_id` (`program_id`),
  ADD KEY `decision_by_user` (`decision_by_user`);

--
-- Indexes for table `admission_flow_log`
--
ALTER TABLE `admission_flow_log`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `student_id` (`student_id`),
  ADD KEY `department_id` (`department_id`);

--
-- Indexes for table `departments`
--
ALTER TABLE `departments`
  ADD PRIMARY KEY (`department_id`);

--
-- Indexes for table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `programs`
--
ALTER TABLE `programs`
  ADD PRIMARY KEY (`program_id`),
  ADD KEY `department_id` (`department_id`);

--
-- Indexes for table `program_choices`
--
ALTER TABLE `program_choices`
  ADD PRIMARY KEY (`choice_id`),
  ADD KEY `student_id` (`student_id`),
  ADD KEY `program_id` (`program_id`);

--
-- Indexes for table `settings`
--
ALTER TABLE `settings`
  ADD PRIMARY KEY (`setting_key`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`student_id`),
  ADD UNIQUE KEY `index_number` (`index_number`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD KEY `department_id` (`department_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admissions`
--
ALTER TABLE `admissions`
  MODIFY `admission_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `admission_flow_log`
--
ALTER TABLE `admission_flow_log`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `departments`
--
ALTER TABLE `departments`
  MODIFY `department_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `logs`
--
ALTER TABLE `logs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `programs`
--
ALTER TABLE `programs`
  MODIFY `program_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `program_choices`
--
ALTER TABLE `program_choices`
  MODIFY `choice_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `student_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `admissions`
--
ALTER TABLE `admissions`
  ADD CONSTRAINT `admissions_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `admissions_ibfk_2` FOREIGN KEY (`program_id`) REFERENCES `programs` (`program_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `admissions_ibfk_3` FOREIGN KEY (`decision_by_user`) REFERENCES `users` (`user_id`) ON DELETE SET NULL;

--
-- Constraints for table `admission_flow_log`
--
ALTER TABLE `admission_flow_log`
  ADD CONSTRAINT `admission_flow_log_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `admission_flow_log_ibfk_2` FOREIGN KEY (`department_id`) REFERENCES `departments` (`department_id`) ON DELETE CASCADE;

--
-- Constraints for table `logs`
--
ALTER TABLE `logs`
  ADD CONSTRAINT `logs_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE SET NULL;

--
-- Constraints for table `programs`
--
ALTER TABLE `programs`
  ADD CONSTRAINT `programs_ibfk_1` FOREIGN KEY (`department_id`) REFERENCES `departments` (`department_id`) ON DELETE SET NULL;

--
-- Constraints for table `program_choices`
--
ALTER TABLE `program_choices`
  ADD CONSTRAINT `program_choices_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `program_choices_ibfk_2` FOREIGN KEY (`program_id`) REFERENCES `programs` (`program_id`) ON DELETE CASCADE;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`department_id`) REFERENCES `departments` (`department_id`) ON DELETE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
