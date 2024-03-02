' This module code will save program settings on your own key under "CurrentUser\Software\[CompanyName]\[ApplicationName]"
' The code should work in a similar way the VB build-in savesetting, getseeting and deletesetting commands do  
' taken from https://github.com/limbo666/RegSettings_for_VB.NET
' Example usage
' Set your CompanyName and ApplicationName name on the variables 

'SAVING
'RegSaveSetting("Settings", "Top", Me.Top)
'RegSaveSetting("Settings", "Left", Me.Left)
'RegSaveSetting("Settings", "Checkbox1", CheckBox1.Checked)
'RegSaveSetting("Settings", "Textbox1", TextBox1.Text)
'RegSaveSetting("Settings", "Numeric1", NumericUpDown1.Value)

'READING
'Me.Top = RegGetSetting("Settings", "Top", 200)
'Me.Left = RegGetSetting("Settings", "Left", 200)
'CheckBox1.Checked = RegGetSetting("Settings", "Checkbox1", True)
'TextBox1.Text = RegGetSetting("Settings", "Textbox1", "Hello World")
'NumericUpDown1.Value = RegGetSetting("Settings", "Numeric1", 19)

'DELETING
'RegDeleteSetting("Settings", "Top")  ' Deletes "Top" key if exist 

'DELETING ALL KEYS (CLEAR PROGRAM NAME) 
'RegDeleteAllSettings() ' Deletes all settings under program name 


Imports Microsoft.Win32

Module ModRegSettings

    Dim CompanyName As String = "Hand Water Pump"
    Dim ApplicationName As String = "LiveLogs"

    Public Sub RegSaveSetting(Section As String, Key As String, Value As String)
        Dim keyValue As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\" & CompanyName & "\" & ApplicationName & "\" & Section)
        keyValue.SetValue(Key, Value)
        keyValue.Close()
    End Sub

    Public Function RegGetSetting(Section As String, Key As String, DefaultValue As Object) As Object
        Dim keyValue As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\" & CompanyName & "\" & ApplicationName & "\" & Section)

        Dim expectedType As String = DefaultValue.GetType().Name
        If keyValue IsNot Nothing Then
            Dim value As Object = keyValue.GetValue(Key)
            If value IsNot Nothing Then
                Select Case expectedType
                    Case "Int32"
                        RegGetSetting = Convert.ToInt32(value)
                    Case "Int64"
                        RegGetSetting = Convert.ToInt64(value)
                    Case "Boolean"
                        RegGetSetting = Convert.ToBoolean(value)
                    Case "String"
                        RegGetSetting = Convert.ToString(value)
                    Case Else
                        RegGetSetting = Convert.ToString(value)
                End Select
            Else
                RegGetSetting = DefaultValue
            End If
            keyValue.Close()
        Else
            RegGetSetting = DefaultValue
        End If
    End Function


    Public Sub RegDeleteSetting(Section As String, Key As String)

        Dim dKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\" & CompanyName & "\" & ApplicationName & "\" & Section, True)
        If Key IsNot Nothing And dKey IsNot Nothing Then
            Try
                dKey.DeleteValue(Key)
                dKey.Close()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Public Sub RegDeleteAllSettings()
        Dim dKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\" & CompanyName, True)
        If dKey IsNot Nothing Then
            Try
                dKey.DeleteSubKeyTree(ApplicationName)
                dKey.Close()
            Catch ex As Exception

            End Try

        End If
    End Sub



End Module
