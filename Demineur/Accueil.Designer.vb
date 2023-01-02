<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CmbNoms = New System.Windows.Forms.ComboBox()
        Me.ButCommencer = New System.Windows.Forms.Button()
        Me.ButScores = New System.Windows.Forms.Button()
        Me.ButQuitter = New System.Windows.Forms.Button()
        Me.ButValider = New System.Windows.Forms.Button()
        Me.LabNoms = New System.Windows.Forms.Label()
        Me.PanNoms = New System.Windows.Forms.Panel()
        Me.LabAjoute = New System.Windows.Forms.Label()
        Me.ButFichier = New System.Windows.Forms.Button()
        Me.LabCommencer = New System.Windows.Forms.Label()
        Me.TxtFichier = New System.Windows.Forms.TextBox()
        Me.LabIndication = New System.Windows.Forms.Label()
        Me.PanTitre = New System.Windows.Forms.Panel()
        Me.PctTitre = New System.Windows.Forms.PictureBox()
        Me.PctSmiley = New System.Windows.Forms.PictureBox()
        Me.CmbTheme = New System.Windows.Forms.ComboBox()
        Me.TxtTheme = New System.Windows.Forms.TextBox()
        Me.PanNoms.SuspendLayout()
        Me.PanTitre.SuspendLayout()
        CType(Me.PctTitre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctSmiley, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbNoms
        '
        Me.CmbNoms.BackColor = System.Drawing.Color.Gainsboro
        Me.CmbNoms.FormattingEnabled = True
        Me.CmbNoms.Location = New System.Drawing.Point(19, 32)
        Me.CmbNoms.Name = "CmbNoms"
        Me.CmbNoms.Size = New System.Drawing.Size(302, 24)
        Me.CmbNoms.TabIndex = 0
        '
        'ButCommencer
        '
        Me.ButCommencer.Location = New System.Drawing.Point(333, 359)
        Me.ButCommencer.Name = "ButCommencer"
        Me.ButCommencer.Size = New System.Drawing.Size(102, 36)
        Me.ButCommencer.TabIndex = 1
        Me.ButCommencer.Text = "Commencer"
        Me.ButCommencer.UseVisualStyleBackColor = True
        '
        'ButScores
        '
        Me.ButScores.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButScores.Location = New System.Drawing.Point(196, 359)
        Me.ButScores.Name = "ButScores"
        Me.ButScores.Size = New System.Drawing.Size(95, 36)
        Me.ButScores.TabIndex = 2
        Me.ButScores.Text = "Scores"
        Me.ButScores.UseVisualStyleBackColor = True
        '
        'ButQuitter
        '
        Me.ButQuitter.Location = New System.Drawing.Point(58, 359)
        Me.ButQuitter.Name = "ButQuitter"
        Me.ButQuitter.Size = New System.Drawing.Size(95, 36)
        Me.ButQuitter.TabIndex = 3
        Me.ButQuitter.Text = "Quitter"
        Me.ButQuitter.UseVisualStyleBackColor = True
        '
        'ButValider
        '
        Me.ButValider.ForeColor = System.Drawing.Color.Black
        Me.ButValider.Location = New System.Drawing.Point(321, 32)
        Me.ButValider.Name = "ButValider"
        Me.ButValider.Size = New System.Drawing.Size(75, 23)
        Me.ButValider.TabIndex = 4
        Me.ButValider.Text = "Valider"
        Me.ButValider.UseVisualStyleBackColor = True
        '
        'LabNoms
        '
        Me.LabNoms.AutoSize = True
        Me.LabNoms.ForeColor = System.Drawing.Color.Red
        Me.LabNoms.Location = New System.Drawing.Point(27, 12)
        Me.LabNoms.Name = "LabNoms"
        Me.LabNoms.Size = New System.Drawing.Size(132, 17)
        Me.LabNoms.TabIndex = 5
        Me.LabNoms.Text = "nom saisi trop court"
        Me.LabNoms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabNoms.Visible = False
        '
        'PanNoms
        '
        Me.PanNoms.Controls.Add(Me.LabAjoute)
        Me.PanNoms.Controls.Add(Me.ButFichier)
        Me.PanNoms.Controls.Add(Me.LabCommencer)
        Me.PanNoms.Controls.Add(Me.TxtFichier)
        Me.PanNoms.Controls.Add(Me.LabNoms)
        Me.PanNoms.Controls.Add(Me.ButValider)
        Me.PanNoms.Controls.Add(Me.CmbNoms)
        Me.PanNoms.Location = New System.Drawing.Point(39, 173)
        Me.PanNoms.Name = "PanNoms"
        Me.PanNoms.Size = New System.Drawing.Size(413, 103)
        Me.PanNoms.TabIndex = 6
        '
        'LabAjoute
        '
        Me.LabAjoute.AutoSize = True
        Me.LabAjoute.ForeColor = System.Drawing.Color.Red
        Me.LabAjoute.Location = New System.Drawing.Point(27, 12)
        Me.LabAjoute.Name = "LabAjoute"
        Me.LabAjoute.Size = New System.Drawing.Size(109, 17)
        Me.LabAjoute.TabIndex = 10
        Me.LabAjoute.Text = "nom déjà ajouté"
        Me.LabAjoute.Visible = False
        '
        'ButFichier
        '
        Me.ButFichier.BackColor = System.Drawing.Color.Silver
        Me.ButFichier.Location = New System.Drawing.Point(321, 62)
        Me.ButFichier.Name = "ButFichier"
        Me.ButFichier.Size = New System.Drawing.Size(75, 23)
        Me.ButFichier.TabIndex = 10
        Me.ButFichier.Text = "..."
        Me.ButFichier.UseVisualStyleBackColor = False
        '
        'LabCommencer
        '
        Me.LabCommencer.AutoSize = True
        Me.LabCommencer.ForeColor = System.Drawing.Color.Red
        Me.LabCommencer.Location = New System.Drawing.Point(27, 12)
        Me.LabCommencer.Name = "LabCommencer"
        Me.LabCommencer.Size = New System.Drawing.Size(204, 17)
        Me.LabCommencer.TabIndex = 6
        Me.LabCommencer.Text = "veuillez saisir au moins un nom"
        Me.LabCommencer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabCommencer.Visible = False
        '
        'TxtFichier
        '
        Me.TxtFichier.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtFichier.Enabled = False
        Me.TxtFichier.Location = New System.Drawing.Point(19, 62)
        Me.TxtFichier.Name = "TxtFichier"
        Me.TxtFichier.Size = New System.Drawing.Size(302, 22)
        Me.TxtFichier.TabIndex = 11
        '
        'LabIndication
        '
        Me.LabIndication.AutoSize = True
        Me.LabIndication.ForeColor = System.Drawing.Color.Black
        Me.LabIndication.Location = New System.Drawing.Point(96, 270)
        Me.LabIndication.Name = "LabIndication"
        Me.LabIndication.Size = New System.Drawing.Size(306, 17)
        Me.LabIndication.TabIndex = 10
        Me.LabIndication.Text = "Saisissez un nom et un fichier pour commencer"
        '
        'PanTitre
        '
        Me.PanTitre.BackColor = System.Drawing.Color.Gainsboro
        Me.PanTitre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanTitre.Controls.Add(Me.PctTitre)
        Me.PanTitre.Controls.Add(Me.PctSmiley)
        Me.PanTitre.Location = New System.Drawing.Point(42, 42)
        Me.PanTitre.Name = "PanTitre"
        Me.PanTitre.Size = New System.Drawing.Size(409, 131)
        Me.PanTitre.TabIndex = 9
        '
        'PctTitre
        '
        Me.PctTitre.BackColor = System.Drawing.Color.Transparent
        Me.PctTitre.Location = New System.Drawing.Point(122, 14)
        Me.PctTitre.Name = "PctTitre"
        Me.PctTitre.Size = New System.Drawing.Size(271, 100)
        Me.PctTitre.TabIndex = 8
        Me.PctTitre.TabStop = False
        '
        'PctSmiley
        '
        Me.PctSmiley.BackColor = System.Drawing.Color.Transparent
        Me.PctSmiley.Location = New System.Drawing.Point(16, 14)
        Me.PctSmiley.Name = "PctSmiley"
        Me.PctSmiley.Size = New System.Drawing.Size(100, 100)
        Me.PctSmiley.TabIndex = 7
        Me.PctSmiley.TabStop = False
        '
        'CmbTheme
        '
        Me.CmbTheme.BackColor = System.Drawing.Color.Gainsboro
        Me.CmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTheme.FormattingEnabled = True
        Me.CmbTheme.Items.AddRange(New Object() {"Classique", "Clair", "Sombre", "Bleu", "Vert", "Jaune"})
        Me.CmbTheme.Location = New System.Drawing.Point(218, 305)
        Me.CmbTheme.Name = "CmbTheme"
        Me.CmbTheme.Size = New System.Drawing.Size(121, 24)
        Me.CmbTheme.TabIndex = 11
        '
        'TxtTheme
        '
        Me.TxtTheme.BackColor = System.Drawing.Color.Silver
        Me.TxtTheme.Location = New System.Drawing.Point(143, 307)
        Me.TxtTheme.Name = "TxtTheme"
        Me.TxtTheme.ReadOnly = True
        Me.TxtTheme.Size = New System.Drawing.Size(75, 22)
        Me.TxtTheme.TabIndex = 12
        Me.TxtTheme.Text = "Thème"
        Me.TxtTheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(482, 453)
        Me.Controls.Add(Me.TxtTheme)
        Me.Controls.Add(Me.CmbTheme)
        Me.Controls.Add(Me.LabIndication)
        Me.Controls.Add(Me.PanTitre)
        Me.Controls.Add(Me.PanNoms)
        Me.Controls.Add(Me.ButQuitter)
        Me.Controls.Add(Me.ButScores)
        Me.Controls.Add(Me.ButCommencer)
        Me.Name = "Accueil"
        Me.ShowIcon = False
        Me.Text = "Accueil"
        Me.PanNoms.ResumeLayout(False)
        Me.PanNoms.PerformLayout()
        Me.PanTitre.ResumeLayout(False)
        CType(Me.PctTitre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctSmiley, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbNoms As ComboBox
    Friend WithEvents ButCommencer As Button
    Friend WithEvents ButScores As Button
    Friend WithEvents ButQuitter As Button
    Friend WithEvents ButValider As Button
    Friend WithEvents LabNoms As Label
    Friend WithEvents PanNoms As Panel
    Friend WithEvents LabCommencer As Label
    Friend WithEvents PctSmiley As PictureBox
    Friend WithEvents PctTitre As PictureBox
    Friend WithEvents PanTitre As Panel
    Friend WithEvents LabIndication As Label
    Friend WithEvents LabAjoute As Label
    Friend WithEvents ButFichier As Button
    Friend WithEvents TxtFichier As TextBox
    Friend WithEvents CmbTheme As ComboBox
    Friend WithEvents TxtTheme As TextBox
End Class
