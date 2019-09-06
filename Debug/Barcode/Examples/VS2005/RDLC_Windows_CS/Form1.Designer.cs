using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace RDLC_Windows_CS
{
    partial class Form1
    {
        // Properties
        internal TextBox AddressTextBox;
        internal TextBox CityTextBox;
        internal BindingSource CustomerBindingSource;
        internal DataGridView DataGridView1;
        internal Label Label1;
        internal Label Label2;
        internal BindingSource LineItemBindingSource;
        internal TextBox NameTextBox;
        internal Panel Panel2;
        internal DataGridViewTextBoxColumn ProductDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn QuantityDataGridViewTextBoxColumn;
        internal ReportViewer ReportViewer1;
        internal TextBox StateTextBox;
        internal TableLayoutPanel TableLayoutPanel1;
        internal DataGridViewTextBoxColumn UnitPriceDataGridViewTextBoxColumn;
        internal Button viewReportButton;
        internal TextBox ZipTextBox;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.viewReportButton = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LineItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.ReportViewer1, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.Panel2, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 2;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(699, 698);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // ReportViewer1
            // 
            this.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportFromGrid_Customer";
            reportDataSource1.Value = this.CustomerBindingSource;
            reportDataSource2.Name = "ReportFromGrid_LineItem";
            reportDataSource2.Value = this.LineItemBindingSource;
            this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewer1.LocalReport.DisplayName = "Invoice";
            this.ReportViewer1.LocalReport.ReportEmbeddedResource = "RDLC_Windows_CS.Report1.rdlc";
            this.ReportViewer1.Location = new System.Drawing.Point(3, 353);
            this.ReportViewer1.Name = "ReportViewer1";
            this.ReportViewer1.Size = new System.Drawing.Size(693, 342);
            this.ReportViewer1.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.AutoScroll = true;
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.ZipLabel);
            this.Panel2.Controls.Add(this.ZipTextBox);
            this.Panel2.Controls.Add(this.StateLabel);
            this.Panel2.Controls.Add(this.StateTextBox);
            this.Panel2.Controls.Add(this.CityLabel);
            this.Panel2.Controls.Add(this.CityTextBox);
            this.Panel2.Controls.Add(this.AddressLabel);
            this.Panel2.Controls.Add(this.AddressTextBox);
            this.Panel2.Controls.Add(this.NameLabel);
            this.Panel2.Controls.Add(this.NameTextBox);
            this.Panel2.Controls.Add(this.viewReportButton);
            this.Panel2.Controls.Add(this.DataGridView1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(3, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(693, 344);
            this.Panel2.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.DimGray;
            this.Label2.Location = new System.Drawing.Point(13, 10);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(59, 20);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Bill to:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(9, 149);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 20);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Line items:";
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(241, 115);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(25, 13);
            this.ZipLabel.TabIndex = 10;
            this.ZipLabel.Text = "Zip:";
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "Zip", true));
            this.ZipTextBox.Location = new System.Drawing.Point(272, 112);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(90, 20);
            this.ZipTextBox.TabIndex = 11;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(130, 115);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(35, 13);
            this.StateLabel.TabIndex = 8;
            this.StateLabel.Text = "State:";
            // 
            // StateTextBox
            // 
            this.StateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "State", true));
            this.StateTextBox.Location = new System.Drawing.Point(171, 112);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(61, 20);
            this.StateTextBox.TabIndex = 9;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(138, 89);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 6;
            this.CityLabel.Text = "City:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "City", true));
            this.CityTextBox.Location = new System.Drawing.Point(171, 86);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(191, 20);
            this.CityTextBox.TabIndex = 7;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(117, 63);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "Address", true));
            this.AddressTextBox.Location = new System.Drawing.Point(171, 60);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(303, 20);
            this.AddressTextBox.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(80, 37);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(85, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Customer Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerBindingSource, "Name", true));
            this.NameTextBox.Location = new System.Drawing.Point(171, 34);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(303, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // viewReportButton
            // 
            this.viewReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewReportButton.Location = new System.Drawing.Point(560, 309);
            this.viewReportButton.Name = "viewReportButton";
            this.viewReportButton.Size = new System.Drawing.Size(124, 23);
            this.viewReportButton.TabIndex = 1;
            this.viewReportButton.Text = "Generate Invoice";
            this.viewReportButton.UseVisualStyleBackColor = true;
            this.viewReportButton.Click += new System.EventHandler(this.viewReportButton_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductDataGridViewTextBoxColumn,
            this.UnitPriceDataGridViewTextBoxColumn,
            this.QuantityDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.LineItemBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(9, 172);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(675, 131);
            this.DataGridView1.TabIndex = 0;
            // 
            // CustomerBindingSource
            // 
            this.CustomerBindingSource.DataSource = typeof(RDLC_Windows_CS.Customer);
            // 
            // LineItemBindingSource
            // 
            this.LineItemBindingSource.DataSource = typeof(RDLC_Windows_CS.LineItem);
            // 
            // ProductDataGridViewTextBoxColumn
            // 
            this.ProductDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.ProductDataGridViewTextBoxColumn.FillWeight = 60F;
            this.ProductDataGridViewTextBoxColumn.HeaderText = "Product";
            this.ProductDataGridViewTextBoxColumn.Name = "ProductDataGridViewTextBoxColumn";
            // 
            // UnitPriceDataGridViewTextBoxColumn
            // 
            this.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.UnitPriceDataGridViewTextBoxColumn.FillWeight = 20F;
            this.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            this.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn";
            // 
            // QuantityDataGridViewTextBoxColumn
            // 
            this.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.QuantityDataGridViewTextBoxColumn.FillWeight = 20F;
            this.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(699, 698);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Invoice Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private Label ZipLabel;
        private Label StateLabel;
        private Label CityLabel;
        private Label AddressLabel;
        private Label NameLabel;
    }
}

