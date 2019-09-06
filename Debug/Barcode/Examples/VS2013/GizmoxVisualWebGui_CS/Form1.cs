using System;
using Gizmox.WebGUI.Common.Gateways;
using Gizmox.WebGUI.Common.Interfaces;
using Gizmox.WebGUI.Forms;

namespace GizmoxVisualWebGui_CS
{
    public partial class Form1 : Form, IGatewayControl
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public IGatewayHandler GetGatewayHandler(IContext objContext, string strAction)
        {
            switch (strAction)
            {
                case "Barcode":
                    return new BarcodeHandler(this._txtBarcodeNumber.Text);
                default:
                    return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GatewayReference reference = new GatewayReference(this, "Barcode");
            this.htmlBox1.Url = reference.ToString();
            this.htmlBox1.Update();
        }
    };
}