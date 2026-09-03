<?php
require_once DIR . '/../include/dbh.inc.php';

if ($_SERVER['REQUEST_METHOD'] !== 'POST') {
    exit("Invalid request method. Please submit the form properly.");
}

try {
    // Collect basic student info
    $name = $_POST['full_name'];
    $email = $_POST['email'];
    $phone = $_POST['phone'];
    $index = $_POST['index_number'];
    $dob = $_POST['dob'];
    $gender = $_POST['gender'];

    // Validate phone number (10 digits)
    if (!preg_match('/^\d{10}$/', $phone)) {
        exit("Invalid phone number. Please enter a 10-digit phone number.");
    }

    // Validate WAEC index number (10 digits)
    if (!preg_match('/^\d{10}$/', $index)) {
        exit("Invalid index number. Please enter a 10-digit WAEC index number.");
    }

    // Handle WAEC grades
    $waec_results = $_POST['waec']; // core subjects
    for ($i = 1; $i <= 4; $i++) {
        $subject = trim($_POST["elective{$i}_name"]);
        $grade = $_POST["elective{$i}_grade"];
        if ($subject !== "" && $grade !== "") {
            $waec_results[$subject] = $grade;
        }
    }

    $waec_results_json = json_encode($waec_results);

    // Program choices
    $choice1 = $_POST['choice_1'];
    $choice2 = $_POST['choice_2'];
    $choice3 = $_POST['choice_3'];
    $year = date('Y');

    // Insert into students table
    $stmt = $pdo->prepare("INSERT INTO students 
        (full_name, email, phone_number, index_number, dob, gender, waec_results_json, application_year, status)
        VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)");

    $stmt->execute([
        $name, $email, $phone, $index, $dob, $gender, $waec_results_json, $year, 'Pending'
    ]);

    $student_id = $pdo->lastInsertId();

    // Insert program choices
    $choices = [
        ['program_id' => $choice1, 'rank' => 1],
        ['program_id' => $choice2, 'rank' => 2],
        ['program_id' => $choice3, 'rank' => 3]
    ];

    $stmt2 = $pdo->prepare("INSERT INTO program_choices 
        (student_id, program_id, choice_rank, result)
        VALUES (?, ?, ?, ?)");

    foreach ($choices as $choice) {
        if (!empty($choice['program_id'])) {
            $stmt2->execute([$student_id, $choice['program_id'], $choice['rank'], 'Pending']);
        }
    }

    // Redirect to thank you page
    header("Location: thankyou.php?app_id=" . $student_id);
    exit();

} catch (Exception $e) {
    echo "<h3 style='color:red;'>Error: " . $e->getMessage() . "</h3>";
    exit();
}
?>