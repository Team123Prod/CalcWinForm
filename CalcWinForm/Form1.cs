using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinForm
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void btn_res_Click_1(object sender, EventArgs e)
        {
            Client client = new Client();
            int a = Convert.ToInt32(text_a.Text);
            int b = Convert.ToInt32(text_b.Text);
            string op = Convert.ToString(text_op.Text);
            int res = client.RequestCalcResult(a, b, op);
            text_res.Text = res.ToString();
        }
    }
}
