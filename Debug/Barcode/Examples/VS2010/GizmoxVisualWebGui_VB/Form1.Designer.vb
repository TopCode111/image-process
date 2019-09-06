<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits Gizmox.WebGUI.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Visual WebGui Designer
    Private Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Visual WebGui Designer
    'It can be modified using the Visual webGui Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._btnRender = New Gizmox.WebGUI.Forms.Button
        Me.HtmlBox1 = New Gizmox.WebGUI.Forms.HtmlBox
        Me._txtNumber = New Gizmox.WebGUI.Forms.TextBox
        Me.SuspendLayout()
        '
        '_btnRender
        '
        Me._btnRender.Location = New System.Drawing.Point(187, 52)
        Me._btnRender.Name = "_btnRender"
        Me._btnRender.Size = New System.Drawing.Size(75, 23)
        Me._btnRender.TabIndex = 0
        Me._btnRender.Text = "Render"
        '
        'HtmlBox1
        '
        Me.HtmlBox1.ContentType = "text/html"
        Me.HtmlBox1.Expires = -1
        Me.HtmlBox1.Html = "<HTML>No content.</HTML>"
        Me.HtmlBox1.Location = New System.Drawing.Point(12, 79)
        Me.HtmlBox1.Name = "HtmlBox1"
        Me.HtmlBox1.Path = ""
        Me.HtmlBox1.Resource = Nothing
        Me.HtmlBox1.Size = New System.Drawing.Size(250, 250)
        Me.HtmlBox1.TabIndex = 1
        Me.HtmlBox1.Text = "HtmlBox1"
        Me.HtmlBox1.Url = ""
        '
        '_txtNumber
        '
        Me._txtNumber.Location = New System.Drawing.Point(12, 52)
        Me._txtNumber.Name = "_txtNumber"
        Me._txtNumber.Size = New System.Drawing.Size(169, 20)
        Me._txtNumber.TabIndex = 2
        Me._txtNumber.Text = "(10)123456789"
        '
        'Form1
        '
        Me.Controls.Add(Me._txtNumber)
        Me.Controls.Add(Me.HtmlBox1)
        Me.Controls.Add(Me._btnRender)
        Me.Size = New System.Drawing.Size(600, 459)
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _btnRender As Gizmox.WebGUI.Forms.Button
    Friend WithEvents HtmlBox1 As Gizmox.WebGUI.Forms.HtmlBox
    Friend WithEvents _txtNumber As Gizmox.WebGUI.Forms.TextBox

End Class