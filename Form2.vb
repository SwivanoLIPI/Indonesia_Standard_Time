Imports System.Threading

Public Class Form2
    Dim a As New Process



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim process As New Process()
        process.StartInfo.FileName = "cmd.exe"
        process.Start()
        Thread.Sleep(200)
        SendKeys.Send("net start w32time")
        SendKeys.Send("{enter}")

        SendKeys.Send("w32tm /config /manualpeerlist:203.160.128.66 /syncfromflags:manual /reliable:yes /update")
        Thread.Sleep(200)
        SendKeys.Send("{enter}")
        Thread.Sleep(200)
        SendKeys.SendWait("exit")

        Thread.Sleep(200)
        MsgBox("Program ini telah mensinkronisasikan jam anda secara otomatis. Jika terdapat error silahkan pilih Sinkronisasi Manual.Tekan tombol Enter untuk melanjutkan")






    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Close()


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim b As New Process
        a.StartInfo.FileName = "cmd.exe"
        a.Start()
        Thread.Sleep(200)
        SendKeys.Send("regsvr32 quartz.dll")
        Thread.Sleep(200)
        SendKeys.Send("{enter}")
        Thread.Sleep(200)
        SendKeys.Send("exit")
        SendKeys.Send("{enter}")
        Thread.Sleep(200)
        SendKeys.Send("exit")
        SendKeys.Send("{enter}")

        MsgBox("Sistem waktu anda telah siap untuk disinkronisasi. Jika terdapat error silahkan pilih Sinkronisasi Manual.Tekan tombol Enter untuk melanjutkan")


    End Sub



End Class