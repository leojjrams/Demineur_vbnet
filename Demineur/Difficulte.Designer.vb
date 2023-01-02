<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Difficulte
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButFacile = New System.Windows.Forms.Button()
        Me.ButNormal = New System.Windows.Forms.Button()
        Me.ButDifficile = New System.Windows.Forms.Button()
        Me.LabFacile = New System.Windows.Forms.Label()
        Me.LabNormal = New System.Windows.Forms.Label()
        Me.LabDifficile = New System.Windows.Forms.Label()
        Me.ButPersonnalise = New System.Windows.Forms.Button()
        Me.TxtSaisieTaille = New System.Windows.Forms.TextBox()
        Me.TxtTaille = New System.Windows.Forms.TextBox()
        Me.ButValider = New System.Windows.Forms.Button()
        Me.TxtMines = New System.Windows.Forms.TextBox()
        Me.TxtSaisieMines = New System.Windows.Forms.TextBox()
        Me.LabTaille = New System.Windows.Forms.Label()
        Me.LabMines = New System.Windows.Forms.Label()
        Me.PanPersonnalise = New System.Windows.Forms.Panel()
        Me.LabNbMines = New System.Windows.Forms.Label()
        Me.LabTemps = New System.Windows.Forms.Label()
        Me.LabSaisies = New System.Windows.Forms.Label()
        Me.PanSaisies = New System.Windows.Forms.Panel()
        Me.TxtSaisieTemps = New System.Windows.Forms.TextBox()
        Me.TxtTemps = New System.Windows.Forms.TextBox()
        Me.PanFacile = New System.Windows.Forms.Panel()
        Me.PanNormal = New System.Windows.Forms.Panel()
        Me.PanDifficile = New System.Windows.Forms.Panel()
        Me.PanPersonnalise.SuspendLayout()
        Me.PanSaisies.SuspendLayout()
        Me.PanFacile.SuspendLayout()
        Me.PanNormal.SuspendLayout()
        Me.PanDifficile.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButFacile
        '
        Me.ButFacile.ForeColor = System.Drawing.Color.LimeGreen
        Me.ButFacile.Location = New System.Drawing.Point(7, 4)
        Me.ButFacile.Name = "ButFacile"
        Me.ButFacile.Size = New System.Drawing.Size(258, 70)
        Me.ButFacile.TabIndex = 0
        Me.ButFacile.Text = "Facile"
        Me.ButFacile.UseVisualStyleBackColor = True
        '
        'ButNormal
        '
        Me.ButNormal.ForeColor = System.Drawing.Color.MediumBlue
        Me.ButNormal.Location = New System.Drawing.Point(3, 1)
        Me.ButNormal.Name = "ButNormal"
        Me.ButNormal.Size = New System.Drawing.Size(258, 70)
        Me.ButNormal.TabIndex = 1
        Me.ButNormal.Text = "Normal"
        Me.ButNormal.UseVisualStyleBackColor = True
        '
        'ButDifficile
        '
        Me.ButDifficile.ForeColor = System.Drawing.Color.Firebrick
        Me.ButDifficile.Location = New System.Drawing.Point(2, 7)
        Me.ButDifficile.Name = "ButDifficile"
        Me.ButDifficile.Size = New System.Drawing.Size(258, 70)
        Me.ButDifficile.TabIndex = 2
        Me.ButDifficile.Text = "Difficile"
        Me.ButDifficile.UseVisualStyleBackColor = True
        '
        'LabFacile
        '
        Me.LabFacile.AutoSize = True
        Me.LabFacile.BackColor = System.Drawing.Color.Transparent
        Me.LabFacile.ForeColor = System.Drawing.Color.LimeGreen
        Me.LabFacile.Location = New System.Drawing.Point(69, 48)
        Me.LabFacile.Name = "LabFacile"
        Me.LabFacile.Size = New System.Drawing.Size(142, 17)
        Me.LabFacile.TabIndex = 7
        Me.LabFacile.Text = "8 x 8 / 10 mines / 60s"
        '
        'LabNormal
        '
        Me.LabNormal.AutoSize = True
        Me.LabNormal.BackColor = System.Drawing.Color.Transparent
        Me.LabNormal.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabNormal.Location = New System.Drawing.Point(56, 44)
        Me.LabNormal.Name = "LabNormal"
        Me.LabNormal.Size = New System.Drawing.Size(166, 17)
        Me.LabNormal.TabIndex = 8
        Me.LabNormal.Text = "16 x 16 / 40 mines / 300s"
        '
        'LabDifficile
        '
        Me.LabDifficile.AutoSize = True
        Me.LabDifficile.BackColor = System.Drawing.Color.Transparent
        Me.LabDifficile.ForeColor = System.Drawing.Color.Firebrick
        Me.LabDifficile.Location = New System.Drawing.Point(55, 49)
        Me.LabDifficile.Name = "LabDifficile"
        Me.LabDifficile.Size = New System.Drawing.Size(166, 17)
        Me.LabDifficile.TabIndex = 9
        Me.LabDifficile.Text = "24 x 24 / 99 mines / 500s"
        '
        'ButPersonnalise
        '
        Me.ButPersonnalise.ForeColor = System.Drawing.Color.DarkViolet
        Me.ButPersonnalise.Location = New System.Drawing.Point(2, 0)
        Me.ButPersonnalise.Name = "ButPersonnalise"
        Me.ButPersonnalise.Size = New System.Drawing.Size(258, 70)
        Me.ButPersonnalise.TabIndex = 3
        Me.ButPersonnalise.Text = "Personnalisé"
        Me.ButPersonnalise.UseVisualStyleBackColor = True
        '
        'TxtSaisieTaille
        '
        Me.TxtSaisieTaille.Location = New System.Drawing.Point(88, 4)
        Me.TxtSaisieTaille.Name = "TxtSaisieTaille"
        Me.TxtSaisieTaille.Size = New System.Drawing.Size(100, 22)
        Me.TxtSaisieTaille.TabIndex = 4
        '
        'TxtTaille
        '
        Me.TxtTaille.BackColor = System.Drawing.Color.Silver
        Me.TxtTaille.ForeColor = System.Drawing.Color.DarkViolet
        Me.TxtTaille.Location = New System.Drawing.Point(0, 4)
        Me.TxtTaille.Name = "TxtTaille"
        Me.TxtTaille.ReadOnly = True
        Me.TxtTaille.Size = New System.Drawing.Size(88, 22)
        Me.TxtTaille.TabIndex = 5
        Me.TxtTaille.Text = "Taille"
        Me.TxtTaille.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButValider
        '
        Me.ButValider.ForeColor = System.Drawing.Color.DarkViolet
        Me.ButValider.Location = New System.Drawing.Point(188, 4)
        Me.ButValider.Name = "ButValider"
        Me.ButValider.Size = New System.Drawing.Size(70, 66)
        Me.ButValider.TabIndex = 6
        Me.ButValider.Text = "Valider"
        Me.ButValider.UseVisualStyleBackColor = True
        '
        'TxtMines
        '
        Me.TxtMines.BackColor = System.Drawing.Color.Silver
        Me.TxtMines.ForeColor = System.Drawing.Color.DarkViolet
        Me.TxtMines.Location = New System.Drawing.Point(0, 26)
        Me.TxtMines.Name = "TxtMines"
        Me.TxtMines.ReadOnly = True
        Me.TxtMines.Size = New System.Drawing.Size(88, 22)
        Me.TxtMines.TabIndex = 10
        Me.TxtMines.Text = "Mines"
        Me.TxtMines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSaisieMines
        '
        Me.TxtSaisieMines.Location = New System.Drawing.Point(88, 26)
        Me.TxtSaisieMines.Name = "TxtSaisieMines"
        Me.TxtSaisieMines.Size = New System.Drawing.Size(100, 22)
        Me.TxtSaisieMines.TabIndex = 11
        '
        'LabTaille
        '
        Me.LabTaille.AutoSize = True
        Me.LabTaille.ForeColor = System.Drawing.Color.Red
        Me.LabTaille.Location = New System.Drawing.Point(3, 144)
        Me.LabTaille.Name = "LabTaille"
        Me.LabTaille.Size = New System.Drawing.Size(91, 17)
        Me.LabTaille.TabIndex = 12
        Me.LabTaille.Text = "Taille : 9 - 24"
        Me.LabTaille.Visible = False
        '
        'LabMines
        '
        Me.LabMines.AutoSize = True
        Me.LabMines.ForeColor = System.Drawing.Color.Red
        Me.LabMines.Location = New System.Drawing.Point(3, 164)
        Me.LabMines.Name = "LabMines"
        Me.LabMines.Size = New System.Drawing.Size(102, 17)
        Me.LabMines.TabIndex = 13
        Me.LabMines.Text = "Mines : 10 - 99"
        Me.LabMines.Visible = False
        '
        'PanPersonnalise
        '
        Me.PanPersonnalise.Controls.Add(Me.LabNbMines)
        Me.PanPersonnalise.Controls.Add(Me.LabTemps)
        Me.PanPersonnalise.Controls.Add(Me.LabSaisies)
        Me.PanPersonnalise.Controls.Add(Me.PanSaisies)
        Me.PanPersonnalise.Controls.Add(Me.LabTaille)
        Me.PanPersonnalise.Controls.Add(Me.ButPersonnalise)
        Me.PanPersonnalise.Controls.Add(Me.LabMines)
        Me.PanPersonnalise.Location = New System.Drawing.Point(10, 240)
        Me.PanPersonnalise.Name = "PanPersonnalise"
        Me.PanPersonnalise.Size = New System.Drawing.Size(260, 206)
        Me.PanPersonnalise.TabIndex = 14
        '
        'LabNbMines
        '
        Me.LabNbMines.AutoSize = True
        Me.LabNbMines.ForeColor = System.Drawing.Color.Red
        Me.LabNbMines.Location = New System.Drawing.Point(55, 144)
        Me.LabNbMines.Name = "LabNbMines"
        Me.LabNbMines.Size = New System.Drawing.Size(127, 17)
        Me.LabNbMines.TabIndex = 18
        Me.LabNbMines.Text = "Il y a trop de mines"
        Me.LabNbMines.Visible = False
        '
        'LabTemps
        '
        Me.LabTemps.AutoSize = True
        Me.LabTemps.ForeColor = System.Drawing.Color.Red
        Me.LabTemps.Location = New System.Drawing.Point(3, 184)
        Me.LabTemps.Name = "LabTemps"
        Me.LabTemps.Size = New System.Drawing.Size(108, 17)
        Me.LabTemps.TabIndex = 19
        Me.LabTemps.Text = "Temps 60 - 500"
        Me.LabTemps.Visible = False
        '
        'LabSaisies
        '
        Me.LabSaisies.AutoSize = True
        Me.LabSaisies.ForeColor = System.Drawing.Color.Red
        Me.LabSaisies.Location = New System.Drawing.Point(13, 144)
        Me.LabSaisies.Name = "LabSaisies"
        Me.LabSaisies.Size = New System.Drawing.Size(235, 17)
        Me.LabSaisies.TabIndex = 18
        Me.LabSaisies.Text = "Veuillez renseigner tous les champs"
        Me.LabSaisies.Visible = False
        '
        'PanSaisies
        '
        Me.PanSaisies.Controls.Add(Me.TxtSaisieTemps)
        Me.PanSaisies.Controls.Add(Me.TxtTemps)
        Me.PanSaisies.Controls.Add(Me.TxtSaisieMines)
        Me.PanSaisies.Controls.Add(Me.TxtMines)
        Me.PanSaisies.Controls.Add(Me.ButValider)
        Me.PanSaisies.Controls.Add(Me.TxtTaille)
        Me.PanSaisies.Controls.Add(Me.TxtSaisieTaille)
        Me.PanSaisies.Location = New System.Drawing.Point(2, 66)
        Me.PanSaisies.Name = "PanSaisies"
        Me.PanSaisies.Size = New System.Drawing.Size(264, 75)
        Me.PanSaisies.TabIndex = 14
        Me.PanSaisies.Visible = False
        '
        'TxtSaisieTemps
        '
        Me.TxtSaisieTemps.Location = New System.Drawing.Point(88, 48)
        Me.TxtSaisieTemps.Name = "TxtSaisieTemps"
        Me.TxtSaisieTemps.Size = New System.Drawing.Size(100, 22)
        Me.TxtSaisieTemps.TabIndex = 13
        '
        'TxtTemps
        '
        Me.TxtTemps.BackColor = System.Drawing.Color.Silver
        Me.TxtTemps.ForeColor = System.Drawing.Color.DarkViolet
        Me.TxtTemps.Location = New System.Drawing.Point(0, 48)
        Me.TxtTemps.Name = "TxtTemps"
        Me.TxtTemps.ReadOnly = True
        Me.TxtTemps.Size = New System.Drawing.Size(88, 22)
        Me.TxtTemps.TabIndex = 12
        Me.TxtTemps.Text = "Temps"
        Me.TxtTemps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanFacile
        '
        Me.PanFacile.Controls.Add(Me.LabFacile)
        Me.PanFacile.Controls.Add(Me.ButFacile)
        Me.PanFacile.Location = New System.Drawing.Point(5, 8)
        Me.PanFacile.Name = "PanFacile"
        Me.PanFacile.Size = New System.Drawing.Size(274, 80)
        Me.PanFacile.TabIndex = 15
        '
        'PanNormal
        '
        Me.PanNormal.Controls.Add(Me.LabNormal)
        Me.PanNormal.Controls.Add(Me.ButNormal)
        Me.PanNormal.Location = New System.Drawing.Point(9, 87)
        Me.PanNormal.Name = "PanNormal"
        Me.PanNormal.Size = New System.Drawing.Size(269, 78)
        Me.PanNormal.TabIndex = 16
        '
        'PanDifficile
        '
        Me.PanDifficile.Controls.Add(Me.LabDifficile)
        Me.PanDifficile.Controls.Add(Me.ButDifficile)
        Me.PanDifficile.Location = New System.Drawing.Point(10, 157)
        Me.PanDifficile.Name = "PanDifficile"
        Me.PanDifficile.Size = New System.Drawing.Size(267, 81)
        Me.PanDifficile.TabIndex = 17
        '
        'Difficulte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(282, 317)
        Me.Controls.Add(Me.PanDifficile)
        Me.Controls.Add(Me.PanNormal)
        Me.Controls.Add(Me.PanFacile)
        Me.Controls.Add(Me.PanPersonnalise)
        Me.Name = "Difficulte"
        Me.ShowIcon = False
        Me.Text = "Difficulte"
        Me.PanPersonnalise.ResumeLayout(False)
        Me.PanPersonnalise.PerformLayout()
        Me.PanSaisies.ResumeLayout(False)
        Me.PanSaisies.PerformLayout()
        Me.PanFacile.ResumeLayout(False)
        Me.PanFacile.PerformLayout()
        Me.PanNormal.ResumeLayout(False)
        Me.PanNormal.PerformLayout()
        Me.PanDifficile.ResumeLayout(False)
        Me.PanDifficile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButFacile As Button
    Friend WithEvents ButNormal As Button
    Friend WithEvents ButDifficile As Button
    Friend WithEvents LabFacile As Label
    Friend WithEvents LabNormal As Label
    Friend WithEvents LabDifficile As Label
    Friend WithEvents ButPersonnalise As Button
    Friend WithEvents TxtSaisieTaille As TextBox
    Friend WithEvents TxtTaille As TextBox
    Friend WithEvents ButValider As Button
    Friend WithEvents TxtMines As TextBox
    Friend WithEvents TxtSaisieMines As TextBox
    Friend WithEvents LabTaille As Label
    Friend WithEvents LabMines As Label
    Friend WithEvents PanPersonnalise As Panel
    Friend WithEvents PanFacile As Panel
    Friend WithEvents PanNormal As Panel
    Friend WithEvents PanDifficile As Panel
    Friend WithEvents PanSaisies As Panel
    Friend WithEvents LabSaisies As Label
    Friend WithEvents LabNbMines As Label
    Friend WithEvents TxtSaisieTemps As TextBox
    Friend WithEvents TxtTemps As TextBox
    Friend WithEvents LabTemps As Label
End Class
