using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShowBrowser.ServiceReference1;


namespace ShowBrowser
{
    public partial class PSum : System.Web.UI.Page
    {
        private WCFSiplexClient proxyClient;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxyClient = new WCFSiplexClient();
        }

        protected void sum_Click(object sender, EventArgs e)
        {
            try
            {
                A val1 = new A
                {
                    s = x_s.Text,
                    k = int.Parse(x_k.Text),
                    f = float.Parse(x_f.Text),
                },
                val2 = new A
                {
                    s = y_s.Text,
                    k = int.Parse(y_k.Text),
                    f = float.Parse(y_f.Text),
                },
                resValue = proxyClient.Sum(val1, val2);

                result_s.Text = $"{resValue.s}";
                result_k.Text = $"{resValue.k}";
                result_f.Text = $"{resValue.f}";
            }
            catch
            {
                result_s.Text = result_k.Text = result_f.Text = "Check data!";
            }



            if (string.IsNullOrEmpty(result_s.Text))
            {
                result_s.Text = "Error!";
            }

            if (string.IsNullOrEmpty(result_k.Text))
            {
                result_k.Text = "Error!";
            }

            if (string.IsNullOrEmpty(result_f.Text))
            {
                result_f.Text = "Error!";
            }
        }
    }
}