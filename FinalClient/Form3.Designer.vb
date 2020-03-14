<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_dice = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.randompic = New System.Windows.Forms.PictureBox()
        Me.PicBox_Start = New System.Windows.Forms.PictureBox()
        Me.PicBox_Axe = New System.Windows.Forms.PictureBox()
        Me.PictBox_chako = New System.Windows.Forms.PictureBox()
        Me.PicBox_Gun = New System.Windows.Forms.PictureBox()
        Me.PicBox_Machete = New System.Windows.Forms.PictureBox()
        Me.PicBox_spear = New System.Windows.Forms.PictureBox()
        Me.PicBox_sword = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.randompic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox_Axe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictBox_chako, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox_Gun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox_Machete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox_spear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox_sword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(301, 341)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btn_dice
        '
        Me.Btn_dice.Location = New System.Drawing.Point(382, 401)
        Me.Btn_dice.Name = "Btn_dice"
        Me.Btn_dice.Size = New System.Drawing.Size(76, 36)
        Me.Btn_dice.TabIndex = 38
        Me.Btn_dice.Text = "ROLL DICE"
        Me.Btn_dice.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(502, 341)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(278, 96)
        Me.RichTextBox1.TabIndex = 37
        Me.RichTextBox1.Text = ""
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(382, 341)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(76, 37)
        Me.btn_start.TabIndex = 36
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(12, 28)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(289, 23)
        Me.ProgressBar2.TabIndex = 34
        Me.ProgressBar2.Value = 100
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(332, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(126, 10)
        Me.ProgressBar1.TabIndex = 40
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(491, 28)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(289, 23)
        Me.ProgressBar3.TabIndex = 41
        Me.ProgressBar3.Value = 100
        '
        'randompic
        '
        Me.randompic.Image = Global.FinalClient.My.Resources.Resources.SwordR
        Me.randompic.Location = New System.Drawing.Point(332, 28)
        Me.randompic.Name = "randompic"
        Me.randompic.Size = New System.Drawing.Size(126, 50)
        Me.randompic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.randompic.TabIndex = 49
        Me.randompic.TabStop = False
        '
        'PicBox_Start
        '
        Me.PicBox_Start.Image = Global.FinalClient.My.Resources.Resources.START
        Me.PicBox_Start.Location = New System.Drawing.Point(109, 95)
        Me.PicBox_Start.Name = "PicBox_Start"
        Me.PicBox_Start.Size = New System.Drawing.Size(589, 200)
        Me.PicBox_Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox_Start.TabIndex = 50
        Me.PicBox_Start.TabStop = False
        '
        'PicBox_Axe
        '
        Me.PicBox_Axe.Image = Global.FinalClient.My.Resources.Resources.AXE
        Me.PicBox_Axe.Location = New System.Drawing.Point(109, 95)
        Me.PicBox_Axe.Name = "PicBox_Axe"
        Me.PicBox_Axe.Size = New System.Drawing.Size(589, 200)
        Me.PicBox_Axe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox_Axe.TabIndex = 51
        Me.PicBox_Axe.TabStop = False
        '
        'PictBox_chako
        '
        Me.PictBox_chako.Image = Global.FinalClient.My.Resources.Resources.CHAKO
        Me.PictBox_chako.Location = New System.Drawing.Point(109, 95)
        Me.PictBox_chako.Name = "PictBox_chako"
        Me.PictBox_chako.Size = New System.Drawing.Size(589, 200)
        Me.PictBox_chako.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictBox_chako.TabIndex = 52
        Me.PictBox_chako.TabStop = False
        '
        'PicBox_Gun
        '
        Me.PicBox_Gun.Image = Global.FinalClient.My.Resources.Resources.GUN_
        Me.PicBox_Gun.Location = New System.Drawing.Point(109, 95)
        Me.PicBox_Gun.Name = "PicBox_Gun"
        Me.PicBox_Gun.Size = New System.Drawing.Size(589, 200)
        Me.PicBox_Gun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox_Gun.TabIndex = 53
        Me.PicBox_Gun.TabStop = False
        '
        'PicBox_Machete
        '
        Me.PicBox_Machete.Image = Global.FinalClient.My.Resources.Resources.MACHETE_
        Me.PicBox_Machete.Location = New System.Drawing.Point(109, 95)
        Me.PicBox_Machete.Name = "PicBox_Machete"
        Me.PicBox_Machete.Size = New System.Drawing.Size(589, 200)
        Me.PicBox_Machete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox_Machete.TabIndex = 54
        Me.PicBox_Machete.TabStop = False
        '
        'PicBox_spear
        '
        Me.PicBox_spear.Image = Global.FinalClient.My.Resources.Resources.SPEAR_ENEMY
        Me.PicBox_spear.Location = New System.Drawing.Point(109, 95)
        Me.PicBox_spear.Name = "PicBox_spear"
        Me.PicBox_spear.Size = New System.Drawing.Size(589, 200)
        Me.PicBox_spear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox_spear.TabIndex = 55
        Me.PicBox_spear.TabStop = False
        '
        'PicBox_sword
        '
        Me.PicBox_sword.Image = Global.FinalClient.My.Resources.Resources.SWORD_ENEMY
        Me.PicBox_sword.Location = New System.Drawing.Point(109, 95)
        Me.PicBox_sword.Name = "PicBox_sword"
        Me.PicBox_sword.Size = New System.Drawing.Size(589, 200)
        Me.PicBox_sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox_sword.TabIndex = 56
        Me.PicBox_sword.TabStop = False
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalClient.My.Resources.Resources.untitled_png4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PicBox_sword)
        Me.Controls.Add(Me.PicBox_spear)
        Me.Controls.Add(Me.PicBox_Machete)
        Me.Controls.Add(Me.PicBox_Gun)
        Me.Controls.Add(Me.PictBox_chako)
        Me.Controls.Add(Me.PicBox_Axe)
        Me.Controls.Add(Me.PicBox_Start)
        Me.Controls.Add(Me.randompic)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_dice)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.ProgressBar2)
        Me.DoubleBuffered = True
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.randompic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox_Axe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictBox_chako, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox_Gun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox_Machete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox_spear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox_sword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Btn_dice As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btn_start As Button
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents randompic As PictureBox
    Friend WithEvents PicBox_Start As PictureBox
    Friend WithEvents PicBox_Axe As PictureBox
    Friend WithEvents PictBox_chako As PictureBox
    Friend WithEvents PicBox_Gun As PictureBox
    Friend WithEvents PicBox_Machete As PictureBox
    Friend WithEvents PicBox_spear As PictureBox
    Friend WithEvents PicBox_sword As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
