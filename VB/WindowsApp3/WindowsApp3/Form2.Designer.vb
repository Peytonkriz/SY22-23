<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.wowcButton1 = New System.Windows.Forms.Button()
        Me.raftButton2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.wowcTextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBoxraft = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotxt_IV25", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pc Games"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp3.My.Resources.Resources.download1
        Me.PictureBox2.Location = New System.Drawing.Point(551, 137)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(218, 300)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp3.My.Resources.Resources.download
        Me.PictureBox1.Location = New System.Drawing.Point(206, 137)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'wowcButton1
        '
        Me.wowcButton1.Location = New System.Drawing.Point(206, 443)
        Me.wowcButton1.Name = "wowcButton1"
        Me.wowcButton1.Size = New System.Drawing.Size(223, 44)
        Me.wowcButton1.TabIndex = 5
        Me.wowcButton1.Text = "Buy"
        Me.wowcButton1.UseVisualStyleBackColor = True
        '
        'raftButton2
        '
        Me.raftButton2.Location = New System.Drawing.Point(551, 443)
        Me.raftButton2.Name = "raftButton2"
        Me.raftButton2.Size = New System.Drawing.Size(218, 44)
        Me.raftButton2.TabIndex = 6
        Me.raftButton2.Text = "Buy"
        Me.raftButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(817, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 41)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Next 1/2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'wowcTextBox1
        '
        Me.wowcTextBox1.Location = New System.Drawing.Point(268, 493)
        Me.wowcTextBox1.Name = "wowcTextBox1"
        Me.wowcTextBox1.Size = New System.Drawing.Size(100, 32)
        Me.wowcTextBox1.TabIndex = 8
        '
        'TextBoxraft
        '
        Me.TextBoxraft.Location = New System.Drawing.Point(611, 493)
        Me.TextBoxraft.Name = "TextBoxraft"
        Me.TextBoxraft.Size = New System.Drawing.Size(100, 32)
        Me.TextBoxraft.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(264, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "29.99"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(626, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "19.99"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 549)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxraft)
        Me.Controls.Add(Me.wowcTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.raftButton2)
        Me.Controls.Add(Me.wowcButton1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Monotxt_IV25", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents wowcButton1 As Button
    Friend WithEvents raftButton2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents wowcTextBox1 As TextBox
    Friend WithEvents TextBoxraft As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
