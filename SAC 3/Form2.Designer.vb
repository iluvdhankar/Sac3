<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategorypage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategorypage))
        Me.btnLaptops = New System.Windows.Forms.Button()
        Me.btnPhone = New System.Windows.Forms.Button()
        Me.btnTablet = New System.Windows.Forms.Button()
        Me.btnOther = New System.Windows.Forms.Button()
        Me.PicBoxcategoryHome = New System.Windows.Forms.PictureBox()
        Me.lbltitlecategory = New System.Windows.Forms.Label()
        Me.PicBoxdetailsCategory = New System.Windows.Forms.PictureBox()
        CType(Me.PicBoxcategoryHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBoxdetailsCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLaptops
        '
        Me.btnLaptops.BackColor = System.Drawing.Color.White
        Me.btnLaptops.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaptops.Location = New System.Drawing.Point(252, 200)
        Me.btnLaptops.Name = "btnLaptops"
        Me.btnLaptops.Size = New System.Drawing.Size(244, 139)
        Me.btnLaptops.TabIndex = 5
        Me.btnLaptops.Text = "Laptops"
        Me.btnLaptops.UseVisualStyleBackColor = False
        '
        'btnPhone
        '
        Me.btnPhone.BackColor = System.Drawing.Color.White
        Me.btnPhone.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhone.Location = New System.Drawing.Point(889, 200)
        Me.btnPhone.Name = "btnPhone"
        Me.btnPhone.Size = New System.Drawing.Size(245, 139)
        Me.btnPhone.TabIndex = 7
        Me.btnPhone.Text = "Phones"
        Me.btnPhone.UseVisualStyleBackColor = False
        '
        'btnTablet
        '
        Me.btnTablet.BackColor = System.Drawing.Color.White
        Me.btnTablet.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTablet.Location = New System.Drawing.Point(252, 487)
        Me.btnTablet.Name = "btnTablet"
        Me.btnTablet.Size = New System.Drawing.Size(244, 139)
        Me.btnTablet.TabIndex = 8
        Me.btnTablet.Text = "Tablet"
        Me.btnTablet.UseVisualStyleBackColor = False
        '
        'btnOther
        '
        Me.btnOther.BackColor = System.Drawing.Color.White
        Me.btnOther.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOther.Location = New System.Drawing.Point(889, 487)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(245, 139)
        Me.btnOther.TabIndex = 9
        Me.btnOther.Text = "Other"
        Me.btnOther.UseVisualStyleBackColor = False
        '
        'PicBoxcategoryHome
        '
        Me.PicBoxcategoryHome.BackColor = System.Drawing.Color.Transparent
        Me.PicBoxcategoryHome.Image = CType(resources.GetObject("PicBoxcategoryHome.Image"), System.Drawing.Image)
        Me.PicBoxcategoryHome.Location = New System.Drawing.Point(7, 7)
        Me.PicBoxcategoryHome.Name = "PicBoxcategoryHome"
        Me.PicBoxcategoryHome.Size = New System.Drawing.Size(50, 50)
        Me.PicBoxcategoryHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicBoxcategoryHome.TabIndex = 16
        Me.PicBoxcategoryHome.TabStop = False
        '
        'lbltitlecategory
        '
        Me.lbltitlecategory.AutoSize = True
        Me.lbltitlecategory.BackColor = System.Drawing.Color.White
        Me.lbltitlecategory.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitlecategory.Location = New System.Drawing.Point(60, 15)
        Me.lbltitlecategory.Name = "lbltitlecategory"
        Me.lbltitlecategory.Size = New System.Drawing.Size(237, 35)
        Me.lbltitlecategory.TabIndex = 15
        Me.lbltitlecategory.Text = "Gadget World"
        '
        'PicBoxdetailsCategory
        '
        Me.PicBoxdetailsCategory.Image = CType(resources.GetObject("PicBoxdetailsCategory.Image"), System.Drawing.Image)
        Me.PicBoxdetailsCategory.Location = New System.Drawing.Point(1415, 14)
        Me.PicBoxdetailsCategory.Name = "PicBoxdetailsCategory"
        Me.PicBoxdetailsCategory.Size = New System.Drawing.Size(50, 50)
        Me.PicBoxdetailsCategory.TabIndex = 33
        Me.PicBoxdetailsCategory.TabStop = False
        '
        'frmCategorypage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1480, 837)
        Me.Controls.Add(Me.PicBoxdetailsCategory)
        Me.Controls.Add(Me.PicBoxcategoryHome)
        Me.Controls.Add(Me.lbltitlecategory)
        Me.Controls.Add(Me.btnOther)
        Me.Controls.Add(Me.btnTablet)
        Me.Controls.Add(Me.btnPhone)
        Me.Controls.Add(Me.btnLaptops)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1496, 876)
        Me.Name = "frmCategorypage"
        Me.Text = "Gadget World"
        CType(Me.PicBoxcategoryHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBoxdetailsCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLaptops As Button
    Friend WithEvents btnPhone As Button
    Friend WithEvents btnTablet As Button
    Friend WithEvents btnOther As Button
    Friend WithEvents PicBoxcategoryHome As PictureBox
    Friend WithEvents lbltitlecategory As Label
    Friend WithEvents PicBoxdetailsCategory As PictureBox
End Class
