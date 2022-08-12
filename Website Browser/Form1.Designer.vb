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
        Me.WebBrowser_window = New System.Windows.Forms.WebBrowser()
        Me.Button_Home = New System.Windows.Forms.Button()
        Me.Button_Previous = New System.Windows.Forms.Button()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Button_Refresh = New System.Windows.Forms.Button()
        Me.TextBox_Uniform_Resource_Locator = New System.Windows.Forms.TextBox()
        Me.Button_Continue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser_window
        '
        Me.WebBrowser_window.Location = New System.Drawing.Point(12, 41)
        Me.WebBrowser_window.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser_window.Name = "WebBrowser_window"
        Me.WebBrowser_window.Size = New System.Drawing.Size(1240, 628)
        Me.WebBrowser_window.TabIndex = 0
        Me.WebBrowser_window.Url = New System.Uri("https://www.microsoft.com", System.UriKind.Absolute)
        '
        'Button_Home
        '
        Me.Button_Home.Location = New System.Drawing.Point(12, 12)
        Me.Button_Home.Name = "Button_Home"
        Me.Button_Home.Size = New System.Drawing.Size(75, 23)
        Me.Button_Home.TabIndex = 1
        Me.Button_Home.Text = "Home"
        Me.Button_Home.UseVisualStyleBackColor = True
        '
        'Button_Previous
        '
        Me.Button_Previous.Location = New System.Drawing.Point(93, 12)
        Me.Button_Previous.Name = "Button_Previous"
        Me.Button_Previous.Size = New System.Drawing.Size(75, 23)
        Me.Button_Previous.TabIndex = 2
        Me.Button_Previous.Text = "Previous"
        Me.Button_Previous.UseVisualStyleBackColor = True
        '
        'Button_Next
        '
        Me.Button_Next.Location = New System.Drawing.Point(175, 11)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(75, 23)
        Me.Button_Next.TabIndex = 3
        Me.Button_Next.Text = "Next"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'Button_Refresh
        '
        Me.Button_Refresh.Location = New System.Drawing.Point(256, 11)
        Me.Button_Refresh.Name = "Button_Refresh"
        Me.Button_Refresh.Size = New System.Drawing.Size(107, 23)
        Me.Button_Refresh.TabIndex = 4
        Me.Button_Refresh.Text = "Refresh Web Page"
        Me.Button_Refresh.UseVisualStyleBackColor = True
        '
        'TextBox_Uniform_Resource_Locator
        '
        Me.TextBox_Uniform_Resource_Locator.Location = New System.Drawing.Point(369, 12)
        Me.TextBox_Uniform_Resource_Locator.Name = "TextBox_Uniform_Resource_Locator"
        Me.TextBox_Uniform_Resource_Locator.Size = New System.Drawing.Size(802, 20)
        Me.TextBox_Uniform_Resource_Locator.TabIndex = 5
        '
        'Button_Continue
        '
        Me.Button_Continue.Location = New System.Drawing.Point(1177, 12)
        Me.Button_Continue.Name = "Button_Continue"
        Me.Button_Continue.Size = New System.Drawing.Size(75, 23)
        Me.Button_Continue.TabIndex = 6
        Me.Button_Continue.Text = "Continue"
        Me.Button_Continue.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button_Continue)
        Me.Controls.Add(Me.TextBox_Uniform_Resource_Locator)
        Me.Controls.Add(Me.Button_Refresh)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Button_Previous)
        Me.Controls.Add(Me.Button_Home)
        Me.Controls.Add(Me.WebBrowser_window)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Website Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser_window As WebBrowser
    Friend WithEvents Button_Home As Button
    Friend WithEvents Button_Previous As Button
    Friend WithEvents Button_Next As Button
    Friend WithEvents Button_Refresh As Button
    Friend WithEvents TextBox_Uniform_Resource_Locator As TextBox
    Friend WithEvents Button_Continue As Button
End Class
