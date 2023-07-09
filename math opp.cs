using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {

            /*
             *  if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "")
         {
             string stringSol = "Please enter some values!";
             txtSolution1.Text = stringSol;
             txtSolution2.Text = stringSol;
         }
         double aValue = double.Parse(txtA.Text);
         double bValue = double.Parse(txtB.Text);
               double cValue = double.Parse(txtC.Text);

              double solution1Double, solution2Double;

             */
            double x1 = Convert.ToDouble(txt_x1.Text);
            double x2 = Convert.ToDouble(txt_x2.Text);
            double y1 = Convert.ToDouble(txt_y1.Text);
            double y2 = Convert.ToDouble(txt_y2.Text);
            double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            MessageBox.Show(res.ToString());
            if (txt_x1.Text == "" || txt_x2.Text == "" || txt_y1.Text == "" || txt_y2.Text == "")
            {
                MessageBox.Show("Error");

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}



