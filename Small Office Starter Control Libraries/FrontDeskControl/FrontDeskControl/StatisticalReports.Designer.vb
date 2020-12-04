<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatisticalReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ReportsType_Label = New System.Windows.Forms.Label()
        Me.Reports_Type = New System.Windows.Forms.ComboBox()
        Me.Reports_Close = New System.Windows.Forms.Button()
        Me.ReportsList_Label = New System.Windows.Forms.Label()
        Me.Reports_Body = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'ReportsType_Label
        '
        Me.ReportsType_Label.AutoSize = True
        Me.ReportsType_Label.Location = New System.Drawing.Point(18, 65)
        Me.ReportsType_Label.Name = "ReportsType_Label"
        Me.ReportsType_Label.Size = New System.Drawing.Size(40, 17)
        Me.ReportsType_Label.TabIndex = 12
        Me.ReportsType_Label.Text = "Type"
        '
        'Reports_Type
        '
        Me.Reports_Type.FormattingEnabled = True
        Me.Reports_Type.Items.AddRange(New Object() {"Visitors", "Interviewees"})
        Me.Reports_Type.Location = New System.Drawing.Point(150, 62)
        Me.Reports_Type.Name = "Reports_Type"
        Me.Reports_Type.Size = New System.Drawing.Size(162, 24)
        Me.Reports_Type.TabIndex = 11
        '
        'Reports_Close
        '
        Me.Reports_Close.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Reports_Close.Location = New System.Drawing.Point(299, 405)
        Me.Reports_Close.Name = "Reports_Close"
        Me.Reports_Close.Size = New System.Drawing.Size(111, 36)
        Me.Reports_Close.TabIndex = 10
        Me.Reports_Close.Text = "Close"
        Me.Reports_Close.UseVisualStyleBackColor = False
        '
        'ReportsList_Label
        '
        Me.ReportsList_Label.AutoSize = True
        Me.ReportsList_Label.Location = New System.Drawing.Point(18, 9)
        Me.ReportsList_Label.Name = "ReportsList_Label"
        Me.ReportsList_Label.Size = New System.Drawing.Size(122, 17)
        Me.ReportsList_Label.TabIndex = 9
        Me.ReportsList_Label.Text = "Statistical Reports"
        '
        'Reports_Body
        '
        Me.Reports_Body.Location = New System.Drawing.Point(21, 110)
        Me.Reports_Body.Name = "Reports_Body"
        Me.Reports_Body.ReadOnly = True
        Me.Reports_Body.Size = New System.Drawing.Size(672, 277)
        Me.Reports_Body.TabIndex = 8
        Me.Reports_Body.Text = ""
        '
        'StatisticalReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportsType_Label)
        Me.Controls.Add(Me.Reports_Type)
        Me.Controls.Add(Me.Reports_Close)
        Me.Controls.Add(Me.ReportsList_Label)
        Me.Controls.Add(Me.Reports_Body)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StatisticalReports"
        Me.Text = "StatisticalReports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportsType_Label As Label
    Friend WithEvents Reports_Type As ComboBox
    Friend WithEvents Reports_Close As Button
    Friend WithEvents ReportsList_Label As Label
    Friend WithEvents Reports_Body As RichTextBox
End Class
