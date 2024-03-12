Module ModPublicValues
    Public Keyword1 As String = "Info"
    Public Keyword2 As String = "Warning"
    Public Keyword3 As String = "Error"
    Public Keyword4 As String = "Critical"
    Public Keyword5 As String = "Fatal"
    Public Keyword6 As String = "Boo"


    Public PopUpKeyword As String = "Odd"
    Public SoundKeyword As String = "Strange"
    Public LaunchKeyword As String = "Bizzare"
    Public LaunchPath As String = "C:\Windows\System32\Calc.exe"

    Public EasterEggsRevealed As Boolean = False


    Public TempLineContents As String = ""

    Public Sub ExecuteExternalProgram(ByVal filePath As String)
        Try
            ' Create a new process
            Dim process As New Process()

            ' Specify the file path of the executable
            process.StartInfo.FileName = filePath

            ' Start the process without waiting for it to exit
            process.Start()
        Catch ex As Exception
            ' Handle any errors that occur during execution
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

End Module
