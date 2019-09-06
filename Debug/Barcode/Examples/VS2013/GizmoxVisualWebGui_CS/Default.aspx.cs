using System;

namespace GizmoxVisualWebGui_CS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Redirect("Form1.wgx");
        }
    };
}
