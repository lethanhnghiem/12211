<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtMasp = New System.Windows.Forms.TextBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.txtTenSp = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMasp
        '
        Me.txtMasp.Location = New System.Drawing.Point(123, 37)
        Me.txtMasp.Name = "txtMasp"
        Me.txtMasp.Size = New System.Drawing.Size(100, 20)
        Me.txtMasp.TabIndex = 0
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(298, 37)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(100, 20)
        Me.txtSoluong.TabIndex = 1
        '
        'txtTenSp
        '
        Me.txtTenSp.Location = New System.Drawing.Point(123, 80)
        Me.txtTenSp.Name = "txtTenSp"
        Me.txtTenSp.Size = New System.Drawing.Size(100, 20)
        Me.txtTenSp.TabIndex = 1
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(298, 89)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(100, 20)
        Me.txtDonGia.TabIndex = 1
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(456, 19)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 54)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "them"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(456, 89)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 54)
        Me.btnsua.TabIndex = 2
        Me.btnsua.Text = "sua"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(576, 19)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 54)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "xoa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Location = New System.Drawing.Point(576, 89)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 54)
        Me.btnLuu.TabIndex = 2
        Me.btnLuu.Text = "luu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 190)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(696, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 352)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtTenSp)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtSoluong)
        Me.Controls.Add(Me.txtMasp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMasp As System.Windows.Forms.TextBox
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSp As System.Windows.Forms.TextBox
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
