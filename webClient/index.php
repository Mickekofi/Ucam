<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Apply to College - Intelligent</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="index.css">
</head>
<body>
    <div class="form-container">
        <h2>Apply for Admission</h2>
        <form method="POST" action="backend/insert.php">

            <label>Full Name</label>
            <input type="text" name="full_name" required>

            <label>Email Address</label>
            <input type="email" name="email" required>

            <label>Phone Number</label>
            <input type="tel" name="phone" required>

            <label>Index Number (WAEC)</label>
            <input type="text" name="index_number" required>

            <label>Date of Birth</label>
            <input type="date" name="dob" required>

            <label>Gender</label>
            <select name="gender" required>
                <option value="">-- Select --</option>
                <option value="Male">Male</option>
                <option value="Female">Female</option>
            </select>

            <p class="sub-header">WAEC Core Subjects</p>

            <label>English</label>
            <select name="waec[English]" required>
                <option value="">-- Select Grade --</option>
                <option value="A1">A1</option>
                <option value="B2">B2</option>
                <option value="B3">B3</option>
                <option value="C4">C4</option>
                <option value="C5">C5</option>
                <option value="C6">C6</option>
                <option value="D7">D7</option>
                <option value="E8">E8</option>
                <option value="F9">F9</option>
            </select>

            <label>Mathematics</label>
            <select name="waec[Mathematics]" required>
                <option value="">-- Select Grade --</option>
                <option value="A1">A1</option>
                <option value="B2">B2</option>
                <option value="B3">B3</option>
                <option value="C4">C4</option>
                <option value="C5">C5</option>
                <option value="C6">C6</option>
                <option value="D7">D7</option>
                <option value="E8">E8</option>
                <option value="F9">F9</option>
            </select>

            <label>Integrated Science</label>
            <select name="waec[Integrated Science]" required>
                <option value="">-- Select Grade --</option>
                <option value="A1">A1</option>
                <option value="B2">B2</option>
                <option value="B3">B3</option>
                <option value="C4">C4</option>
                <option value="C5">C5</option>
                <option value="C6">C6</option>
                <option value="D7">D7</option>
                <option value="E8">E8</option>
                <option value="F9">F9</option>
            </select>

            <label>Social Studies</label>
            <select name="waec[Social Studies]" required>
                <option value="">-- Select Grade --</option>
                <option value="A1">A1</option>
                <option value="B2">B2</option>
                <option value="B3">B3</option>
                <option value="C4">C4</option>
                <option value="C5">C5</option>
                <option value="C6">C6</option>
                <option value="D7">D7</option>
                <option value="E8">E8</option>
                <option value="F9">F9</option>
            </select>

            <p class="sub-header">Elective Subjects</p>

            <label>Elective Subject 1</label>
            <select name="elective1_name" required>
                <option value="">-- Select Subject --</option>
                <option value="English">English</option>
                <option value="Mathematics">Mathematics</option>
                <option value="Integrated Science">Integrated Science</option>
                <option value="Social Studies">Social Studies</option>
                <option value="Business Management">Business Management</option>
                <option value="Financial Accounting">Financial Accounting</option>
                <option value="Economics">Economics</option>
                <option value="Cost Accounting">Cost Accounting</option>
                <option value="Elective Mathematics">Elective Mathematics</option>
                <option value="Elective ICT">Elective ICT</option>
                <option value="French">French</option>
                <option value="Clerical Office Duties">Clerical Office Duties</option>
                <option value="Computer Science">Computer Science</option>
                <option value="General Knowledge in Art">General Knowledge in Art</option>
                <option value="Textile">Textile</option>
                <option value="Picture Making">Picture Making</option>
                <option value="Ceramics and Sculpture">Ceramics and Sculpture</option>
                <option value="Graphic Design">Graphic Design</option>
                <option value="Leather Work">Leather Work</option>
                <option value="Basketry">Basketry</option>
                <option value="Food and Nutrition">Food and Nutrition</option>
                <option value="Clothing and Textiles">Clothing and Textiles</option>
                <option value="Management in Living">Management in Living</option>
                <option value="Elective Biology">Elective Biology</option>
                <option value="Elective Chemistry">Elective Chemistry</option>
                <option value="Literature in English">Literature in English</option>
                <option value="Christian Religious Studies">Christian Religious Studies</option>
                <option value="Government">Government</option>
                <option value="Fante">Fante</option>
                <option value="Ga">Ga</option>
                <option value="Ewe">Ewe</option>
                <option value="Arabic">Arabic</option>
                <option value="Dagaare">Dagaare</option>
                <option value="Dagbani">Dagbani</option>
                <option value="Gonja">Gonja</option>
                <option value="Kasem">Kasem</option>
                <option value="Nzema">Nzema</option>
                <option value="Akuapem Twi">Akuapem Twi</option>
                <option value="Asante Twi">Asante Twi</option>
                <option value="Music">Music</option>
                <option value="History">History</option>
                <option value="Elective Physics">Elective Physics</option>
                <option value="Geography">Geography</option>
                <option value="Animal Husbandry">Animal Husbandry</option>
                <option value="General Agricultural Science">General Agricultural Science</option>
                <option value="Crop Husbandry and Horticulture">Crop Husbandry and Horticulture</option>
                <option value="Fisheries">Fisheries</option>
                <option value="Forestry">Forestry</option>
                <option value="Ceramics">Ceramics</option>
                <option value="Auto Mechanics">Auto Mechanics</option>
                <option value="Woodwork">Woodwork</option>
                <option value="Metal Work">Metal Work</option>
                <option value="Applied Electricity">Applied Electricity</option>
                <option value="Jewellery">Jewellery</option>
                <option value="West African Traditional Religion">West African Traditional Religion</option>
                <option value="Islamic Studies">Islamic Studies</option>
                <option value="Typewriting">Typewriting</option>
                <option value="Building construction">Building construction</option>
                <option value="Technical Drawing">Technical Drawing</option>
            </select>
            <label>Grade</label>
            <select name="elective1_grade" required>
                <option value="">-- Select Grade --</option>
                <option value="A1">A1</option>
                <option value="B2">B2</option>
                <option value="B3">B3</option>
                <option value="C4">C4</option>
                <option value="C5">C5</option>
                <option value="C6">C6</option>
                <option value="D7">D7</option>
                <option value="E8">E8</option>
                <option value="F9">F9</option>
            </select>

            <label>Elective Subject 2</label>
            <select name="elective2_name" required>
                <option value="">-- Select Subject --</option>
                <option value="English">English</option>
                <option value="Mathematics">Mathematics</option>
                <option value="Integrated Science">Integrated Science</option>
                <option value="Social Studies">Social Studies</option>
                <option value="Business Management">Business Management</option>
                <option value="Financial Accounting">Financial Accounting</option>
                <option value="Economics">Economics</option>
                <option value="Cost Accounting">Cost Accounting</option>
                <option value="Elective Mathematics">Elective Mathematics</option>
                <option value="Elective ICT">Elective ICT</option>
                <option value="French">French</option>
                <option value="Clerical Office Duties">Clerical Office Duties</option>
                <option value="Computer Science">Computer Science</option>
                <option value="General Knowledge in Art">General Knowledge in Art</option>
                <option value="Textile">Textile</option>
                <option value="Picture Making">Picture Making</option>
                <option value="Ceramics and Sculpture">Ceramics and Sculpture</option>
                <option value="Graphic Design">Graphic Design</option>
                <option value="Leather Work">Leather Work</option>
                <option value="Basketry">Basketry</option>
                <option value="Food and Nutrition">Food and Nutrition</option>
                <option value="Clothing and Textiles">Clothing and Textiles</option>
                <option value="Management in Living">Management in Living</option>
                <option value="Elective Biology">Elective Biology</option>
                <option value="Elective Chemistry">Elective Chemistry</option>
                <option value="Literature in English">Literature in English</option>
                <option value="Christian Religious Studies">Christian Religious Studies</option>
                <option value="Government">Government</option>
                <option value="Fante">Fante</option>
                <option value="Ga">Ga</option>
                <option value="Ewe">Ewe</option>
                <option value="Arabic">Arabic</option>
                <option value="Dagaare">Dagaare</option>
                <option value="Dagbani">Dagbani</option>
                <option value="Gonja">Gonja</option>
                <option value="Kasem">Kasem</option>
                <option value="Nzema">Nzema</option>
                <option value="Akuapem Twi">Akuapem Twi</option>
                <option value="Asante Twi">Asante Twi</option>
                <option value="Music">Music</option>
                <option value="History">History</option>
                <option value="Elective Physics">Elective Physics</option>
                <option value="Geography">Geography</option>
                <option value="Animal Husbandry">Animal Husbandry</option>
                <option value="General Agricultural Science">General Agricultural Science</option>
                <option value="Crop Husbandry and Horticulture">Crop Husbandry and Horticulture</option>
                <option value="Fisheries">Fisheries</option>
                <option value="Forestry">Forestry</option>
                <option value="Ceramics">Ceramics</option>
                <option value="Auto Mechanics">Auto Mechanics</option>
                <option value="Woodwork">Woodwork</option>
                <option value="Metal Work">Metal Work</option>
                <option value="Applied Electricity">Applied Electricity</option>
                <option value="Jewellery">Jewellery</option>
                <option value="West African Traditional Religion">West African Traditional Religion</option>
                <option value="Islamic Studies">Islamic Studies</option>
                <option value="Typewriting">Typewriting</option>
                <option value="Building construction">Building construction</option>
                <option value="Technical Drawing">Technical Drawing</option>
            </select>
            <label>Grade</label>
            <select name="elective2_grade" required>
                <option value="">-- Select Grade --</option>
                <option value="A1">A1</option>
                <option value="B2">B2</option>
                <option value="B3">B3</option>
                <option value="C4">C4</option>
                <option value="C5">C5</option>
                <option value="C6">C6</option>
                <option value="D7">D7</option>
                <option value="E8">E8</option>
                <option value="F9">F9</option>
            </select>

            <label>Elective Subject 3</label>
            <select name="elective3_name" required>
                <option value="">-- Select Subject --</option>
                <option value="English">English</option>
                <option value="Mathematics">Mathematics</option>
                <option value="Integrated Science">Integrated Science</option>
                <option value="Social Studies">Social Studies</option>
                <option value="Business Management">Business Management</option>
                <option value="Financial Accounting">Financial Accounting</option>
                <option value="Economics">Economics</option>
                <option value="Cost Accounting">Cost Accounting</option>
                <option value="Elective Mathematics">Elective Mathematics</option>
                <option value="Elective ICT">Elective ICT</option>
                <option value="French">French</option>
                <option value="Clerical Office Duties">Clerical Office Duties</option>
                <option value="Computer Science">Computer Science</option>
                <option value="General Knowledge in Art">General Knowledge in Art</option>
                <option value="Textile">Textile</option>
                <option value="Picture Making">Picture Making</option>
                <option value="Ceramics and Sculpture">Ceramics and Sculpture</option>
                <option value="Graphic Design">Graphic Design</option>
                <option value="Leather Work">Leather Work</option>
                <option value="Basketry">Basketry</option>
                <option value="Food and Nutrition">Food and Nutrition</option>
                <option value="Clothing and Textiles">Clothing and Textiles</option>
                <option value="Management in Living">Management in Living</option>
                <option value="Elective Biology">Elective Biology</option>
                <option value="Elective Chemistry">Elective Chemistry</option>
                <option value="Literature in English">Literature in English</option>
                <option value="Christian Religious Studies">Christian Religious Studies</option>
                <option value="Government">Government</option>
                <option value="Fante">Fante</option>
                <option value="Ga">Ga</option>
                <option value="Ewe">Ewe</option>
                <option value="Arabic">Arabic</option>
                <option value="Dagaare">Dagaare</option>
                <option value="Dagbani">Dagbani</option>
                <option value="Gonja">Gonja</option>
                <option value="Kasem">Kasem</option>
                <option value="Nzema">Nzema</option>
                <option value="Akuapem Twi">Akuapem Twi</option>
                <option value="Asante Twi">Asante Twi</option>
                <option value="Music">Music</option>
                <option value="History">History</option>
                <option value="Elective Physics">Elective Physics</option>
                <option value="Geography">Geography</option>
                <option value="Animal Husbandry">Animal Husbandry</option>
                <option value="General Agricultural Science">General Agricultural Science</option>
                <option value="Crop Husbandry and Horticulture">Crop Husbandry and Horticulture</option>
                <option value="Fisheries">Fisheries</option>
                <option value="Forestry">Forestry</option>
                <option value="Ceramics">Ceramics</option>
                <option value="Auto Mechanics">Auto Mechanics</option>
                <option value="Woodwork">Woodwork</option>
                <option value="Metal Work">Metal Work</option>
                <option value="Applied Electricity">Applied Electricity</option>
                <option value="Jewellery">Jewellery</option>
                <option value="West African Traditional Religion">West African Traditional Religion</option>
                <option value="Islamic Studies">Islamic Studies</option>
                <option value="Typewriting">Typewriting</option>
                <option value="Building construction">Building construction</option>
                <option value="Technical Drawing">Technical Drawing</option>
            </select>
            <label>Grade</label>
            <select name="elective3_grade" required>
                <option value="">-- Select Grade --</option>
                <option value="A1">A1</option>
                <option value="B2">B2</option>
                <option value="B3">B3</option>
                <option value="C4">C4</option>
                <option value="C5">C5</option>
                <option value="C6">C6</option>
                <option value="D7">D7</option>
                <option value="E8">E8</option>
                <option value="F9">F9</option>
            </select>

            <label>Elective Subject 4</label>
            <select name="elective4_name" required>
                <option value="">-- Select Subject --</option>
                <option value="English">English</option>
                <option value="Mathematics">Mathematics</option>
                <option value="Integrated Science">Integrated Science</option>
                <option value="Social Studies">Social Studies</option>
                <option value="Business Management">Business Management</option>
                <option value="Financial Accounting">Financial Accounting</option>
                <option value="Economics">Economics</option>
                <option value="Cost Accounting">Cost Accounting</option>
                <option value="Elective Mathematics">Elective Mathematics</option>
                <option value="Elective ICT">Elective ICT</option>
                <option value="French">French</option>
                <option value="Clerical Office Duties">Clerical Office Duties</option>
                <option value="Computer Science">Computer Science</option>
                <option value="General Knowledge in Art">General Knowledge in Art</option>
                <option value="Textile">Textile</option>
                <option value="Picture Making">Picture Making</option>
                <option value="Ceramics and Sculpture">Ceramics and Sculpture</option>
                <option value="Graphic Design">Graphic Design</option>
                <option value="Leather Work">Leather Work</option>
                <option value="Basketry">Basketry</option>
                <option value="Food and Nutrition">Food and Nutrition</option>
                <option value="Clothing and Textiles">Clothing and Textiles</option>
                <option value="Management in Living">Management in Living</option>
                <option value="Elective Biology">Elective Biology</option>
                <option value="Elective Chemistry">Elective Chemistry</option>
                <option value="Literature in English">Literature in English</option>
                <option value="Christian Religious Studies">Christian Religious Studies</option>
                <option value="Government">Government</option>
                <option value="Fante">Fante</option>
                <option value="Ga">Ga</option>
                <option value="Ewe">Ewe</option>
                <option value="Arabic">Arabic</option>
                <option value="Dagaare">Dagaare</option>
                <option value="Dagbani">Dagbani</option>
                <option value="Gonja">Gonja</option>
                <option value="Kasem">Kasem</option>
                <option value="Nzema">Nzema</option>
                <option value="Akuapem Twi">Akuapem Twi</option>
                <option value="Asante Twi">Asante Twi</option>
                <option value="Music">Music</option>
                <option value="History">History</option>
                <option value="Elective Physics">Elective Physics</option>
                <option value="Geography">Geography</option>
                <option value="Animal Husbandry">Animal Husbandry</option>
                <option value="General Agricultural Science">General Agricultural Science</option>
                <option value="Crop Husbandry and Horticulture">Crop Husbandry and Horticulture</option>
                <option value="Fisheries">Fisheries</option>
                <option value="Forestry">Forestry</option>
                <option value="Ceramics">Ceramics</option>
                <option value="Auto Mechanics">Auto Mechanics</option>
                <option value="Woodwork">Woodwork</option>
                <option value="Metal Work">Metal Work</option>
                <option value="Applied Electricity">Applied Electricity</option>
                <option value="Jewellery">Jewellery</option>
                <option value="West African Traditional Religion">West African Traditional Religion</option>
                <option value="Islamic Studies">Islamic Studies</option>
                <option value="Typewriting">Typewriting</option>
                <option value="Building construction">Building construction</option>
                <option value="Technical Drawing">Technical Drawing</option>
            </select>
            <label>Grade</label>
            <select name="elective4_grade" required>
                <option value="">-- Select Grade --</option>
                <option value="A1">A1</option>
                <option value="B2">B2</option>
                <option value="B3">B3</option>
                <option value="C4">C4</option>
                <option value="C5">C5</option>
                <option value="C6">C6</option>
                <option value="D7">D7</option>
                <option value="E8">E8</option>
                <option value="F9">F9</option>
            </select>

            <p class="sub-header">College Program Choices</p>

            <label>1st Choice</label>
            <select name="choice_1" required>
                <option value="">-- Select Program --</option>
                <option value="1">Computer Science</option>
                <option value="2">Mathematics</option>
                <option value="3">Social Studies</option>
            </select>

            <label>2nd Choice</label>
            <select name="choice_2">
                <option value="">-- Select Program --</option>
                <option value="1">Computer Science</option>
                <option value="2">Mathematics</option>
                <option value="3">Social Studies</option>
            </select>

            <label>3rd Choice</label>
            <select name="choice_3">
                <option value="">-- Select Program --</option>
                <option value="1">Computer Science</option>
                <option value="2">Mathematics</option>
                <option value="3">Social Studies</option>
            </select>

            <button type="submit">Submit Application</button>
        </form>
    
    </div>
    <script src="index.js"></script>
</body>
</html>