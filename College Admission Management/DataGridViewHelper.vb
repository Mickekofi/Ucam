Imports System.Drawing
Imports System.Windows.Forms

Module DataGridViewHelper

    ' 🌟 Function to adjust row height
    Public Sub AdjustDataGridViewRowHeight(dgv As DataGridView, height As Integer)
        dgv.RowTemplate.Height = height
        For Each row As DataGridViewRow In dgv.Rows
            row.Height = height
        Next
    End Sub

    ' 🌟 Function to apply colorful style
    Public Sub ApplyBeautifulStyle(dgv As DataGridView)
        With dgv
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            .ColumnHeadersHeight = 40

            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)

            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black

            .DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen
            .DefaultCellStyle.SelectionForeColor = Color.White

            .GridColor = Color.LightGray
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    ' 🌟 Function to create a properly fitting Photo column
    Public Function CreatePhotoColumn(Optional headerText As String = "Picture") As DataGridViewImageColumn
        Dim imgCol As New DataGridViewImageColumn()
        imgCol.Name = "Photo"
        imgCol.HeaderText = headerText
        imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch ' ✅ make it fit, not zoomed
        Return imgCol
    End Function

End Module
