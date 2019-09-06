<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.printDialog1 = New System.Windows.Forms.PrintDialog
        Me.printDocument1 = New System.Drawing.Printing.PrintDocument
        Me.printPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.button1 = New System.Windows.Forms.Button
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.barcodeControl1 = New Limilabs.Windows.BarcodeControl
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.printToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barcodeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'printDialog1
        '
        Me.printDialog1.Document = Me.printDocument1
        Me.printDialog1.UseEXDialog = True
        '
        'printDocument1
        '
        '
        'printPreviewToolStripMenuItem
        '
        Me.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
        Me.printPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.printPreviewToolStripMenuItem.Text = "Print preview"
        '
        'printPreviewDialog1
        '
        Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDialog1.Document = Me.printDocument1
        Me.printPreviewDialog1.Enabled = True
        Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.printPreviewDialog1.Name = "printPreviewDialog1"
        Me.printPreviewDialog1.Visible = False
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(249, 173)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(159, 23)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Render in picture box"
        Me.button1.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(249, 39)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(159, 128)
        Me.pictureBox1.TabIndex = 5
        Me.pictureBox1.TabStop = False
        '
        'barcodeControl1
        '
        Me.barcodeControl1.BackColor = System.Drawing.Color.White
        Me.barcodeControl1.BarColor = System.Drawing.Color.Black
        Me.barcodeControl1.BearerBarsSize = 0
        Me.barcodeControl1.FontName = "Microsoft Sans Serif"
        Me.barcodeControl1.ForeColor = System.Drawing.Color.SteelBlue
        Me.barcodeControl1.Location = New System.Drawing.Point(12, 39)
        Me.barcodeControl1.Name = "barcodeControl1"
        Me.barcodeControl1.Number = "123456789012"
        Me.barcodeControl1.Size = New System.Drawing.Size(119, 86)
        Me.barcodeControl1.TabIndex = 4
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(426, 24)
        Me.menuStrip1.TabIndex = 7
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.printToolStripMenuItem, Me.printPreviewToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'printToolStripMenuItem
        '
        Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
        Me.printToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.printToolStripMenuItem.Text = "Print..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 241)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.barcodeControl1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barcodeControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents printDialog1 As System.Windows.Forms.PrintDialog
    Private WithEvents printDocument1 As System.Drawing.Printing.PrintDocument
    Private WithEvents printPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents barcodeControl1 As Limilabs.Windows.BarcodeControl
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents printToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
