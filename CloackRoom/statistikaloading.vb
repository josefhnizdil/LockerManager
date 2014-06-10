Imports System.Windows.Forms


Public Class statistikaloading
    Dim aktualizace As New Trida

    Private Sub statistikaloading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Label1.Text = ""
        Label2.Text = ProgressBar1.Value & (" %")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label2.Text = ProgressBar1.Value & (" %")
        If ProgressBar1.Value = 1 Then
            Label1.Text = "Načítám celkové statistiky"
            aktualizace.AktualizaceHodnotStatistikaCelkem()
        End If
        If ProgressBar1.Value = 6 Then
            Label1.Text = "Načítám MA"
            aktualizace.AktualizaceHodnotSatnaMA()
        End If
        If ProgressBar1.Value = 15 Then
            Label1.Text = "Načítám MB"
            aktualizace.AktualizaceHodnotSatnaMB()
        End If
        If ProgressBar1.Value = 24 Then
            Label1.Text = "Načítám MC"
            aktualizace.AktualizaceHodnotSatnaMC()
        End If
        If ProgressBar1.Value = 30 Then
            Label1.Text = "Načítám MD"
            aktualizace.AktualizaceHodnotSatnaMD()
        End If
        If ProgressBar1.Value = 35 Then
            Label1.Text = "Načítám ME"
            aktualizace.AktualizaceHodnotSatnaME()
        End If
        If ProgressBar1.Value = 40 Then
            Label1.Text = "Načítám MF"
            aktualizace.AktualizaceHodnotSatnaMF()

        End If
        If ProgressBar1.Value = 50 Then
            Label1.Text = "Načítám ZA"
            aktualizace.AktualizaceHodnotSatnaZA()
        End If
        If ProgressBar1.Value = 58 Then
            Label1.Text = "Načítám ZB"
            aktualizace.AktualizaceHodnotSatnaZB()
        End If
        If ProgressBar1.Value = 69 Then
            Label1.Text = "Načítám ZC"
            aktualizace.AktualizaceHodnotSatnaZC()
        End If
        If ProgressBar1.Value = 76 Then
            Label1.Text = "Načítám ZD"
            aktualizace.AktualizaceHodnotSatnaZD()
        End If
        If ProgressBar1.Value = 85 Then
            Label1.Text = "Načítám ZE"
            aktualizace.AktualizaceHodnotSatnaZE()
        End If
        If ProgressBar1.Value = 92 Then
            Label1.Text = "Načítám ZF"
            aktualizace.AktualizaceHodnotSatnaZF()
            Label1.Text = "Hotovo - spouštím statistiku"
        End If

        If ProgressBar1.Value = 100 Then
            statistickeudaje.Show()
            Me.Close()
        End If
      
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
