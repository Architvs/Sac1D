Public Class Form1
    Dim english As Integer
    Dim maths As Integer
    Dim PE As Integer
    Dim average As Integer
    Dim enav As Integer
    Dim maav As Integer
    Dim peav As Integer
    Dim english1 As Integer
    Dim maths1 As Integer
    Dim PE1 As Integer
    Dim average1 As Integer
    Dim english2 As Integer
    Dim maths2 As Integer
    Dim PE2 As Integer
    Dim average2 As Integer
    Dim english3 As Integer
    Dim maths3 As Integer
    Dim PE3 As Integer
    Dim averag3 As Integer
    Dim english4 As Integer
    Dim maths4 As Integer
    Dim PE4 As Integer
    Dim average4 As Integer
    Dim english5 As Integer
    Dim maths5 As Integer
    Dim PE5 As Integer
    Dim average5 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox7.Text = ("ENGLISH" & "          " & "MATHS" & "          " & "PE" & "          " & "AVERAGE")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If english = 0 Then
            english = InputBox("How many marks would you like to award for John's english")
            TextBox1.Text = (english & "                      " & maths & "                      " & PE)
            english1 = InputBox("How many marks would you like to award for Damein's english")
            TextBox2.Text = (english1 & "                      " & maths1 & "                     " & PE1)
            english2 = InputBox("How many marks would you like to award for Mark's english")
            TextBox3.Text = (english2 & "                      " & maths2 & "                     " & PE2)
            english3 = InputBox("How many marks would you like to award for Joshua's english")
            TextBox4.Text = (english3 & "                      " & maths3 & "                     " & PE3)
            english4 = InputBox("How many marks would you like to award for Mary's english")
            TextBox5.Text = (english4 & "                      " & maths4 & "                     " & PE4)
            english5 = InputBox("How many marks would you like to award for Maria's english")
            TextBox6.Text = (english5 & "                      " & maths5 & "                     " & PE5)
            enav = (english + english1 + english2 + english3 + english4 + english5) / 6
            TextBox8.Text = (enav)
        Else
            MsgBox("Please click the reset button to reset the marks.")
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If maths = 0 Then
            maths = InputBox("How many marks would you like to award for John's maths")
            TextBox1.Text = (english & "                      " & maths & "                      " & PE)
            maths1 = InputBox("How many marks would you like to award for Damein's maths")
            TextBox2.Text = (english1 & "                      " & maths1 & "                      " & PE1)
            maths2 = InputBox("How many marks would you like to award for Mark's maths")
            TextBox3.Text = (english2 & "                      " & maths2 & "                      " & PE2)
            maths3 = InputBox("How many marks would you like to award for Joshua's maths")
            TextBox4.Text = (english3 & "                      " & maths3 & "                      " & PE3)
            maths4 = InputBox("How many marks would you like to award for Mary's maths")
            TextBox5.Text = (english4 & "                      " & maths4 & "                      " & PE4)
            maths5 = InputBox("How many marks would you like to award for Maria's maths")
            TextBox6.Text = (english5 & "                      " & maths5 & "                      " & PE5)
            maav = (maths + maths1 + maths2 + maths3 + maths4 + maths5) / 6
            TextBox8.Text = (enav & "                      " & maav)
        Else
            MsgBox("Please click the reset button to reset the marks.")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If PE = 0 Then
            PE = InputBox("How many marks would you like to award for John's PE")
            average = (english + maths + PE) / 3
            TextBox1.Text = (english & "                      " & maths & "                      " & PE & "                      " & average)
            PE1 = InputBox("How many marks would you like to award for Damein's PE")
            average1 = (english1 + maths1 + PE1) / 3
            TextBox2.Text = (english1 & "                       " & maths1 & "                     " & PE1 & "                      " & average1)
            PE2 = InputBox("How many marks would you like to award for Mark's PE")
            average2 = (english2 + maths2 + PE2) / 3
            TextBox3.Text = (english2 & "                      " & maths2 & "                      " & PE2 & "                      " & average2)
            PE3 = InputBox("How many marks would you like to award for Joshua's PE")
            averag3 = (english3 + maths3 + PE3) / 3
            TextBox4.Text = (english3 & "                      " & maths3 & "                      " & PE3 & "                      " & averag3)
            PE4 = InputBox("How many marks would you like to award for Mary's PE")
            average4 = (english4 + maths4 + PE4) / 3
            TextBox5.Text = (english4 & "                      " & maths4 & "                      " & PE4 & "                      " & average4)
            PE5 = InputBox("How many marks would you like to award for Maria's PE")
            average5 = (english5 + maths5 + PE5) / 3
            peav = (PE + PE1 + PE2 + PE3 + PE4 + PE5) / 6
            TextBox8.Text = (enav & "                      " & maav & "                      " & peav)
            TextBox6.Text = (english5 & "                      " & maths5 & "                       " & PE5 & "                        " & average5)
        Else
            MsgBox("Please click the reset button to reset the marks.")
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        maths = 0
        maths1 = 0
        maths2 = 0
        maths3 = 0
        maths4 = 0
        maths5 = 0
        english = 0
        english1 = 0
        english2 = 0
        english3 = 0
        english4 = 0
        english5 = 0
        PE = 0
        PE1 = 0
        PE2 = 0
        PE3 = 0
        PE4 = 0
        PE5 = 0
        TextBox1.Text = (english & "                       " & maths & "                       " & PE)
        TextBox2.Text = (english1 & "                       " & maths1 & "                       " & PE1)
        TextBox3.Text = (english2 & "                       " & maths2 & "                       " & PE2)
        TextBox4.Text = (english3 & "                       " & maths3 & "                       " & PE3)
        TextBox5.Text = (english4 & "                       " & maths4 & "                       " & PE4)
        TextBox6.Text = (english5 & "                       " & maths5 & "                       " & PE5)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim FileNum As Integer = FreeFile()
        FileOpen(FileNum, "E:\markdata.csv", OpenMode.Output)
        PrintLine(FileNum, "NAME,ENGLISH,MATH,PE,AVERAGE")
        PrintLine(FileNum, "John," & english & "," & maths & "," & PE & "," & average)
        PrintLine(FileNum, "Damein," & english1 & "," & maths1 & "," & PE1 & "," & average1)
        PrintLine(FileNum, "Mark," & english2 & "," & maths2 & "," & PE2 & "," & average2)
        PrintLine(FileNum, "Joshua," & english3 & "," & maths3 & "," & PE3 & "," & averag3)
        PrintLine(FileNum, "Mary," & english4 & "," & maths4 & "," & PE4 & "," & average4)
        PrintLine(FileNum, "Maria," & english5 & "," & maths5 & "," & PE5 & "," & average5)

        FileClose(FileNum)

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim FileNum As Integer = FreeFile()
        Dim TempS As String = ""
        Dim Templ As String
        FileOpen(FileNum, "E:\markdata.csv", OpenMode.Input)
        Do Until EOF(FileNum)
            Templ = LineInput(FileNum)
            TempS += Templ + vbNewLine
        Loop
        FileClose(FileNum)
        Label7.Text = (TempS)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim FileNum As Integer = FreeFile()
        Dim SearchForThis As String = TextBox9.Text
        Dim FoundString As Integer = 0

        FileOpen(FileNum, "E:\markdata.csv", OpenMode.Input)
        Do Until EOF(FileNum)

            Dim SearchWithinThis As String = LineInput(FileNum)
            Dim FirstCharacter As Integer = SearchWithinThis.IndexOf(SearchForThis)
            If FirstCharacter >= 0 Then
                FoundString = 1
                Label9.Text = (SearchWithinThis)
            End If
        Loop
        If FoundString = 0 Then
            MsgBox("Search String " & SearchForThis & " Not Found")
        End If
        FileClose(FileNum)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DataGridView1.AutoGenerateColumns = True
        Dim sw As New Stopwatch
        sw.Start()
        SortCsv("E:\markdata.csv", "E:\markdataResult.csv", New Integer() {4})
        sw.Stop()
        DataGridView1.DataSource = CsvToTable("E:\markdataResult.csv")


    End Sub
    Public Sub SortCsv(ByVal sourceFile As String, ByVal destinationFile As String, ByVal ParamArray sortColumns() As Integer)
        Dim dt As DataTable = CsvToTable(sourceFile)
        If sortColumns.Length > 0 Then
            Dim sortStr As String = String.Empty
            For i As Integer = 0 To sortColumns.Length - 1
                If sortStr.Length > 0 Then sortStr &= ", "
                sortStr &= "Column" & sortColumns(i).ToString
            Next
            dt.DefaultView.Sort = sortStr
        End If
        TableToCSV(dt.DefaultView.ToTable, destinationFile)
    End Sub
    Private Function CsvToTable(ByVal filePathName As String) As DataTable
        Dim result As New DataTable
        If System.IO.File.Exists(filePathName) Then
            Dim parser As New Microsoft.VisualBasic.FileIO.TextFieldParser(filePathName)
            parser.Delimiters = New String() {","}
            parser.HasFieldsEnclosedInQuotes = True
            parser.TextFieldType = FileIO.FieldType.Delimited
            parser.TrimWhiteSpace = True

            While Not parser.EndOfData
                AddValuesToTable(parser.ReadFields, result)
            End While
            parser.Close()
        End If
        Return result
    End Function
    Private Sub TableToCSV(ByVal sourceTable As DataTable, ByVal filePathName As String)
        Dim sb As New System.Text.StringBuilder
        For Each dr As DataRow In sourceTable.Rows
            sb.AppendLine(String.Join(",", Array.ConvertAll(Of Object, String)(dr.ItemArray,
            Function(o As Object) If(o.ToString.Contains(","),
            ControlChars.Quote & o.ToString & ControlChars.Quote, o.ToString))))
        Next
        System.IO.File.WriteAllText(filePathName, sb.ToString)
    End Sub
    Private Sub AddValuesToTable(ByVal source() As String, ByVal destination As DataTable)
        Dim existing As Integer = destination.Columns.Count
        For i As Integer = 0 To source.Length - existing - 1
            destination.Columns.Add("Column" & (existing + 1 + i).ToString, GetType(String))
        Next
        destination.Rows.Add(source)
    End Sub
End Class