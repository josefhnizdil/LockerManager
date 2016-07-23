Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Trida
    Public Sub AktualizaceHodnotMainForm()
        Dim scalarqueryrozbita As String = String.Empty
        Dim scalarqueryrozbitapodminka As Object = MainForm.SatnyTableAdapter.ScalarQueryRozbita
        Dim scalarqueryneopravnena As String = String.Empty
        Dim scalarqueryneopravnenapodminka As Object = MainForm.SatnyTableAdapter.ScalarQueryNeopravnena
        Dim scalarqueryvolnemuzi As String = String.Empty
        Dim scalarqueryvolnemuzipodminka As Object = MainForm.SatnyTableAdapter.ScalarQuery
        Dim scalarqueryvolnezeny As String = String.Empty
        Dim scalarqueryvolnezenypodminka As Object = MainForm.SatnyTableAdapter.ScalarQuery1


        If scalarqueryrozbitapodminka Is Nothing Then
            MainForm.TextBox8.Text = "0"
        Else
            MainForm.TextBox8.Text = MainForm.SatnyTableAdapter.ScalarQueryRozbita
        End If

        If scalarqueryneopravnenapodminka Is Nothing Then
            MainForm.TextBox7.Text = "0"
        Else
            MainForm.TextBox7.Text = MainForm.SatnyTableAdapter.ScalarQueryNeopravnena
        End If

        If scalarqueryvolnemuzipodminka Is Nothing Then
            MainForm.TextBox5.Text = "0"
        Else
            MainForm.TextBox5.Text = MainForm.SatnyTableAdapter.ScalarQuery
        End If

        If scalarqueryvolnezenypodminka Is Nothing Then
            MainForm.TextBox6.Text = "0"
        Else
            MainForm.TextBox6.Text = MainForm.SatnyTableAdapter.ScalarQuery1
        End If



    End Sub
    Public Sub AktualizaceHodnotStatistikaCelkem()
        statistickeudaje.celkovypocetsatny.Text = statistickeudaje.SatnyTableAdapter1.StatistikaCelkovyPocet
        Dim pocetobsazenych As String = String.Empty
        Dim pocetobsazenychpodminka As Object = statistickeudaje.SatnyTableAdapter1.StatistikaCelkovypocetobsazena
        Dim celkovypocetzeny As String = String.Empty
        Dim celkovypocetzenypodminka As Object = statistickeudaje.SatnyTableAdapter1.StatistikaCelkovyPocetZeny
        Dim celkovypocetmuzi As String = String.Empty
        Dim celkovypocetmuzipodminka As Object = statistickeudaje.SatnyTableAdapter1.StatistikaCelkovyPocetMuzi
        Dim celkovypocetneopravnenych As String = String.Empty
        Dim celkovypocetneopravnenychpodminka As Object = statistickeudaje.SatnyTableAdapter1.StatistikaCelkovypocetNeopravnena
        Dim celkovypocetrozbitych As String = String.Empty
        Dim celkovypocetrozbitychpodminka As Object = statistickeudaje.SatnyTableAdapter1.StatistikaCelkovypocetrozbita

        If pocetobsazenychpodminka Is Nothing Then
            statistickeudaje.celkovypocetobsazenych.Text = "0"
        Else
            statistickeudaje.celkovypocetobsazenych.Text = statistickeudaje.SatnyTableAdapter1.StatistikaCelkovypocetobsazena
        End If
        If celkovypocetzenypodminka Is Nothing Then
            statistickeudaje.celkovypocetdamskych.Text = "0"
        Else
            statistickeudaje.celkovypocetdamskych.Text = statistickeudaje.SatnyTableAdapter1.StatistikaCelkovyPocetZeny
        End If

        If celkovypocetmuzipodminka Is Nothing Then
            statistickeudaje.pocetpanskych.Text = "0"
        Else
            statistickeudaje.pocetpanskych.Text = statistickeudaje.SatnyTableAdapter1.StatistikaCelkovyPocetMuzi
        End If
        If celkovypocetneopravnenychpodminka Is Nothing Then
            statistickeudaje.pocetneopravnencyh.Text = "0"
        Else
            statistickeudaje.pocetneopravnencyh.Text = statistickeudaje.SatnyTableAdapter1.StatistikaCelkovypocetNeopravnena
        End If

        If celkovypocetrozbitychpodminka Is Nothing Then
            statistickeudaje.pocetrozbitych.Text = "0"
        Else
            statistickeudaje.pocetrozbitych.Text = statistickeudaje.SatnyTableAdapter1.StatistikaCelkovypocetrozbita
        End If

    End Sub
    Public Sub AktualizaceHodnotSatnaMA()
        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MA_Celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MA_obsazená
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MA_rozbita
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MA_Volné
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MA_neopravnena

        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label79.Text = "0"
        Else
            statistickeudaje.Label79.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MA_Celkem
        End If

        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label81.Text = "0"
        Else
            statistickeudaje.Label81.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MA_obsazená
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label83.Text = "0"
        Else
            statistickeudaje.Label83.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MA_rozbita
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label82.Text = "0"
        Else
            statistickeudaje.Label82.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MA_Volné()

        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label80.Text = "0"
        Else
            statistickeudaje.Label80.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MA_neopravnena
        End If



    End Sub
    Public Sub AktualizaceHodnotSatnaMB()

        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MB_celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MB_Obsazená
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MB_Rozbita
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MB_volné
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MB_Neopravněná

        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label88.Text = "0"
        Else
            statistickeudaje.Label88.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MB_celkem
        End If
        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label86.Text = "0"
        Else
            statistickeudaje.Label86.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MB_Obsazená
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label84.Text = "0"
        Else
            statistickeudaje.Label84.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MB_Rozbita
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label85.Text = "0"
        Else
            statistickeudaje.Label85.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MB_volné

        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label87.Text = "0"
        Else
            statistickeudaje.Label87.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MB_Neopravněná
        End If

    End Sub
    Public Sub AktualizaceHodnotSatnaMC()
        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MC_celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MC_obsazene
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MC_rozbite
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MC_volne
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MC_neopravnene

        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label93.Text = "0"
        Else
            statistickeudaje.Label93.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MC_celkem
        End If
        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label91.Text = "0"
        Else
            statistickeudaje.Label91.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MC_obsazene
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label89.Text = "0"
        Else
            statistickeudaje.Label89.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MC_rozbite
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label90.Text = "0"
        Else
            statistickeudaje.Label90.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MC_volne

        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label92.Text = "0"
        Else
            statistickeudaje.Label92.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MC_neopravnene
        End If

    End Sub
    Public Sub AktualizaceHodnotSatnaMD()
        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MD_Celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MD_Obsazené
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MD_rozbite
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MD_volne
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MD_neopravnene

        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label98.Text = "0"
        Else
            statistickeudaje.Label98.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MD_Celkem
        End If
        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label96.Text = "0"
        Else
            statistickeudaje.Label96.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MD_Obsazené
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label94.Text = "0"
        Else
            statistickeudaje.Label94.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MD_rozbite
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label95.Text = "0"
        Else
            statistickeudaje.Label95.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MD_volne

        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label97.Text = "0"
        Else
            statistickeudaje.Label97.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MD_neopravnene
        End If

    End Sub
    Public Sub AktualizaceHodnotSatnaME()
        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_ME_celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_ME_obsazena
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_ME_tozbita
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_ME_volne
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_ME_neopravnene

        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label103.Text = "0"
        Else
            statistickeudaje.Label103.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_ME_celkem
        End If
        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label101.Text = "0"
        Else
            statistickeudaje.Label101.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_ME_obsazena
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label99.Text = "0"
        Else
            statistickeudaje.Label99.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_ME_tozbita
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label100.Text = "0"
        Else
            statistickeudaje.Label100.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_ME_volne

        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label102.Text = "0"
        Else
            statistickeudaje.Label102.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_ME_neopravnene
        End If

    End Sub
    Public Sub AktualizaceHodnotSatnaMF()
        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MF_celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MF_obsazena
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MF_rozbite
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MF_volne
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Panskesatny_MF_neopravnena

        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label108.Text = "0"
        Else
            statistickeudaje.Label108.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MF_celkem
        End If
        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label106.Text = "0"
        Else
            statistickeudaje.Label106.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MF_obsazena
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label104.Text = "0"
        Else
            statistickeudaje.Label104.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MF_rozbite
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label105.Text = "0"
        Else
            statistickeudaje.Label105.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MF_volne

        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label107.Text = "0"
        Else
            statistickeudaje.Label107.Text = statistickeudaje.SatnyTableAdapter1.Panskesatny_MF_neopravnena
        End If

    End Sub
    Public Sub AktualizaceHodnotSatnaZA()
        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZA_celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZA_obsazene
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZA_rozbite
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZA_volne
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZA_neopravnene

        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label113.Text = "0"
        Else
            statistickeudaje.Label113.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZA_celkem
        End If

        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label111.Text = "0"
        Else
            statistickeudaje.Label111.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZA_obsazene
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label109.Text = "0"
        Else
            statistickeudaje.Label109.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZA_rozbite
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label110.Text = "0"
        Else
            statistickeudaje.Label110.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZA_volne

        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label112.Text = "0"
        Else
            statistickeudaje.Label112.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZA_neopravnene
        End If
    End Sub
    Public Sub AktualizaceHodnotSatnaZB()
        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZB_celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZB_Obsazene
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZB_Rozbite
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZB_Volne
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZB_neopravnene

        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label118.Text = "0"
        Else
            statistickeudaje.Label118.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZB_celkem
        End If

        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label116.Text = "0"
        Else
            statistickeudaje.Label116.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZB_Obsazene
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label114.Text = "0"
        Else
            statistickeudaje.Label114.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZB_Rozbite
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label115.Text = "0"
        Else
            statistickeudaje.Label115.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZB_Volne

        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label117.Text = "0"
        Else
            statistickeudaje.Label117.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZB_neopravnene
        End If
    End Sub
    Public Sub AktualizaceHodnotSatnaZC()
        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZC_celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZC_Obsazene
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZC_Rozbite
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZC_Volne
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZC_neopravnene

        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label123.Text = "0"
        Else
            statistickeudaje.Label123.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZC_celkem
        End If

        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label121.Text = "0"
        Else
            statistickeudaje.Label121.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZC_Obsazene
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label119.Text = "0"
        Else
            statistickeudaje.Label119.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZC_Rozbite
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label120.Text = "0"
        Else
            statistickeudaje.Label120.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZC_Volne

        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label122.Text = "0"
        Else
            statistickeudaje.Label122.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZC_neopravnene
        End If
    End Sub
    Public Sub AktualizaceHodnotSatnaZD()
        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZD_celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZD_obsazene
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZD_rozbite
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZD_volne
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZD_neopravnene

        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label128.Text = "0"
        Else
            statistickeudaje.Label128.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZD_celkem
        End If

        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label126.Text = "0"
        Else
            statistickeudaje.Label126.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZD_obsazene
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label124.Text = "0"
        Else
            statistickeudaje.Label124.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZD_rozbite
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label125.Text = "0"
        Else
            statistickeudaje.Label125.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZD_volne

        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label127.Text = "0"
        Else
            statistickeudaje.Label127.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZD_neopravnene
        End If
    End Sub
    Public Sub AktualizaceHodnotSatnaZE()
        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZE_celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZE_obsazene
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZE_rozbite
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZE_volne
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZE_neopravnene

        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label133.Text = "0"
        Else
            statistickeudaje.Label133.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZE_celkem
        End If

        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label131.Text = "0"
        Else
            statistickeudaje.Label131.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZE_obsazene
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label129.Text = "0"
        Else
            statistickeudaje.Label129.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZE_rozbite
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label130.Text = "0"
        Else
            statistickeudaje.Label130.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZE_volne

        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label132.Text = "0"
        Else
            statistickeudaje.Label132.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZE_neopravnene
        End If
    End Sub
    Public Sub AktualizaceHodnotSatnaZF()
        Dim celkovypocet As String = String.Empty
        Dim celkovypocetpodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZF_celkem
        Dim obsazena As String = String.Empty
        Dim obsazenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZF_obsazene
        Dim rozbita As String = String.Empty
        Dim rozbitapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZF_rozbite
        Dim volna As String = String.Empty
        Dim volnapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZF_volne
        Dim neopravnena As String = String.Empty
        Dim neopravnenapodminka As Object = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZF_neopravnene
        If celkovypocetpodminka Is Nothing Then
            statistickeudaje.Label138.Text = "0"
        Else
            statistickeudaje.Label138.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZF_celkem
        End If
        If obsazenapodminka Is Nothing Then
            statistickeudaje.Label136.Text = "0"
        Else
            statistickeudaje.Label136.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZF_obsazene
        End If
        If rozbitapodminka Is Nothing Then
            statistickeudaje.Label134.Text = "0"
        Else
            statistickeudaje.Label134.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZF_rozbite
        End If
        If volnapodminka Is Nothing Then
            statistickeudaje.Label135.Text = "0"
        Else
            statistickeudaje.Label135.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZF_volne
        End If
        If neopravnenapodminka Is Nothing Then
            statistickeudaje.Label137.Text = "0"
        Else
            statistickeudaje.Label137.Text = statistickeudaje.SatnyTableAdapter1.Damskesatny_ZF_neopravnene
        End If
    End Sub
    Public Sub registracesatenstart()

        pridatsatny.ComboBox1.Enabled = False
        pridatsatny.CheckBox1.Enabled = False
        pridatsatny.CheckBox2.Enabled = False
        pridatsatny.TextBox1.Enabled = False
        pridatsatny.TextBox2.Enabled = False
        pridatsatny.TextBox3.Enabled = False
        pridatsatny.Button1.Enabled = False
        pridatsatny.Button2.Enabled = False

    End Sub
    Public Sub registracesatenkonec()

        pridatsatny.ComboBox1.Enabled = True
        pridatsatny.CheckBox1.Enabled = True
        pridatsatny.CheckBox2.Enabled = True
        pridatsatny.TextBox1.Enabled = False
        pridatsatny.TextBox2.Enabled = True
        pridatsatny.TextBox3.Enabled = True
        pridatsatny.Button1.Enabled = False
        pridatsatny.Button2.Enabled = True
        pridatsatny.CheckBox2.Checked = False
    End Sub
    Public Sub registracesatendamske()

        pridatsatny.CheckBox3.Enabled = False
        pridatsatny.CheckBox4.Enabled = False
        pridatsatny.ComboBox2.Enabled = False
        pridatsatny.Button3.Enabled = False
        pridatsatny.Button4.Enabled = False
        pridatsatny.TextBox4.Enabled = False
        pridatsatny.TextBox5.Enabled = False
        pridatsatny.TextBox6.Enabled = False


    End Sub
    Public Sub registracesatendamskekonec()
        pridatsatny.CheckBox3.Enabled = True
        pridatsatny.CheckBox4.Enabled = True
        pridatsatny.ComboBox2.Enabled = True
        pridatsatny.CheckBox3.Checked = False

        pridatsatny.TextBox4.Enabled = False
        pridatsatny.TextBox4.Text = Nothing
        pridatsatny.TextBox5.Text = Nothing
        pridatsatny.TextBox6.Text = Nothing
        pridatsatny.TextBox5.Enabled = False
        pridatsatny.TextBox6.Enabled = False
    End Sub
End Class
