<?php
$app_id = $_GET['app_id'] ?? 'N/A';
?>
<!DOCTYPE html>
<html>
<head>
    <title>Application Submitted</title>
    <style>
        body {{ background-color: #f0f8ff; font-family: Arial; text-align: center; padding: 100px; }}
        .box {{
            background: white;
            border-radius: 10px;
            padding: 40px;
            max-width: 500px;
            margin: auto;
            box-shadow: 0 0 10px #aaa;
        }}
    </style>
</head>
<body>
    <div class="box">
        <h2>🎉 Application Submitted Successfully!</h2>
        <p>Your Application ID is:</p>
        <h3>#<?php echo htmlspecialchars($app_id); ?></h3>
        <p>We will contact you via email after review.</p>
    </div>
</body>
</html>