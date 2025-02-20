using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputBox_09_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_string_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("문자열 입력");
            tb_string.Text = str;
        }

        private void btn_int_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("정수 입력");
            int intVal = int.Parse(str);
            tb_int.Text = intVal.ToString();
        }

        private void btn_float_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("실수 입력");
            float floatVal = float.Parse(str);
            tb_float.Text = floatVal.ToString();
        }
    }
}
