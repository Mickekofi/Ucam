'Step-by-Step: Embed the GIF Correctly


'1. In Solution Explorer, right-click your project > Add > Existing Item…

'2. Choose your .gif file (e.g., loading.gif)

'3. Set It as an Embedded Resource
'With the .gif file selected in Solution Explorer, go to the Properties window.
'Find the Build Action dropdown and set it to Embedded Resource.

'a. Copy this code into Somthing like Form1_Load event or a button click event
Dim asm = System.Reflection.Assembly.GetExecutingAssembly()
Dim resources = asm.GetManifestResourceNames()
Dim output As String = String.Join(Environment.NewLine, resources)
MessageBox.Show(output, "Embedded Resources")

'this will show you the names of all embedded resources, including your GIF.from there look for the name that ends in your gif name and not the full string (eg. College_Admission_Form.doneGif.gif)

'b. Then Finnaly Use the following code to load and display the GIF in a PictureBox in your Form.Load event
'add' Imports System.Reflection
' Step 1: Gets a handle on the current running app
Dim asm = System.Reflection.Assembly.GetExecutingAssembly()
' Step 2: Retrieves the embedded GIF file as a stream
Dim stream = asm.GetManifestResourceStream("College_Admission_Form.doneGif.gif")
' Then Step 3: Converts that stream into an image and loads it into a PictureBox
PictureBox1.Image = Image.FromStream(stream)


