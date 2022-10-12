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
        Me.buybutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nametextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.exptextbox = New System.Windows.Forms.TextBox()
        Me.ziptextbox = New System.Windows.Forms.TextBox()
        Me.cctextbox = New System.Windows.Forms.TextBox()
        Me.costtextbox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.feetextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buybutton
        '
        Me.buybutton.Location = New System.Drawing.Point(249, 209)
        Me.buybutton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.buybutton.Name = "buybutton"
        Me.buybutton.Size = New System.Drawing.Size(87, 23)
        Me.buybutton.TabIndex = 0
        Me.buybutton.Text = "Buy"
        Me.buybutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'nametextbox
        '
        Me.nametextbox.Location = New System.Drawing.Point(110, 29)
        Me.nametextbox.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.nametextbox.Name = "nametextbox"
        Me.nametextbox.Size = New System.Drawing.Size(79, 21)
        Me.nametextbox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CC#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "EXP Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Zip Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(270, 174)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cost"
        '
        'exptextbox
        '
        Me.exptextbox.Location = New System.Drawing.Point(110, 99)
        Me.exptextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.exptextbox.Name = "exptextbox"
        Me.exptextbox.Size = New System.Drawing.Size(79, 21)
        Me.exptextbox.TabIndex = 7
        '
        'ziptextbox
        '
        Me.ziptextbox.Location = New System.Drawing.Point(110, 134)
        Me.ziptextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ziptextbox.Name = "ziptextbox"
        Me.ziptextbox.Size = New System.Drawing.Size(79, 21)
        Me.ziptextbox.TabIndex = 8
        '
        'cctextbox
        '
        Me.cctextbox.Location = New System.Drawing.Point(110, 62)
        Me.cctextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cctextbox.Name = "cctextbox"
        Me.cctextbox.Size = New System.Drawing.Size(79, 21)
        Me.cctextbox.TabIndex = 9
        '
        'costtextbox
        '
        Me.costtextbox.Location = New System.Drawing.Point(352, 171)
        Me.costtextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.costtextbox.Name = "costtextbox"
        Me.costtextbox.Size = New System.Drawing.Size(79, 21)
        Me.costtextbox.TabIndex = 10
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(352, 209)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(87, 23)
        Me.CancelButton.TabIndex = 11
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.download__2_
        Me.PictureBox1.Location = New System.Drawing.Point(245, 29)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 141)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 14)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fee"
        '
        'feetextBox1
        '
        Me.feetextBox1.Location = New System.Drawing.Point(352, 136)
        Me.feetextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.feetextBox1.Name = "feetextBox1"
        Me.feetextBox1.Size = New System.Drawing.Size(79, 21)
        Me.feetextBox1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 483)
        Me.Controls.Add(Me.feetextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.costtextbox)
        Me.Controls.Add(Me.cctextbox)
        Me.Controls.Add(Me.ziptextbox)
        Me.Controls.Add(Me.exptextbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nametextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buybutton)
        Me.Font = New System.Drawing.Font("SansSerif", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Form1"
        Me.Text = "my app"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buybutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents nametextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents exptextbox As TextBox
    Friend WithEvents ziptextbox As TextBox
    Friend WithEvents cctextbox As TextBox
    Friend WithEvents costtextbox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents feetextBox1 As TextBox
End Class
