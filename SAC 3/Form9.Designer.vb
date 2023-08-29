<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAboutpage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAboutpage))
        Me.lblAboutinfo = New System.Windows.Forms.Label()
        Me.lblAbouttitle = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblAboutEmail = New System.Windows.Forms.Label()
        Me.lblAboutPhone = New System.Windows.Forms.Label()
        Me.btnBackAbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAboutinfo
        '
        Me.lblAboutinfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAboutinfo.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutinfo.Location = New System.Drawing.Point(14, 157)
        Me.lblAboutinfo.Name = "lblAboutinfo"
        Me.lblAboutinfo.Size = New System.Drawing.Size(1747, 393)
        Me.lblAboutinfo.TabIndex = 0
        Me.lblAboutinfo.Text = resources.GetString("lblAboutinfo.Text")
        '
        'lblAbouttitle
        '
        Me.lblAbouttitle.AutoSize = True
        Me.lblAbouttitle.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbouttitle.Location = New System.Drawing.Point(706, 25)
        Me.lblAbouttitle.Name = "lblAbouttitle"
        Me.lblAbouttitle.Size = New System.Drawing.Size(268, 59)
        Me.lblAbouttitle.TabIndex = 1
        Me.lblAbouttitle.Text = "About Us"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(13, 841)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(224, 38)
        Me.lblContact.TabIndex = 2
        Me.lblContact.Text = "Contact Us:"
        '
        'lblAboutEmail
        '
        Me.lblAboutEmail.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutEmail.Location = New System.Drawing.Point(242, 833)
        Me.lblAboutEmail.Name = "lblAboutEmail"
        Me.lblAboutEmail.Size = New System.Drawing.Size(564, 56)
        Me.lblAboutEmail.TabIndex = 3
        Me.lblAboutEmail.Text = "gadgetworldtech@gmail.com"
        '
        'lblAboutPhone
        '
        Me.lblAboutPhone.Font = New System.Drawing.Font("Verdana", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAboutPhone.Location = New System.Drawing.Point(1064, 824)
        Me.lblAboutPhone.Name = "lblAboutPhone"
        Me.lblAboutPhone.Size = New System.Drawing.Size(329, 56)
        Me.lblAboutPhone.TabIndex = 4
        Me.lblAboutPhone.Text = "(03) 9528 8297"
        '
        'btnBackAbout
        '
        Me.btnBackAbout.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackAbout.Location = New System.Drawing.Point(20, 25)
        Me.btnBackAbout.Name = "btnBackAbout"
        Me.btnBackAbout.Size = New System.Drawing.Size(241, 59)
        Me.btnBackAbout.TabIndex = 32
        Me.btnBackAbout.Text = "Back to Homepage"
        Me.btnBackAbout.UseVisualStyleBackColor = True
        '
        'frmAboutpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1771, 900)
        Me.Controls.Add(Me.btnBackAbout)
        Me.Controls.Add(Me.lblAboutPhone)
        Me.Controls.Add(Me.lblAboutEmail)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblAbouttitle)
        Me.Controls.Add(Me.lblAboutinfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAboutpage"
        Me.Text = "About Us"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAboutinfo As Label
    Friend WithEvents lblAbouttitle As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblAboutEmail As Label
    Friend WithEvents lblAboutPhone As Label
    Friend WithEvents btnBackAbout As Button
End Class
