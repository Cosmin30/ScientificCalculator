using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculator1
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;

        

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtRezultat.Text == "0")
                txtRezultat.Text = "";
            if (num.Text == ".")
            {
                if (!txtRezultat.Text.Contains("."))
                    txtRezultat.Text = txtRezultat.Text + num.Text;
            }
            else
            {
                txtRezultat.Text = txtRezultat.Text + num.Text;
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            enterFirstValue = Convert.ToDouble(txtRezultat.Text);
            op = num.Text;
            txtRezultat.Text = "";
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtRezultat.Text);
            switch (op)
            {
                case "+":
                    txtRezultat.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;

                case "-":
                    txtRezultat.Text = (enterFirstValue - enterSecondValue).ToString();

                    break;
                case "*":
                    txtRezultat.Text = (enterFirstValue * enterSecondValue).ToString();

                    break;
                case "/":
                    txtRezultat.Text = (enterFirstValue / enterSecondValue).ToString();

                    break;
                case "Mod":
                    txtRezultat.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;
                case "Exp":
                    double i = Convert.ToDouble(txtRezultat.Text);
                    double j;
                    j = enterSecondValue;
                    txtRezultat.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;
                default:
                    break;

            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtRezultat.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtRezultat.Text = "0";
            String f , s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);
            f = "";
            s = "";

        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtRezultat.Text);
            txtRezultat.Text = Convert.ToString(-1 * q); 
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtRezultat.Text.Length > 0)
            {
                txtRezultat.Text = txtRezultat.Text.Remove(txtRezultat.Text.Length-1 , 1);
            }
            if (txtRezultat.Text == "")
            {
                txtRezultat.Text = "0";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Do you want to exit?", "Scientific Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            txtRezultat.Text = "3.14159265359";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtRezultat.Text);
            logg = Math.Log10(logg);
            txtRezultat.Text = Convert.ToString(logg);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtRezultat.Text);
            sq = Math.Sqrt(sq);
            txtRezultat.Text = Convert.ToString(sq);
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtRezultat.Text) * Convert.ToDouble(txtRezultat.Text);
            txtRezultat.Text = Convert.ToString(x);
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            double x,s,q,m;
            s = Convert.ToDouble(txtRezultat.Text);
            q = Convert.ToDouble(txtRezultat.Text);
            m = Convert.ToDouble(txtRezultat.Text);
            x = (s * q * m);
            txtRezultat.Text = Convert.ToString(x);

        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sh;
            sh = Convert.ToDouble(txtRezultat.Text);
            sh = Math.Sinh(sh);
            txtRezultat.Text = Convert.ToString(sh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtRezultat.Text);
            sin = Math.Sin(sin);
            txtRezultat.Text = Convert.ToString(sin);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double cosh = Convert.ToDouble(txtRezultat.Text);
            cosh = Math.Cosh(cosh);
            txtRezultat.Text = Convert.ToString(cosh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtRezultat.Text);
            cos = Math.Cos(cos);
            txtRezultat.Text = Convert.ToString(cos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(txtRezultat.Text);
            tanh = Math.Tanh(tanh);
            txtRezultat.Text = Convert.ToString(tanh);

        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtRezultat.Text);
            tan = Math.Tan(tan);
            txtRezultat.Text = Convert.ToString(tan);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtRezultat.Text));
            txtRezultat.Text = Convert.ToString(a);

        }

        private void btnLnx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtRezultat.Text);
            lnx= Math.Log(lnx);
            txtRezultat.Text = Convert.ToString(lnx);



        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(Convert.ToDouble(txtRezultat.Text)/ Convert.ToDouble(100));
            txtRezultat.Text = Convert.ToString(a);

        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtRezultat.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtRezultat.Text = Convert.ToString(i2);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtRezultat.Text);
            txtRezultat.Text = Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtRezultat.Text);
            txtRezultat.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtRezultat.Text);
            txtRezultat.Text = Convert.ToString(a, 8);
        }

        public Form1()
        {
            InitializeComponent();
        }

       
    }
}
