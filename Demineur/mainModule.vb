Module mainModule

    Dim random As New Random()

    Public Structure Carreau
        Public indice As Integer
        Public nbMines As Integer
        Public masque As Boolean
        Public libre As Boolean
    End Structure


    Public Structure Map
        Public taille As Integer
        Public nbMines As Integer
        Public carreaux As Carreau()
    End Structure

    Public Structure Personne
        Public nom As String
        Public score As Integer
        Public temps As Integer
        Public record As Integer
        Public parties As Integer
        Public tempsTotal As Integer
    End Structure

    Dim personnes As New List(Of Personne)
    Dim taille As Integer
    Dim nbMines As Integer
    Dim temps As Integer
    Dim locLabMines = Difficulte.LabMines.Location
    Dim locLabTemps = Difficulte.LabTemps.Location
    Dim m As New Map
    Dim vides As List(Of Carreau)
    Dim termine As Boolean
    Dim pause As Boolean
    Dim DifficulteSize = Difficulte.Size
    Dim ExtendedDifficulteSize = New Size(Difficulte.Width, Difficulte.Height + 110)
    Dim nbDemasquees As Integer
    Dim nomFichier As String
    Dim delimiteur As String = "|"
    Dim ecoule As Integer
    Dim couleur As Color

    Sub Main()
        Application.Run(Accueil)
    End Sub

    Sub initialiserMap()
        nbDemasquees = 0
        ecoule = 0
        vides = New List(Of Carreau)
        Dim i As Integer = 1
        m.taille = taille
        ReDim m.carreaux(m.taille * m.taille)
        For Each ctrl As Control In Jeu.Map.Controls
            If TypeOf (ctrl) Is Button Then
                If ctrl.Visible = True Then
                    m.carreaux(i).masque = True
                Else
                    m.carreaux(i).masque = False
                End If
                m.carreaux(i).libre = True
                m.carreaux(i).indice = i
                m.carreaux(i).nbMines = 0
                i += 1
            End If
        Next
        AjouterMines(nbMines)
        EnregistrerMines()
    End Sub

    Sub AjouterMines(nbMines As Integer)
        m.nbMines = nbMines
        Dim compteur As Integer = 0
        Dim position As Integer
        While compteur < m.nbMines
            position = random.Next(1, m.taille * m.taille) 'Obtient une position aléatoire dans les dimensions de la grille
            'On vérifie qu'une mine n'a pas déjà été posée à cet endroit et on ne pose pas de mine autour de la case de départ
            If m.carreaux(position).libre = True And m.carreaux(position).masque = True AndAlso Not CarreauDemasqueAutour(m.carreaux(position)) Then
                m.carreaux(position).libre = False
                compteur += 1
            End If
        End While
    End Sub

    Function CompterMines(c As Carreau) As Integer
        Dim compteur As Integer = 0
        Dim position As Integer
        'On vérifie les cases tout autour de la case actuelle
        For i = -1 To 1
            For j = -1 To 1
                position = c.indice + (i * m.taille + j) 'Obtient les positions de toutes les cases adjacentes à celle en paramètre
                'On vérifie que la position observée est bien adjacente et pas seulement celle d'après dans le tableau de carreaux
                If position > 0 AndAlso position <= (m.taille * m.taille) AndAlso Not (c.indice Mod m.taille = 0 And position Mod m.taille = 1) AndAlso Not (c.indice Mod m.taille = 1 And position Mod m.taille = 0) Then
                    If m.carreaux(position).libre = False Then
                        compteur += 1
                    End If
                End If
            Next
        Next
        Return compteur
    End Function

    Sub EnregistrerMines()
        For i = 1 To m.taille * m.taille
            m.carreaux(i).nbMines = CompterMines(m.carreaux(i))
        Next
    End Sub

    Sub AfficherMap()
        Dim i As Integer = 1
        Dim tailleCarreau As Integer = Jeu.Map.Width / m.taille
        For Each l In Jeu.Map.Controls
            If TypeOf l Is Label Then
                If m.carreaux(i).libre = False Then
                    l.BackgroundImage = New Bitmap(My.Resources.Mine, New Size(tailleCarreau, tailleCarreau))
                Else
                    If m.carreaux(i).nbMines > 0 Then
                        l.Text = m.carreaux(i).nbMines
                        Select Case m.carreaux(i).nbMines
                            Case 1
                                l.ForeColor = Color.Blue
                            Case 2
                                l.ForeColor = Color.DarkGreen
                            Case 3
                                l.ForeColor = Color.Red
                            Case 4
                                l.ForeColor = Color.DarkBlue
                            Case 5
                                l.ForeColor = Color.DarkRed
                            Case 6
                                l.ForeColor = Color.LightSeaGreen
                            Case 7
                                l.ForeColor = Color.Black
                            Case 8
                                l.ForeColor = Color.DarkGray
                        End Select
                    End If
                End If
                i += 1
            End If
        Next
    End Sub

    Function CarreauDemasqueAutour(c As Carreau) As Boolean
        Dim position As Integer
        For i = -1 To 1
            For j = -1 To 1
                position = c.indice + (i * m.taille + j)
                If position <> c.indice And position > 0 AndAlso position <= m.taille * m.taille AndAlso Not (c.indice Mod m.taille = 0 And position Mod m.taille = 1) AndAlso Not (c.indice Mod m.taille = 1 And position Mod m.taille = 0) Then
                    If m.carreaux(position).masque = False Then
                        Return True
                    End If
                End If
            Next
        Next
        Return False
    End Function

    Sub Vider(i As Integer)
        Dim c As Carreau = m.carreaux(i)
        'Si la case sur laquelle on a cliqué est vide on démasque toutes les cases vides autour
        If c.nbMines = 0 Then
            Dim compteur As Integer = 0
            vides.Add(c)
            'Tant qu'il y a des cases vides trouvées non traités on continue d'en chercher
            Do
                compteur += 1
                CarreauxVidesAutour(c)
                If compteur < vides.Count Then
                    c = vides(compteur)
                End If
            Loop While compteur < vides.Count
            'Une fois toutes les cases vides trouvées on démasque toutes les cases autour de celles-ci
            For Each carr As Carreau In vides
                ViderAutour(carr)
            Next
        End If
    End Sub

    Sub CarreauxVidesAutour(c As Carreau)
        'On ajoute toutes les cases vides autour d'une case donnée dans les cases vides trouvées
        Dim position As Integer
        For i = -1 To 1
            For j = -1 To 1
                position = c.indice + (i * m.taille + j)
                If position <> c.indice And position > 0 AndAlso position <= m.taille * m.taille AndAlso Not (c.indice Mod m.taille = 0 And position Mod m.taille = 1) AndAlso Not (c.indice Mod m.taille = 1 And position Mod m.taille = 0) Then
                    If m.carreaux(position).libre = True And m.carreaux(position).nbMines = 0 AndAlso Not vides.Contains(m.carreaux(position)) Then
                        vides.Add(m.carreaux(position))
                        If m.carreaux(position).masque = True Then
                            nbDemasquees += 1
                        End If
                        m.carreaux(position).masque = False
                    End If
                End If
            Next
        Next
    End Sub

    Sub ViderAutour(c As Carreau)
        Dim position As Integer
        For i = -1 To 1
            For j = -1 To 1
                position = c.indice + (i * m.taille + j)
                If position <> c.indice And position > 0 AndAlso position <= m.taille * m.taille AndAlso Not (c.indice Mod m.taille = 0 And position Mod m.taille = 1) AndAlso Not (c.indice Mod m.taille = 1 And position Mod m.taille = 0) Then
                    If m.carreaux(position).masque = True Then
                        nbDemasquees += 1
                    End If
                    m.carreaux(position).masque = False
                End If
            Next
        Next
    End Sub

    Sub ActualiserMap()
        'On actualise toute la map du formulaire jeu en fonction du tableau de carreaux du module
        Dim i As Integer = 1
        Dim gagne As Boolean = True
        For Each ctrl As Control In Jeu.Map.Controls
            If TypeOf (ctrl) Is Button Then
                If m.carreaux(i).masque = False Then
                    ctrl.Visible = False
                    If m.carreaux(i).libre = False Then
                        Terminer("partie perdue")
                        Exit For
                    End If
                Else
                    If m.carreaux(i).libre = True Then
                        gagne = False
                    End If
                End If
                i += 1
            End If
        Next
        If gagne = True And termine = False Then
            Terminer("partie gagnée")
        End If
    End Sub

    Sub DemasquerMap()
        Dim i As Integer = 1
        Dim tailleCarreau = Jeu.Map.Width / m.taille
        For Each ctrl As Control In Jeu.Map.Controls
            If TypeOf (ctrl) Is Button Then
                If ctrl.BackgroundImage Is Nothing Then
                    ctrl.Visible = False
                Else
                    If m.carreaux(i).libre = True Then
                        ctrl.BackgroundImage = New Bitmap(My.Resources.Flag_Cross, New Size(tailleCarreau, tailleCarreau))
                    End If
                End If
                i += 1
            End If
        Next
    End Sub

    Sub Demasquer(i As Integer)
        m.carreaux(i).masque = False
        If m.carreaux(i).libre = True Then
            nbDemasquees += 1
        End If
    End Sub

    Sub DemasquerAuHasard()
        Dim pos As Integer = random.Next(1, taille * taille)
        Dim i As Integer = 1
        For Each b As Control In Jeu.Map.Controls
            If TypeOf (b) Is Button Then
                i += 1
                If i = pos Then
                    'Simule un clic sur la case trouvée au hasard
                    Jeu.Button_Click(b, New MouseEventArgs(Button.MouseButtons.Left, 1, 0, 0, 0))
                End If
            End If
        Next
    End Sub

    Sub AjouterPersonne(Nom As String, Parties As Integer, Record As Integer, Score As Integer, Temps As Integer, TempsTotal As Integer)
        If Not ExistePersonne(Nom) Then
            Accueil.LabAjoute.Visible = False
            Dim p As Personne
            p.nom = Nom
            p.score = Score
            p.parties = Parties
            p.temps = Temps
            p.tempsTotal = TempsTotal
            p.record = Record
            personnes.Add(p)
        Else
            Accueil.LabAjoute.Visible = True
        End If
    End Sub

    Function ExistePersonne(Nom As String) As Boolean
        For Each pers As Personne In personnes
            If String.Equals(Nom, pers.nom) Then
                Return True
            End If
        Next
        Return False
    End Function

    Sub SetMines(mines As Integer)
        nbMines = mines
    End Sub

    Function GetMines() As Integer
        Return nbMines
    End Function

    Sub SetTaille(tailleMap As Integer)
        taille = tailleMap
    End Sub

    Sub SetTemps(t As Integer)
        temps = t
    End Sub

    Sub SetFichier(nom As String)
        nomFichier = nom
    End Sub

    Function GetFichier() As String
        Return nomFichier
    End Function

    Function GetTaille() As Integer
        Return taille
    End Function

    Function GetTemps() As Integer
        Return temps
    End Function

    Function GetDifficulteSize()
        Return DifficulteSize
    End Function

    Function GetExtendedDifficulteSize()
        Return ExtendedDifficulteSize
    End Function

    Sub TempsEcoule()
        Terminer("temps écoulé")
    End Sub

    Sub Tick()
        ecoule += 1
    End Sub

    Function PartieTerminee() As Boolean
        Return termine
    End Function

    Sub Commencer()
        termine = False
    End Sub

    Sub AjouterPersonnes()
        Dim tmp As Personne
        'On classe d'abord les personnes en fonction de leur record et si besoin de leur temps associé
        For i = 0 To personnes.Count - 1
            For j = 0 To personnes.Count - 2
                If personnes(j).record > personnes(j + 1).record Then
                    tmp = personnes(j)
                    personnes(j) = personnes(j + 1)
                    personnes(j + 1) = tmp
                ElseIf personnes(j).record = personnes(j + 1).record Then
                    If personnes(j).temps > personnes(j + 1).temps Then
                        tmp = personnes(j)
                        personnes(j) = personnes(j + 1)
                        personnes(j + 1) = tmp
                    End If
                End If
            Next
        Next
        'On ajoute les personnes aux endroits nécessaires
        For Each p As Personne In personnes
            If p.nom IsNot Nothing Then
                If Not Scores.LstNoms.Items.Contains(p.nom) Then
                    Scores.LstNoms.Items.Add(p.nom)
                    Scores.LstRecord.Items.Add(p.record)
                    Scores.LstTemps.Items.Add(p.temps)
                End If
                If Not Accueil.CmbNoms.Items.Contains(p.nom) Then
                    Accueil.CmbNoms.Items.Add(p.nom)
                End If
                If Not Scores.CmbNoms.Items.Contains(p.nom) Then
                    Scores.CmbNoms.Items.Add(p.nom)
                End If
            End If
        Next
    End Sub

    Function JoueursVide() As Boolean
        If personnes.Count > 0 Then
            Return False
        End If
        Return True
    End Function

    Sub Terminer(message As String)
        'Termine la partie et affiche le message saisi en paramètre par MsgBox
        For i = 0 To personnes.Count - 1
            If String.Equals(Accueil.CmbNoms.Text, personnes(i).nom) Then
                Dim newP As Personne
                newP.nom = personnes(i).nom
                newP.parties = personnes(i).parties + 1
                newP.score = personnes(i).score + nbDemasquees
                newP.tempsTotal = personnes(i).tempsTotal + ecoule
                If personnes(i).record < nbDemasquees Or personnes(i).record = 0 Then
                    newP.record = nbDemasquees
                    newP.temps = ecoule
                Else
                    newP.record = personnes(i).record
                    newP.temps = personnes(i).temps
                End If
                personnes(i) = newP
            End If
        Next
        Jeu.Timer.Enabled = False
        termine = True
        Jeu.ButAbandonner.Text = "Retour"
        Jeu.ButPause.Image = New Bitmap(My.Resources.Play, New Size(Jeu.ButPause.Size))
        DemasquerMap()
        MsgBox(message & Chr(10) & Chr(10) & "Cases révélées : " & nbDemasquees & Chr(10) & "Temps écoulé : " & ecoule & "s")
    End Sub

    Sub ActualiserPersonnes()
        'Remplace tout le tableau de personnes par celles qui seront lues dans le fichier
        personnes.Clear()
        Accueil.CmbNoms.Items.Clear()
        Scores.CmbNoms.Items.Clear()
        Scores.LstNoms.Items.Clear()
        Scores.LstRecord.Items.Clear()
        Scores.LstTemps.Items.Clear()
        Dim lecteur As New IO.StreamReader(nomFichier)
        Dim ligne As String
        Dim nb As Integer
        ligne = lecteur.ReadLine
        If ligne = "" Then
            lecteur.Close()
            Return
        End If
        If Not IsNumeric(ligne) Then
            MsgBox("Certaines données du fichier sont mal saisies")
            lecteur.Close()
            Return
        End If
        nb = CInt(ligne) - 1
        For i = 0 To nb
            Dim p As New Personne
            ligne = lecteur.ReadLine
            p.nom = ligne
            ligne = lecteur.ReadLine
            p.parties = ligne
            ligne = lecteur.ReadLine
            p.record = ligne
            ligne = lecteur.ReadLine
            p.score = ligne
            ligne = lecteur.ReadLine
            p.temps = ligne
            ligne = lecteur.ReadLine
            p.tempsTotal = ligne
            personnes.Add(p)
        Next
        lecteur.Close()
    End Sub

    Sub enregistrerPersonnes()
        FileOpen(1, nomFichier, 2)
        FileClose(1)
        Dim ecriture As New IO.StreamWriter(nomFichier)
        ecriture.WriteLine(personnes.Count)
        For Each p As Personne In personnes
            ecriture.WriteLine(p.nom)
            ecriture.WriteLine(p.parties)
            ecriture.WriteLine(p.record)
            ecriture.WriteLine(p.score)
            ecriture.WriteLine(p.temps)
            ecriture.WriteLine(p.tempsTotal)
        Next
        ecriture.Close()
    End Sub

    Sub SupprimerPersonnes()
        'Vide le fichier et le tableau de personnes
        FileOpen(1, nomFichier, 2)
        FileClose(1)
        ActualiserPersonnes()
    End Sub

    Sub AfficherPersonne(Nom As String)
        For i = 0 To personnes.Count - 1
            If String.Equals(personnes(i).nom, Nom) Then
                MsgBox(personnes(i).nom & " :" & Chr(10) & Chr(10) & "Parties : " & personnes(i).parties & Chr(10) & "Record : " & personnes(i).record & Chr(10) & "Temps associé : " & personnes(i).temps & Chr(10) & "Score total : " & personnes(i).score & Chr(10) & "Temps total : " & personnes(i).tempsTotal)
            End If
        Next
    End Sub

    Sub SetCouleur(c As Color)
        couleur = c
    End Sub

    Function GetCouleur() As Color
        Return couleur
    End Function

End Module