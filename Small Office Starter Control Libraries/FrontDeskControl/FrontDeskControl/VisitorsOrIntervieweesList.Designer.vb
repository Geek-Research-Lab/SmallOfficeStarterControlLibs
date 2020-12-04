<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitorsOrIntervieweesList
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
        Me.VisitInterviewList_Close = New System.Windows.Forms.Button()
        Me.VisitInterviewList_Label = New System.Windows.Forms.Label()
        Me.VisitInterviewList_Body = New System.Windows.Forms.RichTextBox()
        Me.VisitInterviewType = New System.Windows.Forms.ComboBox()
        Me.VisitInterviewType_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'VisitInterviewList_Close
        '
        Me.VisitInterviewList_Close.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.VisitInterviewList_Close.Location = New System.Drawing.Point(307, 414)
        Me.VisitInterviewList_Close.Name = "VisitInterviewList_Close"
        Me.VisitInterviewList_Close.Size = New System.Drawing.Size(111, 36)
        Me.VisitInterviewList_Close.TabIndex = 5
        Me.VisitInterviewList_Close.Text = "Close"
        Me.VisitInterviewList_Close.UseVisualStyleBackColor = False
        '
        'VisitInterviewList_Label
        '
        Me.VisitInterviewList_Label.AutoSize = True
        Me.VisitInterviewList_Label.Location = New System.Drawing.Point(26, 18)
        Me.VisitInterviewList_Label.Name = "VisitInterviewList_Label"
        Me.VisitInterviewList_Label.Size = New System.Drawing.Size(170, 17)
        Me.VisitInterviewList_Label.TabIndex = 4
        Me.VisitInterviewList_Label.Text = "Visitors / Interviewees List"
        '
        'VisitInterviewList_Body
        '
        Me.VisitInterviewList_Body.Location = New System.Drawing.Point(29, 119)
        Me.VisitInterviewList_Body.Name = "VisitInterviewList_Body"
        Me.VisitInterviewList_Body.ReadOnly = True
        Me.VisitInterviewList_Body.Size = New System.Drawing.Size(672, 277)
        Me.VisitInterviewList_Body.TabIndex = 3
        Me.VisitInterviewList_Body.Text = ""
        '
        'VisitInterviewType
        '
        Me.VisitInterviewType.FormattingEnabled = True
        Me.VisitInterviewType.Items.AddRange(New Object() {"Visitors", "Interviewees"})
        Me.VisitInterviewType.Location = New System.Drawing.Point(158, 71)
        Me.VisitInterviewType.Name = "VisitInterviewType"
        Me.VisitInterviewType.Size = New System.Drawing.Size(162, 24)
        Me.VisitInterviewType.TabIndex = 6
        '
        'VisitInterviewType_Label
        '
        Me.VisitInterviewType_Label.AutoSize = True
        Me.VisitInterviewType_Label.Location = New System.Drawing.Point(26, 74)
        Me.VisitInterviewType_Label.Name = "VisitInterviewType_Label"
        Me.VisitInterviewType_Label.Size = New System.Drawing.Size(40, 17)
        Me.VisitInterviewType_Label.TabIndex = 7
        Me.VisitInterviewType_Label.Text = "Type"
        '
        'VisitorsOrIntervieweesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.VisitInterviewType_Label)
        Me.Controls.Add(Me.VisitInterviewType)
        Me.Controls.Add(Me.VisitInterviewList_Close)
        Me.Controls.Add(Me.VisitInterviewList_Label)
        Me.Controls.Add(Me.VisitInterviewList_Body)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VisitorsOrIntervieweesList"
        Me.Text = "VisitorsOrIntervieweesList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VisitInterviewList_Close As Button
    Friend WithEvents VisitInterviewList_Label As Label
    Friend WithEvents VisitInterviewList_Body As RichTextBox
    Friend WithEvents VisitInterviewType As ComboBox
    Friend WithEvents VisitInterviewType_Label As Label
End Class
