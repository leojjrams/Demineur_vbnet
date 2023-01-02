<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jeu
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
        Me.components = New System.ComponentModel.Container()
        Me.Map = New System.Windows.Forms.Panel()
        Me.ButAbandonner = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.LabJoueur = New System.Windows.Forms.Label()
        Me.LabTemps = New System.Windows.Forms.Label()
        Me.LabNbMines = New System.Windows.Forms.Label()
        Me.ButPause = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Map
        '
        Me.Map.BackColor = System.Drawing.Color.Silver
        Me.Map.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Map.Location = New System.Drawing.Point(12, 98)
        Me.Map.Name = "Map"
        Me.Map.Size = New System.Drawing.Size(432, 432)
        Me.Map.TabIndex = 0
        '
        'ButAbandonner
        '
        Me.ButAbandonner.Location = New System.Drawing.Point(167, 530)
        Me.ButAbandonner.Name = "ButAbandonner"
        Me.ButAbandonner.Size = New System.Drawing.Size(140, 36)
        Me.ButAbandonner.TabIndex = 1
        Me.ButAbandonner.Text = "Abandonner"
        Me.ButAbandonner.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'LabJoueur
        '
        Me.LabJoueur.AutoSize = True
        Me.LabJoueur.ForeColor = System.Drawing.Color.DimGray
        Me.LabJoueur.Location = New System.Drawing.Point(12, 18)
        Me.LabJoueur.Name = "LabJoueur"
        Me.LabJoueur.Size = New System.Drawing.Size(76, 17)
        Me.LabJoueur.TabIndex = 2
        Me.LabJoueur.Text = "LabJoueur"
        '
        'LabTemps
        '
        Me.LabTemps.BackColor = System.Drawing.Color.DarkRed
        Me.LabTemps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabTemps.ForeColor = System.Drawing.Color.Red
        Me.LabTemps.Location = New System.Drawing.Point(257, 45)
        Me.LabTemps.Name = "LabTemps"
        Me.LabTemps.Size = New System.Drawing.Size(183, 50)
        Me.LabTemps.TabIndex = 3
        Me.LabTemps.Text = "Temps"
        Me.LabTemps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabNbMines
        '
        Me.LabNbMines.BackColor = System.Drawing.Color.DarkRed
        Me.LabNbMines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabNbMines.ForeColor = System.Drawing.Color.Red
        Me.LabNbMines.Location = New System.Drawing.Point(12, 45)
        Me.LabNbMines.Name = "LabNbMines"
        Me.LabNbMines.Size = New System.Drawing.Size(183, 50)
        Me.LabNbMines.TabIndex = 4
        Me.LabNbMines.Text = "nbMines"
        Me.LabNbMines.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButPause
        '
        Me.ButPause.Location = New System.Drawing.Point(201, 45)
        Me.ButPause.Name = "ButPause"
        Me.ButPause.Size = New System.Drawing.Size(50, 50)
        Me.ButPause.TabIndex = 5
        Me.ButPause.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(150, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mines"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(254, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Temps"
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(456, 617)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButPause)
        Me.Controls.Add(Me.LabJoueur)
        Me.Controls.Add(Me.LabNbMines)
        Me.Controls.Add(Me.LabTemps)
        Me.Controls.Add(Me.ButAbandonner)
        Me.Controls.Add(Me.Map)
        Me.Name = "Jeu"
        Me.ShowIcon = False
        Me.Text = "Jeu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Map As Panel
    Friend WithEvents ButAbandonner As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents LabJoueur As Label
    Friend WithEvents LabTemps As Label
    Friend WithEvents LabNbMines As Label
    Friend WithEvents ButPause As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
