<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Me.FormPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.FormDescription = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.FormTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CloseButton = New Guna.UI2.WinForms.Guna2Button()
        Me.LoginButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PasswordInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UsernameInput = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MiraswiftLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.FormPanel.SuspendLayout()
        CType(Me.MiraswiftLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormPanel
        '
        Me.FormPanel.BackColor = System.Drawing.Color.Transparent
        Me.FormPanel.BackgroundImage = Global.LearningDesign.My.Resources.Resources.form_background_1
        Me.FormPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FormPanel.BorderRadius = 12
        Me.FormPanel.CausesValidation = False
        Me.FormPanel.Controls.Add(Me.FormDescription)
        Me.FormPanel.Controls.Add(Me.FormTitle)
        Me.FormPanel.Controls.Add(Me.CloseButton)
        Me.FormPanel.Controls.Add(Me.LoginButton)
        Me.FormPanel.Controls.Add(Me.PasswordInput)
        Me.FormPanel.Controls.Add(Me.UsernameInput)
        Me.FormPanel.CustomizableEdges.BottomRight = False
        Me.FormPanel.CustomizableEdges.TopRight = False
        Me.FormPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormPanel.FillColor = System.Drawing.Color.Transparent
        Me.FormPanel.Location = New System.Drawing.Point(420, 0)
        Me.FormPanel.Margin = New System.Windows.Forms.Padding(32, 0, 0, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Padding = New System.Windows.Forms.Padding(12, 32, 12, 32)
        Me.FormPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.FormPanel.Size = New System.Drawing.Size(250, 440)
        Me.FormPanel.TabIndex = 0
        Me.FormPanel.UseTransparentBackground = True
        '
        'FormDescription
        '
        Me.FormDescription.AutoSize = False
        Me.FormDescription.AutoSizeHeightOnly = True
        Me.FormDescription.BackColor = System.Drawing.Color.Transparent
        Me.FormDescription.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.FormDescription.ForeColor = System.Drawing.Color.DimGray
        Me.FormDescription.Location = New System.Drawing.Point(44, 123)
        Me.FormDescription.Margin = New System.Windows.Forms.Padding(32, 0, 32, 32)
        Me.FormDescription.Name = "FormDescription"
        Me.FormDescription.Size = New System.Drawing.Size(162, 31)
        Me.FormDescription.TabIndex = 1
        Me.FormDescription.Text = "jadilah lebih produktif dari manasaja!."
        Me.FormDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormTitle
        '
        Me.FormTitle.AutoSize = False
        Me.FormTitle.AutoSizeHeightOnly = True
        Me.FormTitle.BackColor = System.Drawing.Color.Transparent
        Me.FormTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.FormTitle.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.FormTitle.Location = New System.Drawing.Point(44, 94)
        Me.FormTitle.Margin = New System.Windows.Forms.Padding(32, 62, 32, 0)
        Me.FormTitle.Name = "FormTitle"
        Me.FormTitle.Size = New System.Drawing.Size(162, 29)
        Me.FormTitle.TabIndex = 0
        Me.FormTitle.Text = "MAS,"
        Me.FormTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Animated = True
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.BackgroundImage = Global.LearningDesign.My.Resources.Resources.close_fill
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseButton.BorderColor = System.Drawing.Color.Transparent
        Me.CloseButton.BorderRadius = 4
        Me.CloseButton.BorderThickness = 1
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CloseButton.FillColor = System.Drawing.Color.Transparent
        Me.CloseButton.FocusedColor = System.Drawing.Color.Transparent
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CloseButton.ForeColor = System.Drawing.Color.Transparent
        Me.CloseButton.HoverState.BorderColor = System.Drawing.Color.Brown
        Me.CloseButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseButton.Location = New System.Drawing.Point(218, 32)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.PressedColor = System.Drawing.Color.Transparent
        Me.CloseButton.Size = New System.Drawing.Size(20, 20)
        Me.CloseButton.TabIndex = 5
        '
        'LoginButton
        '
        Me.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoginButton.Animated = True
        Me.LoginButton.BorderRadius = 6
        Me.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LoginButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LoginButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.LoginButton.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LoginButton.HoverState.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(12, 308)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(226, 45)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Oke, GAS!"
        '
        'PasswordInput
        '
        Me.PasswordInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PasswordInput.Animated = True
        Me.PasswordInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PasswordInput.BorderColor = System.Drawing.Color.Gainsboro
        Me.PasswordInput.BorderRadius = 6
        Me.PasswordInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordInput.DefaultText = ""
        Me.PasswordInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordInput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.PasswordInput.ForeColor = System.Drawing.Color.Black
        Me.PasswordInput.HoverState.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.PasswordInput.IconLeft = Global.LearningDesign.My.Resources.Resources.lock_line
        Me.PasswordInput.IconLeftSize = New System.Drawing.Size(16, 16)
        Me.PasswordInput.Location = New System.Drawing.Point(12, 238)
        Me.PasswordInput.Margin = New System.Windows.Forms.Padding(0, 0, 0, 32)
        Me.PasswordInput.Name = "PasswordInput"
        Me.PasswordInput.Padding = New System.Windows.Forms.Padding(8)
        Me.PasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordInput.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.PasswordInput.PlaceholderText = "Ketik passwordnya disini."
        Me.PasswordInput.SelectedText = ""
        Me.PasswordInput.Size = New System.Drawing.Size(226, 38)
        Me.PasswordInput.TabIndex = 3
        Me.PasswordInput.UseSystemPasswordChar = True
        '
        'UsernameInput
        '
        Me.UsernameInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsernameInput.Animated = True
        Me.UsernameInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UsernameInput.BorderColor = System.Drawing.Color.Gainsboro
        Me.UsernameInput.BorderRadius = 6
        Me.UsernameInput.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameInput.DefaultText = ""
        Me.UsernameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameInput.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UsernameInput.ForeColor = System.Drawing.Color.Black
        Me.UsernameInput.HoverState.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.UsernameInput.IconLeft = Global.LearningDesign.My.Resources.Resources.user_line
        Me.UsernameInput.IconLeftSize = New System.Drawing.Size(16, 16)
        Me.UsernameInput.Location = New System.Drawing.Point(12, 188)
        Me.UsernameInput.Margin = New System.Windows.Forms.Padding(0, 0, 0, 12)
        Me.UsernameInput.Name = "UsernameInput"
        Me.UsernameInput.Padding = New System.Windows.Forms.Padding(8)
        Me.UsernameInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameInput.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.UsernameInput.PlaceholderText = "Ketik nama pengguna mu."
        Me.UsernameInput.SelectedText = ""
        Me.UsernameInput.Size = New System.Drawing.Size(226, 38)
        Me.UsernameInput.TabIndex = 2
        '
        'MiraswiftLogo
        '
        Me.MiraswiftLogo.BackColor = System.Drawing.Color.Transparent
        Me.MiraswiftLogo.BackgroundImage = Global.LearningDesign.My.Resources.Resources.miraswift_transparent
        Me.MiraswiftLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MiraswiftLogo.FillColor = System.Drawing.Color.Transparent
        Me.MiraswiftLogo.ImageRotate = 0!
        Me.MiraswiftLogo.Location = New System.Drawing.Point(41, 41)
        Me.MiraswiftLogo.Margin = New System.Windows.Forms.Padding(32)
        Me.MiraswiftLogo.Name = "MiraswiftLogo"
        Me.MiraswiftLogo.Size = New System.Drawing.Size(173, 67)
        Me.MiraswiftLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MiraswiftLogo.TabIndex = 1
        Me.MiraswiftLogo.TabStop = False
        Me.MiraswiftLogo.UseTransparentBackground = True
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LearningDesign.My.Resources.Resources.engineering_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(670, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.MiraswiftLogo)
        Me.Controls.Add(Me.FormPanel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "LoginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginPage"
        Me.FormPanel.ResumeLayout(False)
        CType(Me.MiraswiftLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MiraswiftLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents UsernameInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordInput As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LoginButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents CloseButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FormTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents FormDescription As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
