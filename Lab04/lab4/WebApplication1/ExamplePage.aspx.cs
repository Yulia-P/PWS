using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ExamplePage : System.Web.UI.Page
    {
        private Simplex proxyClient;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxyClient = new Simplex();
        }

        protected void sum_Click(object sender, EventArgs e)
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

        protected void concat_Click(object sender, EventArgs e)
        {
            string val1 = s.Text.ToString();
            double val2;

            if (!string.IsNullOrEmpty(val1) && double.TryParse(d.Text.ToString(), out val2))
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