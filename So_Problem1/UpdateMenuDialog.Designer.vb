<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateMenuDialog
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bttnClose = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.txtMenuStatus = New System.Windows.Forms.TextBox()
        Me.txtMenuPrice = New System.Windows.Forms.TextBox()
        Me.txtMenuDescription = New System.Windows.Forms.TextBox()
        Me.txtMenuName = New System.Windows.Forms.TextBox()
        Me.txtMenuID = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(15, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "EDIT MENU"
        '
        'bttnClose
        '
        Me.bttnClose.BackColor = System.Drawing.Color.Transparent
        Me.bttnClose.FlatAppearance.BorderSize = 0
        Me.bttnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bttnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.bttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnClose.ForeColor = System.Drawing.Color.White
        Me.bttnClose.Location = New System.Drawing.Point(350, 4)
        Me.bttnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.bttnClose.Name = "bttnClose"
        Me.bttnClose.Size = New System.Drawing.Size(28, 32)
        Me.bttnClose.TabIndex = 22
        Me.bttnClose.Text = "x"
        Me.bttnClose.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbxCategory)
        Me.GroupBox2.Controls.Add(Me.txtMenuStatus)
        Me.GroupBox2.Controls.Add(Me.txtMenuPrice)
        Me.GroupBox2.Controls.Add(Me.txtMenuDescription)
        Me.GroupBox2.Controls.Add(Me.txtMenuName)
        Me.GroupBox2.Controls.Add(Me.txtMenuID)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(11, 55)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(363, 241)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(228, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(228, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(13, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(13, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(13, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(13, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "ID"
        '
        'cbxCategory
        '
        Me.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Location = New System.Drawing.Point(69, 92)
        Me.cbxCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(140, 21)
        Me.cbxCategory.TabIndex = 16
        '
        'txtMenuStatus
        '
        Me.txtMenuStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMenuStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtMenuStatus.Location = New System.Drawing.Point(276, 63)
        Me.txtMenuStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMenuStatus.Multiline = True
        Me.txtMenuStatus.Name = "txtMenuStatus"
        Me.txtMenuStatus.Size = New System.Drawing.Size(71, 18)
        Me.txtMenuStatus.TabIndex = 11
        Me.txtMenuStatus.Text = "Yes"
        '
        'txtMenuPrice
        '
        Me.txtMenuPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMenuPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtMenuPrice.Location = New System.Drawing.Point(276, 32)
        Me.txtMenuPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMenuPrice.Multiline = True
        Me.txtMenuPrice.Name = "txtMenuPrice"
        Me.txtMenuPrice.Size = New System.Drawing.Size(71, 18)
        Me.txtMenuPrice.TabIndex = 7
        '
        'txtMenuDescription
        '
        Me.txtMenuDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMenuDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtMenuDescription.Location = New System.Drawing.Point(16, 148)
        Me.txtMenuDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMenuDescription.Multiline = True
        Me.txtMenuDescription.Name = "txtMenuDescription"
        Me.txtMenuDescription.Size = New System.Drawing.Size(331, 71)
        Me.txtMenuDescription.TabIndex = 5
        '
        'txtMenuName
        '
        Me.txtMenuName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMenuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtMenuName.Location = New System.Drawing.Point(69, 63)
        Me.txtMenuName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMenuName.Multiline = True
        Me.txtMenuName.Name = "txtMenuName"
        Me.txtMenuName.Size = New System.Drawing.Size(140, 18)
        Me.txtMenuName.TabIndex = 3
        '
        'txtMenuID
        '
        Me.txtMenuID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMenuID.Enabled = False
        Me.txtMenuID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.txtMenuID.Location = New System.Drawing.Point(69, 33)
        Me.txtMenuID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMenuID.Multiline = True
        Me.txtMenuID.Name = "txtMenuID"
        Me.txtMenuID.Size = New System.Drawing.Size(140, 18)
        Me.txtMenuID.TabIndex = 1
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Tomato
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(196, 302)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(178, 38)
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCancel.Location = New System.Drawing.Point(11, 302)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(178, 38)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'UpdateMenuDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(386, 362)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.bttnClose)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateMenuDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateMenuDialog"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents bttnClose As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents txtMenuStatus As TextBox
    Friend WithEvents txtMenuPrice As TextBox
    Friend WithEvents txtMenuDescription As TextBox
    Friend WithEvents txtMenuName As TextBox
    Friend WithEvents txtMenuID As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
End Class
