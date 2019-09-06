using System;

namespace ASPNET20_CS
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.BarcodeControl1.Number = "PAGE LOAD 123";
        }
    }
}
