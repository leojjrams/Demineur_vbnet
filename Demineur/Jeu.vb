Public Class Jeu

    Dim commence As Boolean
    Dim temps As Integer
    Dim pause As Boolean
    Dim minesRestantes As Integer

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = mainModule.GetCouleur()
        ButAbandonner.Text = "Abandonner"
        pause = True
        Timer.Enabled = True
        LabJoueur.Text = Accueil.CmbNoms.Text
        minesRestantes = mainModule.GetMines()
        LabNbMines.Text = minesRestantes
        commence = False
        Dim tailleMap As Integer = mainModule.GetTaille()
        temps = mainModule.GetTemps()
        LabTemps.Text = temps
        ButPause.Image = New Bitmap(My.Resources.Play, New Size(ButPause.Size))
        Dim tailleCarreau As Integer = Map.Width / tailleMap 'adapte la taille des carreaux au nombre de carreaux sur la map
        If Map.Width Mod tailleCarreau <> 0 Then
            tailleCarreau -= 1 'Si la taille obtenue est trop grand pour la map on diminue leur taille
        End If
        'On réajuste la taille de la map en fonction de la taille des carreaux
        Dim Reajustement As Integer = tailleCarreau * tailleMap
        Map.Size = New Size(Reajustement, Reajustement)
        Map.Left = ((Me.Width - Map.Width) / 2) * 0.75 'Les tailles des contrôles sont converties avec un coefficient qui tourne autour de 0,75
        Dim x As Integer
        Dim y As Integer = 0
        Dim nbCases As Integer = 0
        For i = 1 To tailleMap
            x = 0
            For j = 1 To tailleMap
                'création du bouton
                Dim b As New Button
                b.Width = tailleCarreau
                b.Height = tailleCarreau
                b.Text = ""
                b.Name = InStr("Bouton", nbCases)
                b.Left = x
                b.Top = y
                b.BackColor = mainModule.GetCouleur
                AddHandler b.MouseDown, AddressOf Button_Click
                Map.Controls.Add(b)
                'création du label
                Dim l As New Label
                l.Width = tailleCarreau
                l.Height = tailleCarreau
                l.TextAlign = ContentAlignment.MiddleCenter
                l.BorderStyle = BorderStyle.FixedSingle
                l.Name = InStr("Label", nbCases)
                l.Left = x
                l.Top = y
                l.BackColor = mainModule.GetCouleur()
                Map.Controls.Add(l)
                nbCases += 1
                x += tailleCarreau
            Next
            y += tailleCarreau
        Next
    End Sub

    Public Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Not mainModule.PartieTerminee() Then
            Dim taille = Map.Width / mainModule.GetTaille()
            Dim clic As MouseEventArgs = DirectCast(e, MouseEventArgs)
            Dim indice As Integer = 1
            If pause = True And commence = False Then
                pause = False
                ButPause.Image = New Bitmap(My.Resources.Pause, New Size(ButPause.Size))
            End If
            If pause = False Then
                If clic.Button = MouseButtons.Right Then
                    If sender.BackgroundImage Is Nothing Then 'Vérifie s'il y a un drapeau sur la case
                        sender.BackgroundImage = New Bitmap(My.Resources.Flag, New Size(taille, taille))
                        minesRestantes -= 1
                        If minesRestantes >= 0 Then
                            LabNbMines.Text = minesRestantes
                        Else
                            LabNbMines.Text = "0"
                        End If
                    Else
                        minesRestantes += 1
                        If minesRestantes >= 0 Then
                            LabNbMines.Text = minesRestantes
                        Else
                            LabNbMines.Text = "0"
                        End If
                        sender.BackgroundImage = Nothing
                    End If
                Else
                    If sender.BackgroundImage Is Nothing Then
                        sender.Visible = False
                        If commence = False Then
                            commence = True
                            mainModule.initialiserMap()
                            mainModule.AfficherMap()
                        End If
                        For Each ctrl As Control In Map.Controls
                            If TypeOf (ctrl) Is Button Then
                                If ctrl.Location = sender.Location Then
                                    mainModule.Demasquer(indice)
                                    mainModule.Vider(indice)
                                End If
                                indice += 1
                            End If
                        Next
                    End If
                    mainModule.ActualiserMap()
                End If
            End If
        End If
    End Sub

    Private Sub ButAbandonner_Click(sender As Object, e As EventArgs) Handles ButAbandonner.Click
        If mainModule.PartieTerminee() Then
            Me.Close()
            Accueil.Show()
        Else
            Dim reponse As String = MsgBox("Voulez-vous vraiment abandonner ?", vbYesNo)
            If reponse = vbYes Then
                Me.Close()
                mainModule.Terminer("Partie abandonnée")
                Accueil.Show()
            End If
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If pause = False And Not mainModule.PartieTerminee() Then
            temps -= 1
            LabTemps.Text = temps
            mainModule.Tick()
        End If
        If temps <= 0 Then
            Timer.Enabled = False
            mainModule.TempsEcoule()
        End If
    End Sub

    Private Sub ButPause_Click(sender As Object, e As EventArgs) Handles ButPause.Click
        If Not mainModule.PartieTerminee() Then
            If pause = False Then
                pause = True
                ButPause.Image = New Bitmap(My.Resources.Play, New Size(ButPause.Size))
            Else
                pause = False
                ButPause.Image = New Bitmap(My.Resources.Pause, New Size(ButPause.Size))
                If commence = False Then
                    mainModule.DemasquerAuHasard()
                End If
            End If
        End If
    End Sub

End Class