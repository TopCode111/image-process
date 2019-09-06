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
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.viewReportButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(80, 37)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(85, 13)
        NameLabel.TabIndex = 2
        NameLabel.Text = "Customer Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(117, 63)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 4
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(138, 89)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 6
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(130, 115)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 8
        StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(241, 115)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(25, 13)
        ZipLabel.TabIndex = 10
        ZipLabel.Text = "Zip:"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(RDLC_Windows_VB.Customer)
        '
        'LineItemBindingSource
        '
        Me.LineItemBindingSource.DataSource = GetType(RDLC_Windows_VB.LineItem)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReportViewer1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(699, 698)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "ReportFromGrid_Customer"
        ReportDataSource4.Value = Me.CustomerBindingSource
        ReportDataSource5.Name = "ReportFromGrid_LineItem"
        ReportDataSource5.Value = Me.LineItemBindingSource
        ReportDataSource6.Name = "RDLC_Windows_VB_Customer"
        ReportDataSource6.Value = Me.CustomerBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DisplayName = "Invoice"
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RDLC_Windows_VB.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 353)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(693, 342)
        Me.ReportViewer1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(ZipLabel)
        Me.Panel2.Controls.Add(Me.ZipTextBox)
        Me.Panel2.Controls.Add(StateLabel)
        Me.Panel2.Controls.Add(Me.StateTextBox)
        Me.Panel2.Controls.Add(CityLabel)
        Me.Panel2.Controls.Add(Me.CityTextBox)
        Me.Panel2.Controls.Add(AddressLabel)
        Me.Panel2.Controls.Add(Me.AddressTextBox)
        Me.Panel2.Controls.Add(NameLabel)
        Me.Panel2.Controls.Add(Me.NameTextBox)
        Me.Panel2.Controls.Add(Me.viewReportButton)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(693, 344)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(13, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Bill to:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(9, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Line items:"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(272, 112)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(90, 20)
        Me.ZipTextBox.TabIndex = 11
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(171, 112)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(61, 20)
        Me.StateTextBox.TabIndex = 9
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(171, 86)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(191, 20)
        Me.CityTextBox.TabIndex = 7
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(171, 60)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(303, 20)
        Me.AddressTextBox.TabIndex = 5
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(171, 34)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(303, 20)
        Me.NameTextBox.TabIndex = 3
        '
        'viewReportButton
        '
        Me.viewReportButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewReportButton.Location = New System.Drawing.Point(560, 309)
        Me.viewReportButton.Name = "viewReportButton"
        Me.viewReportButton.Size = New System.Drawing.Size(124, 23)
        Me.viewReportButton.TabIndex = 1
        Me.viewReportButton.Text = "Generate Invoice"
        Me.viewReportButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LineItemBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(675, 131)
        Me.DataGridView1.TabIndex = 0
        '
        'ProductDataGridViewTextBoxColumn
        '
        Me.ProductDataGridViewTextBoxColumn.DataPropertyName = "Product"
        Me.ProductDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.ProductDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.ProductDataGridViewTextBoxColumn.Name = "ProductDataGridViewTextBoxColumn"
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 698)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Invoice Maker"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents viewReportButton As System.Windows.Forms.Button
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ZipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LineItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
