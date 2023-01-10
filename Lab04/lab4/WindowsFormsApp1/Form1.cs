//using solution;
//using solution.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Proxy; //15

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Simplex proxyClient;

        public Form1()
        {
            proxyClient = new Simplex();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            result.Text = $"{resValue.s} - {resValue.k} - {resValue.f}";

            if (string.IsNullOrEmpty(result.Text))
            {
                result.Text = "Error!";
            }
        }
    }
}
