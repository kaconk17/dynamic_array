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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cari = New System.Windows.Forms.TextBox()
        Me.btn_search_req = New System.Windows.Forms.Button()
        Me.btn_refresh_po = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(39, 130)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(388, 236)
        Me.ListBox1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(26, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nama"
        '
        'txt_nama
        '
        Me.txt_nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nama.Location = New System.Drawing.Point(71, 12)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(133, 20)
        Me.txt_nama.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(36, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cari"
        '
        'txt_cari
        '
        Me.txt_cari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cari.Location = New System.Drawing.Point(71, 104)
        Me.txt_cari.Name = "txt_cari"
        Me.txt_cari.Size = New System.Drawing.Size(129, 20)
        Me.txt_cari.TabIndex = 12
        '
        'btn_search_req
        '
        Me.btn_search_req.BackColor = System.Drawing.Color.Transparent
        Me.btn_search_req.BackgroundImage = CType(resources.GetObject("btn_search_req.BackgroundImage"), System.Drawing.Image)
        Me.btn_search_req.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_search_req.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window
        Me.btn_search_req.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_req.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_search_req.Location = New System.Drawing.Point(206, 101)
        Me.btn_search_req.Name = "btn_search_req"
        Me.btn_search_req.Size = New System.Drawing.Size(26, 23)
        Me.btn_search_req.TabIndex = 24
        Me.btn_search_req.UseVisualStyleBackColor = False
        '
        'btn_refresh_po
        '
        Me.btn_refresh_po.BackgroundImage = CType(resources.GetObject("btn_refresh_po.BackgroundImage"), System.Drawing.Image)
        Me.btn_refresh_po.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_refresh_po.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_refresh_po.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh_po.Location = New System.Drawing.Point(250, 96)
        Me.btn_refresh_po.Name = "btn_refresh_po"
        Me.btn_refresh_po.Size = New System.Drawing.Size(33, 33)
        Me.btn_refresh_po.TabIndex = 25
        Me.btn_refresh_po.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.BackgroundImage = CType(resources.GetObject("btn_save.BackgroundImage"), System.Drawing.Image)
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.Transparent
        Me.btn_save.Location = New System.Drawing.Point(226, 7)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(30, 28)
        Me.btn_save.TabIndex = 26
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(465, 413)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_refresh_po)
        Me.Controls.Add(Me.btn_search_req)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cari)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cari As TextBox
    Friend WithEvents btn_search_req As Button
    Friend WithEvents btn_refresh_po As Button
    Friend WithEvents btn_save As Button
End Class
