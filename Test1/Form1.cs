using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {

        Fraction c1;
        Fraction c2;
        Fraction c3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(txt_x1.Text == "" ? "0" : txt_x1.Text);
            double y1 = Convert.ToDouble(txt_y1.Text == "" ? "0" : txt_y1.Text);

            double x2 = Convert.ToDouble(txt_x2.Text == "" ? "0" : txt_x2.Text);
            double y2 = Convert.ToDouble(txt_y2.Text == "" ? "0" : txt_y2.Text);

            double x3 = Convert.ToDouble(txt_x3.Text == "" ? "0" : txt_x3.Text);
            double y3 = Convert.ToDouble(txt_y3.Text == "" ? "0" : txt_y3.Text);

            c1 = new Fraction(x1, y1);
            c2 = new Fraction(x2, y2);
            c3 = new Fraction(x3, y3);

            Fraction c4 = (c3 - c1) * c3;
            Fraction c5 = (c1 + c2) / c1.PowTo(3);

            String sing = "==";

            if (c4 < c5)
                sing = "<";
            else
            if (c4 > c5)
                sing = ">";

            txtOutput.Text = "( " + c3.ToString() + " - " + c1.ToString() + ") * ( " +
                c3.ToString() + " )" + " " + sing + " " + " ( " + c1.ToString() + " + " +
                c2.ToString() + " ) / pow( " + c1.ToString() + ", 3 )" + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
