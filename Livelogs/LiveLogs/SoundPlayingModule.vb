Imports System.Threading

Module SoundPlayerModule

    Private WithEvents player As System.Media.SoundPlayer
    Private cancellationTokenSource As CancellationTokenSource

    ' Function to play a WAV file from resources asynchronously
    Public Async Function PlaySoundFromResourcesAsync(resourceName As String) As Task
        cancellationTokenSource = New CancellationTokenSource()

        Try
            ' Load the sound from resources
            player = New System.Media.SoundPlayer(My.Resources.ResourceManager.GetStream(resourceName))

            ' Play the sound asynchronously
            Await Task.Run(Sub()
                               player.PlaySync()
                           End Sub, cancellationTokenSource.Token)
        Catch ex As Exception
            ' Handle any exceptions
            Console.WriteLine("Error playing sound: " & ex.Message)
        End Try
    End Function

    ' Function to stop any currently playing sound
    Public Sub StopSound()
        If player IsNot Nothing Then
            player.Stop()
        End If
        If cancellationTokenSource IsNot Nothing Then
            cancellationTokenSource.Cancel()
        End If
    End Sub

End Module