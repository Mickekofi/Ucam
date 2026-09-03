<?php
// My Connection Variables 
$host = 'localhost';
$dbname = 'college_admission';
$username = 'root';
$password = '$LearnCreate6';


// The DSN (Data Source Name) -- this is the DB path
$dsn = "mysql:host=$host;dbname=$dbname;charset=utf8mb4";

try {
    // Create a new PDO instance or Object
    $pdo = new PDO($dsn, $username, $password);
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
} catch (PDOException $e) {
    die("Connection failed: " . $e->getMessage());
}
?>