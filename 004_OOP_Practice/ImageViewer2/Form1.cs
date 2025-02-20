using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "그림 파일 (*.jpg, *.png, *.gif, *.bmp)|";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            pb_image.Image = Bitmap.FromFile(ofd.FileName);
        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램을 종료합니다.");
            this.Close();
        }

        private void tbar_image_Scroll(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pb_image.Image);
            int R, G, B;
            Color c;

            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int k = 0; k < bitmap.Width; k++)
                {
                    c = bitmap.GetPixel(k, i);
                    R = c.R + tbar_image.Value;
                    G = c.G + tbar_image.Value;
                    B = c.B + tbar_image.Value;

                    if (R > 255)
                        R = 255;
                    else if (R < 0)
                        R = 0;
                    if (G > 255)
                        G = 255;
                    else if (G < 0)
                        G = 0;
                    if (B > 255)
                        B = 255;
                    else if (B < 0)
                        B = 0;
                    c = Color.FromArgb(R, G, B);
                    bitmap.SetPixel(k, i, c);
                }
            }

            pb_image.Image = bitmap;
        }
    }
}
