Imports System.Threading
Public Class Form4
    Dim a As New Process
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a.StartInfo.FileName = "cmd.exe"
        a.Start()
        Thread.Sleep(200)
        SendKeys.Send("{enter}")
        SendKeys.Send("timedate.cpl")
        Thread.Sleep(200)
        SendKeys.Send("{enter}")
        Thread.Sleep(200)
        SendKeys.Send("exit")
        SendKeys.Send("{enter}")
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Close()

    End Sub

End Class