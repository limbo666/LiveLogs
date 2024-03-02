Imports System.IO
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class form1
    ' Variables for log file reading
    Private logFilePath As String
    Private logReaderThread As Thread
    Private isReading As Boolean = False
    Private totalLinesRead As Integer = 0

    ' Variables for text search
    Private searchText As String
    Private searchStartIndex As Integer
    Private instancesCount As Integer
    Private currentIndex As Integer
    Private isFinding As Boolean = False

    ' Flag to control search functionality
    Dim FindEnabled = False


    Sub LoadMySettings()
        'READING
        Me.Top = RegGetSetting("Settings", "Top", 200)
        Me.Left = RegGetSetting("Settings", "Left", 200)
        CheckBox1.Checked = RegGetSetting("Settings", "Checkbox1", True)
        TextBox1.Text = RegGetSetting("Settings", "Textbox1", "C:\ALogfile.log")
        TextBox2.Text = RegGetSetting("Settings", "Textbox2", "Search term")
        Me.Width = RegGetSetting("Settings", "Width", 688)
        Me.Height = RegGetSetting("Settings", "Height", 707)
    End Sub

    Sub SaveMySettings()
        'SAVING
        RegSaveSetting("Settings", "Top", Me.Top)
        RegSaveSetting("Settings", "Left", Me.Left)
        RegSaveSetting("Settings", "Checkbox1", CheckBox1.Checked)
        RegSaveSetting("Settings", "Textbox1", TextBox1.Text)
        RegSaveSetting("Settings", "Textbox2", TextBox2.Text)
        RegSaveSetting("Settings", "Width", Me.Width)
        RegSaveSetting("Settings", "Height", Me.Height)

    End Sub


    ' Form load event handler
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMySettings()
        ' Default log file path
        '  logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "myrandomlog.log")
        '  TextBox1.Text = logFilePath
        logFilePath = TextBox1.Text
        ' Initialize log reader thread
        logReaderThread = New Thread(AddressOf ReadLogFile)
        logReaderThread.IsBackground = True
    End Sub

    ' Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Set KeyPreview property to True to handle key events
        Me.KeyPreview = True
    End Sub

    ' Handle Ctrl+F key press event
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.F Then
            ' Call FindToolStripMenuItem_Click to toggle search functionality
            Call FindToolStripMenuItem_Click(Nothing, Nothing)
            ' Prevent further processing of the key event
            e.Handled = True
        End If
    End Sub

    ' Start/Stop log reading button click event handler
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If isReading Then
            ' Stop reading
            isReading = False
            Button1.Text = "Start Reading"
        Else
            ' Start reading
            isReading = True
            Button1.Text = "Stop Reading"
            ' Create a new thread for log file reading
            logReaderThread = New Thread(AddressOf ReadLogFile)
            logReaderThread.IsBackground = True
            If CheckBox1.Checked Then
                ' Scroll to the end if autoscroll is enabled
                RichTextBox1.SelectionStart = RichTextBox1.TextLength
                RichTextBox1.ScrollToCaret()
            End If
            ' Start the log reader thread
            logReaderThread.Start()
        End If
    End Sub

    ' Read log file method
    Private Sub ReadLogFile()
        Try
            Using fileStream As New FileStream(logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Using streamReader As New StreamReader(fileStream)
                    While isReading
                        Dim line As String = streamReader.ReadLine()
                        If line IsNot Nothing Then
                            ' Update UI with the read line
                            Invoke(Sub()
                                       RichTextBox1.AppendText(line & vbCrLf)
                                       If CheckBox1.Checked Then
                                           ' Scroll to the end if autoscroll is enabled
                                           RichTextBox1.SelectionStart = RichTextBox1.TextLength
                                           RichTextBox1.ScrollToCaret()
                                       End If
                                   End Sub)
                            totalLinesRead += 1
                            ' Update total lines label
                            Invoke(Sub() Label1.Text = "Total Lines Read: " & totalLinesRead)
                        Else
                            ' Sleep to avoid high CPU usage when the file hasn't changed
                            Thread.Sleep(100)
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            ' Show error message if log file reading fails
            MessageBox.Show("Error reading log file: " & ex.Message)
        End Try
    End Sub

    ' Form closing event handler
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if the log reader thread is running before attempting to join it
        If logReaderThread IsNot Nothing AndAlso logReaderThread.IsAlive Then
            ' Make sure to stop the log reader thread when closing the form
            isReading = False
            logReaderThread.Join()
        End If
        SaveMySettings()

    End Sub

    ' Autoscroll checkbox change event handler
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' Enable autoscrolling if checked
        If CheckBox1.Checked Then
            RichTextBox1.SelectionStart = RichTextBox1.TextLength
            RichTextBox1.ScrollToCaret()
        End If
    End Sub

    ' Resize event handler
    Private Sub form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If CheckBox1.Checked Then
            ' Scroll to the end if autoscroll is enabled
            RichTextBox1.SelectionStart = RichTextBox1.TextLength
            RichTextBox1.ScrollToCaret()
        End If
    End Sub

    ' Start/Stop search button click event handler
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Get the search text from TextBox2
        searchText = TextBox2.Text.Trim()
        If String.IsNullOrWhiteSpace(searchText) Then
            MessageBox.Show("Please enter text to search.")
            Return
        End If

        ' If not already finding, perform initial search
        If Not isFinding Then
            ' Clear any previous highlighting
            ClearHighlight()
            ' Perform the initial search and update the label with the total number of instances found
            PerformInitialSearch()
            isFinding = True
        Else
            ' Find the next occurrence and navigate to it
            FindNextOccurrence()
        End If
    End Sub

    ' Perform initial search method
    Private Sub PerformInitialSearch()
        ' Reset search parameters for a new search
        searchStartIndex = 0
        instancesCount = 0
        currentIndex = 0
        ' Find all occurrences and highlight them
        Dim index As Integer = RichTextBox1.Find(searchText, searchStartIndex, RichTextBoxFinds.None)
        While index <> -1
            ' Highlight the found occurrence
            RichTextBox1.Select(index, searchText.Length)
            RichTextBox1.SelectionBackColor = Color.Yellow ' Set the background color
            instancesCount += 1 ' Increment instances count
            index = RichTextBox1.Find(searchText, index + searchText.Length, RichTextBoxFinds.None)
        End While

        If instancesCount > 0 Then
            ' Update label with the total number of instances found
            Label5.Text = "Instances Found: " & instancesCount.ToString()
            ' Set the currentIndex to 1 to indicate the first occurrence
            Label5.Visible = True
            currentIndex = 1
            ' Position cursor at the start of the first match
            RichTextBox1.Select(searchStartIndex, 0)
            FindEnabled = True
            isFinding = True
            ' Automatically find next occurrence
            Button2_Click(Nothing, Nothing)
        Else
            ' Show message if no instances found
            MessageBox.Show("No instances found.")
            ' Ensure label is updated even if no instances found
            Label5.Text = "Instances Found: 0"
            ' Reset search criteria
            ResetSearchCriteria()
        End If
        ' Set the flag to indicate subsequent clicks
        FindEnabled = True
    End Sub

    ' Find next occurrence method
    Private Sub FindNextOccurrence()
        Dim index As Integer = RichTextBox1.Find(searchText, RichTextBox1.SelectionStart + RichTextBox1.SelectionLength, RichTextBoxFinds.None)
        If index <> -1 Then
            RichTextBox1.Select(index, searchText.Length)
            RichTextBox1.ScrollToCaret()
            currentIndex += 1
        Else
            ' Show message if no more occurrences found
            MessageBox.Show("No more occurrences found.")
            currentIndex = 0
            isFinding = False
        End If
    End Sub

    ' Clear highlighting method
    Private Sub ClearHighlight()
        Dim selectionStart As Integer = RichTextBox1.SelectionStart
        Dim selectionLength As Integer = RichTextBox1.SelectionLength

        RichTextBox1.SelectAll()
        RichTextBox1.SelectionBackColor = RichTextBox1.BackColor

        RichTextBox1.Select(selectionStart, selectionLength)
        RichTextBox1.SelectionLength = 0
    End Sub

    ' Reset search criteria method
    Private Sub ResetSearchCriteria()
        ' Reset search criteria
        searchStartIndex = 0
        instancesCount = 0
        currentIndex = 0
        isFinding = False

        ' Clear any previous highlighting
        ClearHighlight()

        ' Reset label
        Label5.Text = "Total Instances Found: 0"
    End Sub

    ' Exit menu item click event handler
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Select log file menu item click event handler
    Private Sub SelectLogFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectLogFileToolStripMenuItem.Click
        ' Allow user to select a log file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Log Files (*.log;*.txt)|*.log;*.txt|All Files (*.*)|*.*"
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        openFileDialog.Multiselect = False
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            logFilePath = openFileDialog.FileName
            TextBox1.Text = logFilePath
        End If
    End Sub

    ' Find menu item click event handler
    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        ' Toggle search functionality
        FindEnabled = Not FindEnabled
        FindToolStripMenuItem.Checked = FindEnabled
        If FindEnabled = True Then
            ' Show search TextBox and button
            TextBox2.Visible = True
            Button2.Visible = True
            '  Label5.Visible = True
            TextBox2.Focus()
        Else
            ' Hide search TextBox and button
            TextBox2.Visible = False
            Button2.Visible = False
            Label5.Visible = False
            ' Clear any previous highlighting
            ClearHighlight()
        End If
    End Sub

    ' Text changed event handler for TextBox1 (log file path)
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Check if the entered file exists
        If File.Exists(TextBox1.Text) Then
            Label3.Visible = False
            logFilePath = TextBox1.Text
        Else
            Label3.Visible = True
        End If
    End Sub

    ' Key press event handler for TextBox2 (search text)
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Check if the Enter key is pressed
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Perform the action associated with Button2 (search)
            Button2.PerformClick()
            ' Suppress the key press to prevent it from being entered into the TextBox
            e.Handled = True
        End If
    End Sub

    ' Selection changed event handler for RichTextBox1
    Private Sub RichTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles RichTextBox1.SelectionChanged
        ' Get the current line number
        Dim lineNumber As Integer = RichTextBox1.GetLineFromCharIndex(RichTextBox1.SelectionStart) + 1
        ' Display the line number on Label4
        Label4.Text = "Current line: " & lineNumber.ToString()
    End Sub

    ' Text changed event handler for TextBox2 (search text)
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ResetSearchCriteria()
        FindEnabled = False
        isFinding = False
        ' Clear any previous highlighting
        ClearHighlight()
        ' Hide instances count label
        Label5.Visible = False
    End Sub

    Private Sub form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.ShowDialog()
    End Sub
End Class
