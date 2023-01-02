Public Class Accueil

    Private Sub ButQuitter_Click(sender As Object, e As EventArgs) Handles ButQuitter.Click
        Dim reponse As String = MsgBox("Voulez-vous vraiment quitter ?", vbYesNo)
        If reponse = vbYes Then
            If Not mainModule.JoueursVide() Then
                mainModule.enregistrerPersonnes()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub ButValider_Click(sender As Object, e As EventArgs) Handles ButValider.Click
        LabCommencer.Visible = False
        LabAjoute.Visible = False
        If CmbNoms.Text.Length >= 3 Then
            LabNoms.Visible = False
            If Not mainModule.ExistePersonne(CmbNoms.Text) Then
                mainModule.AjouterPersonne(CmbNoms.Text, 0, 0, 0, 0, 0) 'Ajoute une toute nouvelle personne à la liste de personnes
            End If
        Else
                LabNoms.Visible = True
        End If
    End Sub

    Private Sub ButCommencer_Click(sender As Object, e As EventArgs) Handles ButCommencer.Click
        'Commence la partie en plus de faire ce que fait le bouton valider, ce qui sert donc de raccourci
        LabNoms.Visible = False
        LabAjoute.Visible = False
        If CmbNoms.Text.Length >= 3 Then
            LabNoms.Visible = False
            If Not mainModule.ExistePersonne(CmbNoms.Text) Then
                mainModule.AjouterPersonne(CmbNoms.Text, 0, 0, 0, 0, 0)
                CmbNoms.Items.Add(CmbNoms.Text)
            End If
            LabCommencer.Visible = False
            Me.Hide()
            mainModule.Commencer()
            Difficulte.Show()
        Else
            LabCommencer.Visible = True
        End If
    End Sub

    Private Sub ButScores_Click(sender As Object, e As EventArgs) Handles ButScores.Click
        Me.Hide()
        Scores.Show()
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PctSmiley.Image = New Bitmap(My.Resources.Smiley, New Size(PctSmiley.Size))
        PctTitre.Image = New Bitmap(My.Resources.Titre, New Size(PctTitre.Size))
        PanTitre.BackgroundImage = New Bitmap(My.Resources.Fond, New Size(PanTitre.Size))
        TxtFichier.Text = "fichier.txt"
        mainModule.SetFichier(TxtFichier.Text)
        mainModule.ActualiserPersonnes()
        mainModule.SetCouleur(Color.Silver)
        mainModule.AjouterPersonnes()
    End Sub

    Private Sub ButFichier_Click(sender As Object, e As EventArgs) Handles ButFichier.Click
        'Permet à l'utilisateur de sélectionner un fichier parmi ceux présents sur son ordinateur
        Dim selection As New OpenFileDialog()
        Dim courant As String = mainModule.GetFichier()
        selection.InitialDirectory = "C:\"
        selection.Multiselect = False
        selection.Filter = "Text Files|*.txt"
        If selection.ShowDialog = DialogResult.OK Then
            TxtFichier.Text = selection.FileName
        End If
        If courant <> TxtFichier.Text Then
            mainModule.SetFichier(TxtFichier.Text)
            mainModule.ActualiserPersonnes()
            mainModule.AjouterPersonnes()
        End If
    End Sub

    Private Sub CmbTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTheme.SelectedIndexChanged
        Select Case CmbTheme.Text
            Case "Classique"
                mainModule.SetCouleur(Color.Silver)
            Case "Clair"
                mainModule.SetCouleur(Color.Snow)
            Case "Sombre"
                mainModule.SetCouleur(Color.DimGray)
            Case "Bleu"
                mainModule.SetCouleur(Color.LightSkyBlue)
            Case "Vert"
                mainModule.SetCouleur(Color.PaleGreen)
            Case "Jaune"
                mainModule.SetCouleur(Color.PaleGoldenrod)
        End Select
        TxtTheme.BackColor = mainModule.GetCouleur()
    End Sub

End Class
