using ServiceReference3;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private SimplexSoapClient proxyClient;
        public Form1()
        {
            proxyClient = new SimplexSoapClient(SimplexSoapClient.EndpointConfiguration.SimplexSoap12, "https://localhost:44349/Simplex.asmx");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Sum
        private async void button2_Click(object sender, EventArgs e)
        {

            A val1 = new A
            {
                s = x_s.Text,
                k = 1,
                f = 1.2f,
            },
            val2 = new A
            {
                s = y_s.Text,
                k = 1,
                f = 2.1f,
            },
            resValue = (await proxyClient.SumAsync(val1, val2)).sumResult;


            result.Text = $"{resValue.s} - {resValue.k} - {resValue.f}";

            if (string.IsNullOrEmpty(result.Text))
            {
                result.Text = "Error!";
            }
        }

        private void y_f_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
