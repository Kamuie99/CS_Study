using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num_1.Maximum = num_2.Maximum = Int32.MaxValue;
            num_1.Minimum = num_2.Minimum = Int32.MinValue;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            double result = LycMath.Add((double)num_1.Value, (double)num_2.Value);
            tb_result.Text = result.ToString();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            double result = LycMath.Subtract((double)num_1.Value, (double)num_2.Value);
            tb_result.Text = result.ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            double result = LycMath.Multiply((double)num_1.Value, (double)num_2.Value);
            tb_result.Text = result.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            double result = LycMath.Divide((double)num_1.Value, (double)num_2.Value);
            tb_result.Text = result.ToString();
        }

        public static class LycMath
        {
            public static double LYC_PI = 3.141592653;
            public static double LYC_E = 2.718281;

            public static double Add(double n1, double n2)
            {
                return n1 + n2;
            }

            public static double Subtract(double n1, double n2)
            {
                return n1 - n2;
            }

            public static double Multiply(double n1, double n2)
            {
                return n1 * n2;
            }
            
            public static double Divide(double n1, double n2)
            {
                return n1 / n2;
            }
        }
    }
}
