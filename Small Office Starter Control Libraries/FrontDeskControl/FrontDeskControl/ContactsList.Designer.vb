<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactsList
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
        Me.ContactsList_Close = New System.Windows.Forms.Button()
        Me.ContactsList_Label = New System.Windows.Forms.Label()
        Me.ContactsList_Body = New System.Windows.Forms.RichTextBox()
        Me.ContactsList_Search = New System.Windows.Forms.TextBox()
        Me.ContactsList_Search_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ContactsList_Close
        '
        Me.ContactsList_Close.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ContactsList_Close.Location = New System.Drawing.Point(260, 407)
        Me.ContactsList_Close.Name = "ContactsList_Close"
        Me.ContactsList_Close.Size = New System.Drawing.Size(111, 36)
        Me.ContactsList_Close.TabIndex = 5
        Me.ContactsList_Close.Text = "Close"
        Me.ContactsList_Close.UseVisualStyleBackColor = False
        '
        'ContactsList_Label
        '
        Me.ContactsList_Label.AutoSize = True
        Me.ContactsList_Label.Location = New System.Drawing.Point(12, 19)
        Me.ContactsList_Label.Name = "ContactsList_Label"
        Me.ContactsList_Label.Size = New System.Drawing.Size(89, 17)
        Me.ContactsList_Label.TabIndex = 4
        Me.ContactsList_Label.Text = "Contacts List"
        '
        'ContactsList_Body
        '
        Me.ContactsList_Body.Location = New System.Drawing.Point(15, 112)
        Me.ContactsList_Body.Name = "ContactsList_Body"
        Me.ContactsList_Body.ReadOnly = True
        Me.ContactsList_Body.Size = New System.Drawing.Size(616, 289)
        Me.ContactsList_Body.TabIndex = 3
        Me.ContactsList_Body.Text = ""
        '
        'ContactsList_Search
        '
        Me.ContactsList_Search.Location = New System.Drawing.Point(15, 65)
        Me.ContactsList_Search.Name = "ContactsList_Search"
        Me.ContactsList_Search.Size = New System.Drawing.Size(472, 22)
        Me.ContactsList_Search.TabIndex = 6
        '
        'ContactsList_Search_Button
        '
        Me.ContactsList_Search_Button.Location = New System.Drawing.Point(512, 64)
        Me.ContactsList_Search_Button.Name = "ContactsList_Search_Button"
        Me.ContactsList_Search_Button.Size = New System.Drawing.Size(119, 23)
        Me.ContactsList_Search_Button.TabIndex = 7
        Me.ContactsList_Search_Button.Text = "Search"
        Me.ContactsList_Search_Button.UseVisualStyleBackColor = True
        '
        'ContactsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 450)
        Me.Controls.Add(Me.ContactsList_Search_Button)
        Me.Controls.Add(Me.ContactsList_Search)
        Me.Controls.Add(Me.ContactsList_Close)
        Me.Controls.Add(Me.ContactsList_Label)
        Me.Controls.Add(Me.ContactsList_Body)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ContactsList"
        Me.Text = "ContactsList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContactsList_Close As Button
    Friend WithEvents ContactsList_Label As Label
    Friend WithEvents ContactsList_Body As RichTextBox
    Friend WithEvents ContactsList_Search As TextBox
    Friend WithEvents ContactsList_Search_Button As Button
End Class
