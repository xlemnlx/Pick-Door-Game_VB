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
        Me.label_pickadoor = New System.Windows.Forms.Label()
        Me.button_left = New System.Windows.Forms.Button()
        Me.button_right = New System.Windows.Forms.Button()
        Me.label_name = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.picture_left = New System.Windows.Forms.PictureBox()
        Me.picture_right = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picture_left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picture_right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_pickadoor
        '
        Me.label_pickadoor.AutoSize = True
        Me.label_pickadoor.BackColor = System.Drawing.Color.Transparent
        Me.label_pickadoor.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_pickadoor.Location = New System.Drawing.Point(448, 9)
        Me.label_pickadoor.Name = "label_pickadoor"
        Me.label_pickadoor.Size = New System.Drawing.Size(370, 42)
        Me.label_pickadoor.TabIndex = 0
        Me.label_pickadoor.Text = "Pick Your Door Wisely"
        '
        'button_left
        '
        Me.button_left.BackColor = System.Drawing.SystemColors.Window
        Me.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button_left.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_left.Location = New System.Drawing.Point(88, 612)
        Me.button_left.Name = "button_left"
        Me.button_left.Size = New System.Drawing.Size(156, 42)
        Me.button_left.TabIndex = 3
        Me.button_left.Text = "Left Door"
        Me.button_left.UseVisualStyleBackColor = False
        '
        'button_right
        '
        Me.button_right.BackColor = System.Drawing.SystemColors.Window
        Me.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button_right.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_right.Location = New System.Drawing.Point(1015, 612)
        Me.button_right.Name = "button_right"
        Me.button_right.Size = New System.Drawing.Size(156, 42)
        Me.button_right.TabIndex = 4
        Me.button_right.Text = "Right Door"
        Me.button_right.UseVisualStyleBackColor = False
        '
        'label_name
        '
        Me.label_name.AutoSize = True
        Me.label_name.BackColor = System.Drawing.Color.Transparent
        Me.label_name.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.Location = New System.Drawing.Point(568, 222)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(126, 24)
        Me.label_name.TabIndex = 5
        Me.label_name.Text = "Type a Name"
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(537, 249)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(190, 41)
        Me.txt_name.TabIndex = 6
        '
        'picture_left
        '
        Me.picture_left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picture_left.Image = CType(resources.GetObject("picture_left.Image"), System.Drawing.Image)
        Me.picture_left.Location = New System.Drawing.Point(12, 63)
        Me.picture_left.Name = "picture_left"
        Me.picture_left.Size = New System.Drawing.Size(328, 543)
        Me.picture_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture_left.TabIndex = 7
        Me.picture_left.TabStop = False
        '
        'picture_right
        '
        Me.picture_right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picture_right.Image = CType(resources.GetObject("picture_right.Image"), System.Drawing.Image)
        Me.picture_right.Location = New System.Drawing.Point(924, 63)
        Me.picture_right.Name = "picture_right"
        Me.picture_right.Size = New System.Drawing.Size(328, 543)
        Me.picture_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picture_right.TabIndex = 8
        Me.picture_right.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(572, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 42)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "AGAIN!!!!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picture_right)
        Me.Controls.Add(Me.picture_left)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.label_name)
        Me.Controls.Add(Me.button_right)
        Me.Controls.Add(Me.button_left)
        Me.Controls.Add(Me.label_pickadoor)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Dog or Puppy"
        CType(Me.picture_left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picture_right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_pickadoor As System.Windows.Forms.Label
    Friend WithEvents button_left As System.Windows.Forms.Button
    Friend WithEvents button_right As System.Windows.Forms.Button
    Friend WithEvents label_name As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents picture_left As System.Windows.Forms.PictureBox
    Friend WithEvents picture_right As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
