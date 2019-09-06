namespace GizmoxVisualWebGui_CS
{
    partial class Form1
    {
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
            this.htmlBox1 = new Gizmox.WebGUI.Forms.HtmlBox();
            this._btnRender = new Gizmox.WebGUI.Forms.Button();
            this._txtBarcodeNumber = new Gizmox.WebGUI.Forms.TextBox();
            this.SuspendLayout();
            // 
            // htmlBox1
            // 
            this.htmlBox1.ContentType = "text/html";
            this.htmlBox1.Expires = -1;
            this.htmlBox1.Html = "";
            this.htmlBox1.Location = new System.Drawing.Point(12, 95);
            this.htmlBox1.Name = "htmlBox1";
            this.htmlBox1.Path = "";
            this.htmlBox1.Resource = null;
            this.htmlBox1.Size = new System.Drawing.Size(227, 130);
            this.htmlBox1.TabIndex = 1;
            this.htmlBox1.Text = "htmlBox1";
            this.htmlBox1.Url = "";
            // 
            // _btnRender
            // 
            this._btnRender.Location = new System.Drawing.Point(121, 12);
            this._btnRender.Name = "_btnRender";
            this._btnRender.Size = new System.Drawing.Size(75, 23);
            this._btnRender.TabIndex = 2;
            this._btnRender.Text = "Render";
            this._btnRender.Click += new System.EventHandler(this.button1_Click);
            // 
            // _txtBarcodeNumber
            // 
            this._txtBarcodeNumber.Location = new System.Drawing.Point(15, 14);
            this._txtBarcodeNumber.Name = "_txtBarcodeNumber";
            this._txtBarcodeNumber.Size = new System.Drawing.Size(100, 20);
            this._txtBarcodeNumber.TabIndex = 3;
            this._txtBarcodeNumber.Text = "(10)123456789";
            // 
            // Form1
            // 
            this.Controls.Add(this._txtBarcodeNumber);
            this.Controls.Add(this._btnRender);
            this.Controls.Add(this.htmlBox1);
            this.Size = new System.Drawing.Size(486, 419);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.HtmlBox htmlBox1;
        private Gizmox.WebGUI.Forms.Button _btnRender;
        private Gizmox.WebGUI.Forms.TextBox _txtBarcodeNumber;
    }
}