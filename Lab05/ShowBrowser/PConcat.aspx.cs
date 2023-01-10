using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShowBrowser.ServiceReference1;

namespace ShowBrowser
{
    public partial class PConcat : System.Web.UI.Page
    {
        private WCFSiplexClient proxyClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxyClient = new WCFSiplexClient();
        }

        protected void concat_Click(object sender, EventArgs e)
        {
            string val1 = s.Text.ToString();
            double val2;

            if (!string.IsNullOrWhiteSpace(val1) && double.TryParse(d.Text.ToString(), out val2))
            {
                result.Text = proxyClient.Concat(val1, val2).ToString();
            }
            else
            {
                result.Text = "Error!";
            }
        }
    }
}