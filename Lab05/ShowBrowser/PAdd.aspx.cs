using System;
using System.Web.UI;
using ShowBrowser.ServiceReference1;

namespace ShowBrowser
{
    public partial class WebForm1 : Page
    {
        private WCFSiplexClient proxyClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxyClient = new WCFSiplexClient();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            int val1, val2;

            if (int.TryParse(x.Text.ToString(), out val1) && int.TryParse(y.Text.ToString(), out val2))
            {
                result.Text = proxyClient.Add(val1, val2).ToString();
            }
            else
            {
                result.Text = "Error!";
            }
        }
    }
}