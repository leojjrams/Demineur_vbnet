Public Class Difficulte

    Private Sub Difficulte_Load(sender As Object, e As EventArgs) Handles Me.Load
        PanSaisies.Visible = False
        LabSaisies.Visible = False
        LabTaille.Visible = False
        LabMines.Visible = False
        LabTemps.Visible = False
        Me.Size = mainModule.GetDifficulteSize()
    End Sub

    Private Sub ButFacile_Click(sender As Object, e As EventArgs) Handles ButFacile.Click
        mainModule.SetTaille(8)
        mainModule.SetMines(10)
        mainModule.SetTemps(60)
        Me.Close()
        Jeu.Show()
    End Sub

    Private Sub ButNormal_Click(sender As Object, e As EventArgs) Handles ButNormal.Click
        mainModule.SetTaille(16)
        mainModule.SetMines(40)
        mainModule.SetTemps(300)
        Me.Close()
        Jeu.Show()
    End Sub

    Private Sub ButDifficile_Click(sender As Object, e As EventArgs) Handles ButDifficile.Click
        mainModule.SetTaille(24)
        mainModule.SetMines(99)
        mainModule.SetTemps(500)
        Me.Close()
        Jeu.Show()
    End Sub

    Private Sub ButPersonnalise_Click(sender As Object, e As EventArgs) Handles ButPersonnalise.Click
        If PanSaisies.Visible = False Then
            PanSaisies.Visible = True
            Me.Size = mainModule.GetExtendedDifficulteSize() 'Etend la taille du formulaire pour afficher les barres de saisie
        Else
            PanSaisies.Visible = False
            LabSaisies.Visible = False
            LabTaille.Visible = False
            LabMines.Visible = False
            LabTemps.Visible = False
            Me.Size = mainModule.GetDifficulteSize() 'Rétrécit la taille du formulaire pour cacher les barres de saisie
        End If
    End Sub

    Private Sub ButValider_Click(sender As Object, e As EventArgs) Handles ButValider.Click
        'Vérifie toutes les conditions préétablies avant de pouvoir commencer la partie avec les paramètres saisis
        If TxtSaisieTaille.Text = "" Or TxtSaisieMines.Text = "" OrElse TxtSaisieTemps.Text = "" Then
            LabSaisies.Visible = True
        Else
            LabSaisies.Visible = False
            Dim taille As Integer = Integer.Parse(TxtSaisieTaille.Text)
            Dim mines As Integer = Integer.Parse(TxtSaisieMines.Text)
            Dim temps As Integer = Integer.Parse(TxtSaisieTemps.Text)
            If mines > (taille * taille * 0.5) Then 'Pas plus de 50% de mines
                LabNbMines.Visible = True
            Else
                LabNbMines.Visible = False
                If taille < 9 Or taille > 24 OrElse mines < 10 OrElse mines > 99 OrElse temps < 60 OrElse temps > 500 Then
                    LabTaille.Visible = True
                    LabMines.Visible = True
                    LabTemps.Visible = True
                Else
                    LabTaille.Visible = False
                    LabMines.Visible = False
                    LabTemps.Visible = False
                End If
                If LabTaille.Visible = False And LabMines.Visible = False And LabTemps.Visible = False Then
                    Me.Close()
                    mainModule.SetTaille(taille)
                    mainModule.SetMines(mines)
                    mainModule.SetTemps(temps)
                    Jeu.Show()
                End If
            End If
        End If
    End Sub

    Private Sub TxtSaisieTaille_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSaisieTaille.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtSaisieMines_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSaisieMines.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

End Class