using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculationUsingWebFrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       private void textBox7_TextChanged(object sender, EventArgs e)
       {

       }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        Double sal, etf, epf, etfamount, epfamount, gsal, allow, nsal;
        

        private void button1_Click(object sender, EventArgs e)
        {
            sal = Double.Parse(txtSal.Text);
            if (chketf.Checked == true)
            {
                etfamount = sal * 10 / 100;
            }
            if (chkepf.Checked == true)
            {
                epfamount = sal * 5 / 100;
            }
           
            txtetf.Text = etfamount.ToString();
            txtepf.Text = epfamount.ToString();
           
            gsal = sal - epfamount + etfamount;
            txtgsal.Text = gsal.ToString();
            if (sal > 50000)
            {
                allow = 2000;
            }
            else if (sal > 30000)
            {
                allow = 1000;
            }
            else
            {
                allow = 0;
            }
            txtallo.Text = allow.ToString();
            nsal = gsal + allow;
            txtnsal.Text = nsal.ToString();
        }
    }
}
