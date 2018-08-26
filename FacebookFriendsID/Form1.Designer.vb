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
        Me.Facebook = New System.Windows.Forms.WebBrowser()
        Me.timermore = New System.Windows.Forms.Timer(Me.components)
        Me.btnstop = New System.Windows.Forms.Button()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlink = New System.Windows.Forms.TextBox()
        Me.BtnOpenLink = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtfbids = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.richfbtags = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Facebook
        '
        Me.Facebook.Location = New System.Drawing.Point(12, 58)
        Me.Facebook.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Facebook.Name = "Facebook"
        Me.Facebook.Size = New System.Drawing.Size(1086, 559)
        Me.Facebook.TabIndex = 0
        '
        'timermore
        '
        '
        'btnstop
        '
        Me.btnstop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstop.Location = New System.Drawing.Point(68, 79)
        Me.btnstop.Margin = New System.Windows.Forms.Padding(2)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(107, 36)
        Me.btnstop.TabIndex = 5
        Me.btnstop.Text = "Stop"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'btnstart
        '
        Me.btnstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.Location = New System.Drawing.Point(68, 30)
        Me.btnstart.Margin = New System.Windows.Forms.Padding(2)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(107, 36)
        Me.btnstart.TabIndex = 4
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Custom Link"
        '
        'txtlink
        '
        Me.txtlink.Location = New System.Drawing.Point(84, 24)
        Me.txtlink.Name = "txtlink"
        Me.txtlink.Size = New System.Drawing.Size(622, 20)
        Me.txtlink.TabIndex = 7
        '
        'BtnOpenLink
        '
        Me.BtnOpenLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenLink.Location = New System.Drawing.Point(723, 10)
        Me.BtnOpenLink.Name = "BtnOpenLink"
        Me.BtnOpenLink.Size = New System.Drawing.Size(118, 42)
        Me.BtnOpenLink.TabIndex = 8
        Me.BtnOpenLink.Text = "Open"
        Me.BtnOpenLink.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1117, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(193, 54)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Find Freind's ID"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnstart)
        Me.GroupBox1.Controls.Add(Me.btnstop)
        Me.GroupBox1.Location = New System.Drawing.Point(1104, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 131)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scroll Down"
        '
        'txtfbids
        '
        Me.txtfbids.Location = New System.Drawing.Point(12, 654)
        Me.txtfbids.Multiline = True
        Me.txtfbids.Name = "txtfbids"
        Me.txtfbids.Size = New System.Drawing.Size(1086, 258)
        Me.txtfbids.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 629)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Facebook ID's"
        '
        'richfbtags
        '
        Me.richfbtags.Location = New System.Drawing.Point(1104, 281)
        Me.richfbtags.Name = "richfbtags"
        Me.richfbtags.Size = New System.Drawing.Size(217, 631)
        Me.richfbtags.TabIndex = 13
        Me.richfbtags.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1330, 924)
        Me.Controls.Add(Me.richfbtags)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfbids)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnOpenLink)
        Me.Controls.Add(Me.txtlink)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Facebook)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facebook ID's"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Facebook As WebBrowser
    Friend WithEvents timermore As Timer
    Friend WithEvents btnstop As Button
    Friend WithEvents btnstart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlink As TextBox
    Friend WithEvents BtnOpenLink As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtfbids As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents richfbtags As RichTextBox
End Class
