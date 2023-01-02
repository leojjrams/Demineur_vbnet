<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
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
        Me.LstNoms = New System.Windows.Forms.ListBox()
        Me.ButRetour = New System.Windows.Forms.Button()
        Me.LstRecord = New System.Windows.Forms.ListBox()
        Me.LstTemps = New System.Windows.Forms.ListBox()
        Me.LabNom = New System.Windows.Forms.Label()
        Me.LabRecord = New System.Windows.Forms.Label()
        Me.LabTemps = New System.Windows.Forms.Label()
        Me.CmbNoms = New System.Windows.Forms.ComboBox()
        Me.ButDetails = New System.Windows.Forms.Button()
        Me.ButInverser = New System.Windows.Forms.Button()
        Me.ButSuppr = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstNoms
        '
        Me.LstNoms.FormattingEnabled = True
        Me.LstNoms.ItemHeight = 16
        Me.LstNoms.Location = New System.Drawing.Point(120, 48)
        Me.LstNoms.Margin = New System.Windows.Forms.Padding(0)
        Me.LstNoms.Name = "LstNoms"
        Me.LstNoms.Size = New System.Drawing.Size(118, 308)
        Me.LstNoms.TabIndex = 0
        '
        'ButRetour
        '
        Me.ButRetour.Location = New System.Drawing.Point(210, 384)
        Me.ButRetour.Name = "ButRetour"
        Me.ButRetour.Size = New System.Drawing.Size(100, 36)
        Me.ButRetour.TabIndex = 1
        Me.ButRetour.Text = "Retour"
        Me.ButRetour.UseVisualStyleBackColor = True
        '
        'LstRecord
        '
        Me.LstRecord.FormattingEnabled = True
        Me.LstRecord.ItemHeight = 16
        Me.LstRecord.Location = New System.Drawing.Point(238, 48)
        Me.LstRecord.Margin = New System.Windows.Forms.Padding(0)
        Me.LstRecord.Name = "LstRecord"
        Me.LstRecord.Size = New System.Drawing.Size(118, 308)
        Me.LstRecord.TabIndex = 2
        '
        'LstTemps
        '
        Me.LstTemps.FormattingEnabled = True
        Me.LstTemps.ItemHeight = 16
        Me.LstTemps.Location = New System.Drawing.Point(356, 48)
        Me.LstTemps.Margin = New System.Windows.Forms.Padding(0)
        Me.LstTemps.Name = "LstTemps"
        Me.LstTemps.Size = New System.Drawing.Size(118, 308)
        Me.LstTemps.TabIndex = 3
        '
        'LabNom
        '
        Me.LabNom.AutoSize = True
        Me.LabNom.BackColor = System.Drawing.Color.Transparent
        Me.LabNom.ForeColor = System.Drawing.Color.Black
        Me.LabNom.Location = New System.Drawing.Point(163, 18)
        Me.LabNom.Name = "LabNom"
        Me.LabNom.Size = New System.Drawing.Size(40, 17)
        Me.LabNom.TabIndex = 4
        Me.LabNom.Text = "NOM"
        '
        'LabRecord
        '
        Me.LabRecord.AutoSize = True
        Me.LabRecord.BackColor = System.Drawing.Color.Transparent
        Me.LabRecord.ForeColor = System.Drawing.Color.Black
        Me.LabRecord.Location = New System.Drawing.Point(263, 18)
        Me.LabRecord.Name = "LabRecord"
        Me.LabRecord.Size = New System.Drawing.Size(67, 17)
        Me.LabRecord.TabIndex = 5
        Me.LabRecord.Text = "RECORD"
        '
        'LabTemps
        '
        Me.LabTemps.AutoSize = True
        Me.LabTemps.BackColor = System.Drawing.Color.Transparent
        Me.LabTemps.ForeColor = System.Drawing.Color.Black
        Me.LabTemps.Location = New System.Drawing.Point(382, 18)
        Me.LabTemps.Name = "LabTemps"
        Me.LabTemps.Size = New System.Drawing.Size(55, 17)
        Me.LabTemps.TabIndex = 6
        Me.LabTemps.Text = "TEMPS"
        '
        'CmbNoms
        '
        Me.CmbNoms.FormattingEnabled = True
        Me.CmbNoms.Location = New System.Drawing.Point(12, 48)
        Me.CmbNoms.Name = "CmbNoms"
        Me.CmbNoms.Size = New System.Drawing.Size(107, 24)
        Me.CmbNoms.TabIndex = 7
        '
        'ButDetails
        '
        Me.ButDetails.Location = New System.Drawing.Point(71, 384)
        Me.ButDetails.Name = "ButDetails"
        Me.ButDetails.Size = New System.Drawing.Size(100, 36)
        Me.ButDetails.TabIndex = 8
        Me.ButDetails.Text = "Détails"
        Me.ButDetails.UseVisualStyleBackColor = True
        '
        'ButInverser
        '
        Me.ButInverser.Location = New System.Drawing.Point(344, 384)
        Me.ButInverser.Name = "ButInverser"
        Me.ButInverser.Size = New System.Drawing.Size(36, 36)
        Me.ButInverser.TabIndex = 9
        Me.ButInverser.UseVisualStyleBackColor = True
        '
        'ButSuppr
        '
        Me.ButSuppr.Location = New System.Drawing.Point(410, 384)
        Me.ButSuppr.Name = "ButSuppr"
        Me.ButSuppr.Size = New System.Drawing.Size(36, 36)
        Me.ButSuppr.TabIndex = 10
        Me.ButSuppr.UseVisualStyleBackColor = True
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(502, 453)
        Me.Controls.Add(Me.ButSuppr)
        Me.Controls.Add(Me.ButInverser)
        Me.Controls.Add(Me.ButDetails)
        Me.Controls.Add(Me.CmbNoms)
        Me.Controls.Add(Me.LabTemps)
        Me.Controls.Add(Me.LabRecord)
        Me.Controls.Add(Me.LabNom)
        Me.Controls.Add(Me.LstTemps)
        Me.Controls.Add(Me.LstRecord)
        Me.Controls.Add(Me.ButRetour)
        Me.Controls.Add(Me.LstNoms)
        Me.Name = "Scores"
        Me.ShowIcon = False
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstNoms As ListBox
    Friend WithEvents ButRetour As Button
    Friend WithEvents LstRecord As ListBox
    Friend WithEvents LstTemps As ListBox
    Friend WithEvents LabNom As Label
    Friend WithEvents LabRecord As Label
    Friend WithEvents LabTemps As Label
    Friend WithEvents CmbNoms As ComboBox
    Friend WithEvents ButDetails As Button
    Friend WithEvents ButInverser As Button
    Friend WithEvents ButSuppr As Button
End Class
