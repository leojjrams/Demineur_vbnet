Public Class Scores

    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainModule.AjouterPersonnes()
        CmbNoms.BackColor = Color.White
        ButInverser.BackgroundImage = New Bitmap(My.Resources.Inverser, New Size(ButInverser.Size))
        ButSuppr.BackgroundImage = New Bitmap(My.Resources.Poubelle, New Size(ButSuppr.Size))
    End Sub

    Private Sub ButRetour_Click(sender As Object, e As EventArgs) Handles ButRetour.Click
        Me.Close()
        Accueil.Show()
    End Sub

    Private Sub LstNoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstNoms.SelectedIndexChanged, LstRecord.SelectedIndexChanged, LstTemps.SelectedIndexChanged
        'Permet la synchronisation des listbox
        Dim pos As Integer = sender.SelectedIndex
        LstNoms.SelectedIndex = pos
        LstRecord.SelectedIndex = pos
        LstTemps.SelectedIndex = pos

        Dim top As Integer = sender.TopIndex
        LstNoms.TopIndex = pos
        LstRecord.TopIndex = pos
        LstTemps.TopIndex = pos

        CmbNoms.SelectedItem = LstNoms.SelectedItem
    End Sub

    Private Sub ButInverser_Click(sender As Object, e As EventArgs) Handles ButInverser.Click
        'Inverse l'ordre de classement des joueurs dans les ListBox
        Dim noms() As String = LstNoms.Items.Cast(Of String).Reverse.ToArray
        LstNoms.Items.Clear()
        LstNoms.Items.AddRange(noms)
        Dim records() As Integer = LstRecord.Items.Cast(Of Integer).Reverse.ToArray
        LstRecord.Items.Clear()
        For Each r As Integer In records
            LstRecord.Items.Add(r)
        Next
        Dim temps() As Integer = LstTemps.Items.Cast(Of Integer).Reverse.ToArray
        LstTemps.Items.Clear()
        For Each t As Integer In temps
            LstTemps.Items.Add(t)
        Next
    End Sub

    Private Sub CmbNoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNoms.SelectedIndexChanged
        LstNoms.SelectedItem = CmbNoms.SelectedItem
        CmbNoms.BackColor = Color.White
    End Sub

    Private Sub ButDetails_Click(sender As Object, e As EventArgs) Handles ButDetails.Click
        If CmbNoms.Text <> "" Then
            CmbNoms.BackColor = Color.White
            mainModule.AfficherPersonne(CmbNoms.Text)
        Else
            CmbNoms.BackColor = Color.Red
        End If
    End Sub

    Private Sub CmbNoms_Click(sender As Object, e As EventArgs) Handles CmbNoms.Click
        CmbNoms.BackColor = Color.White
    End Sub

    Private Sub ButSuppr_Click(sender As Object, e As EventArgs) Handles ButSuppr.Click
        'Supprime les données de tous les joueurs dans le fichier et l'application
        If mainModule.JoueursVide() Then
            MsgBox("Aucune donnée à supprimer")
        Else
            Dim reponse As String = MsgBox("Voulez-vous vraiment supprimer les données de tous les joueurs ?", vbYesNo)
            If reponse = vbYes Then
                mainModule.SupprimerPersonnes()
            End If
        End If
    End Sub

End Class