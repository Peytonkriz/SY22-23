<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Winslabel = New System.Windows.Forms.Label()
        Me.Losslabel = New System.Windows.Forms.Label()
        Me.AvgPointslabel = New System.Windows.Forms.Label()
        Me.Netsbutton = New System.Windows.Forms.Button()
        Me.netsPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sunsPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.displayPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.netsPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunsPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(363, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Suns"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Wins"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Loss"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Avg Points"
        '
        'Winslabel
        '
        Me.Winslabel.AutoSize = True
        Me.Winslabel.Location = New System.Drawing.Point(301, 13)
        Me.Winslabel.Name = "Winslabel"
        Me.Winslabel.Size = New System.Drawing.Size(0, 13)
        Me.Winslabel.TabIndex = 6
        '
        'Losslabel
        '
        Me.Losslabel.AutoSize = True
        Me.Losslabel.Location = New System.Drawing.Point(301, 42)
        Me.Losslabel.Name = "Losslabel"
        Me.Losslabel.Size = New System.Drawing.Size(0, 13)
        Me.Losslabel.TabIndex = 7
        '
        'AvgPointslabel
        '
        Me.AvgPointslabel.AutoSize = True
        Me.AvgPointslabel.Location = New System.Drawing.Point(301, 69)
        Me.AvgPointslabel.Name = "AvgPointslabel"
        Me.AvgPointslabel.Size = New System.Drawing.Size(0, 13)
        Me.AvgPointslabel.TabIndex = 8
        '
        'Netsbutton
        '
        Me.Netsbutton.Location = New System.Drawing.Point(363, 13)
        Me.Netsbutton.Name = "Netsbutton"
        Me.Netsbutton.Size = New System.Drawing.Size(75, 23)
        Me.Netsbutton.TabIndex = 9
        Me.Netsbutton.Text = "Nets"
        Me.Netsbutton.UseVisualStyleBackColor = True
        '
        'netsPictureBox1
        '
        Me.netsPictureBox1.Image = Global.Stuff.My.Resources.Resources.download__1_
        Me.netsPictureBox1.Location = New System.Drawing.Point(444, 12)
        Me.netsPictureBox1.Name = "netsPictureBox1"
        Me.netsPictureBox1.Size = New System.Drawing.Size(75, 25)
        Me.netsPictureBox1.TabIndex = 10
        Me.netsPictureBox1.TabStop = False
        '
        'sunsPictureBox2
        '
        Me.sunsPictureBox2.Image = Global.Stuff.My.Resources.Resources.download
        Me.sunsPictureBox2.Location = New System.Drawing.Point(444, 62)
        Me.sunsPictureBox2.Name = "sunsPictureBox2"
        Me.sunsPictureBox2.Size = New System.Drawing.Size(75, 25)
        Me.sunsPictureBox2.TabIndex = 2
        Me.sunsPictureBox2.TabStop = False
        '
        'displayPictureBox
        '
        Me.displayPictureBox.Location = New System.Drawing.Point(233, 107)
        Me.displayPictureBox.Name = "displayPictureBox"
        Me.displayPictureBox.Size = New System.Drawing.Size(286, 167)
        Me.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox.TabIndex = 1
        Me.displayPictureBox.TabStop = False
        '
        'F
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.netsPictureBox1)
        Me.Controls.Add(Me.Netsbutton)
        Me.Controls.Add(Me.AvgPointslabel)
        Me.Controls.Add(Me.Losslabel)
        Me.Controls.Add(Me.Winslabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sunsPictureBox2)
        Me.Controls.Add(Me.displayPictureBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "F"
        Me.Text = "Form1"
        CType(Me.netsPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunsPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents displayPictureBox As PictureBox
    Friend WithEvents sunsPictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Winslabel As Label
    Friend WithEvents Losslabel As Label
    Friend WithEvents AvgPointslabel As Label
    Friend WithEvents netsPictureBox1 As PictureBox
    Friend WithEvents Netsbutton As Button
End Class
