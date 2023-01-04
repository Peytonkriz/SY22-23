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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BulletPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.WallPictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Player2 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.BulletPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10000
        '
        'BulletPictureBox2
        '
        Me.BulletPictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BulletPictureBox2.Image = Global.MyGame.My.Resources.Resources.download__11_
        Me.BulletPictureBox2.Location = New System.Drawing.Point(268, 171)
        Me.BulletPictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BulletPictureBox2.Name = "BulletPictureBox2"
        Me.BulletPictureBox2.Size = New System.Drawing.Size(30, 33)
        Me.BulletPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BulletPictureBox2.TabIndex = 8
        Me.BulletPictureBox2.TabStop = False
        Me.BulletPictureBox2.Visible = False
        '
        'WallPictureBox3
        '
        Me.WallPictureBox3.BackColor = System.Drawing.Color.White
        Me.WallPictureBox3.Location = New System.Drawing.Point(560, 0)
        Me.WallPictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WallPictureBox3.Name = "WallPictureBox3"
        Me.WallPictureBox3.Size = New System.Drawing.Size(17, 360)
        Me.WallPictureBox3.TabIndex = 6
        Me.WallPictureBox3.TabStop = False
        '
        'WallPictureBox4
        '
        Me.WallPictureBox4.BackColor = System.Drawing.Color.White
        Me.WallPictureBox4.Location = New System.Drawing.Point(-6, 0)
        Me.WallPictureBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WallPictureBox4.Name = "WallPictureBox4"
        Me.WallPictureBox4.Size = New System.Drawing.Size(22, 360)
        Me.WallPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WallPictureBox4.TabIndex = 5
        Me.WallPictureBox4.TabStop = False
        '
        'Player2
        '
        Me.Player2.BackColor = System.Drawing.Color.White
        Me.Player2.Location = New System.Drawing.Point(532, 128)
        Me.Player2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Player2.Name = "Player2"
        Me.Player2.Size = New System.Drawing.Size(13, 76)
        Me.Player2.TabIndex = 1
        Me.Player2.TabStop = False
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.White
        Me.Player.Location = New System.Drawing.Point(29, 128)
        Me.Player.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(13, 76)
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(9, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(555, 20)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(9, 341)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(555, 19)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(577, 357)
        Me.Controls.Add(Me.WallPictureBox3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BulletPictureBox2)
        Me.Controls.Add(Me.WallPictureBox4)
        Me.Controls.Add(Me.Player2)
        Me.Controls.Add(Me.Player)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "MyGame"
        CType(Me.BulletPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Player As PictureBox
    Friend WithEvents Player2 As PictureBox
    Friend WithEvents WallPictureBox4 As PictureBox
    Friend WithEvents WallPictureBox3 As PictureBox
    Friend WithEvents BulletPictureBox2 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
