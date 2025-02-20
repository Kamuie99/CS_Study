using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BWpicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        int XSIZE = 512, YSIZE = 512;
        byte[,] inImage; // 2차원 배열 (메모리)
        Bitmap bitmap;

        void LoadImage(string fname)
        {
            BinaryReader fp = new BinaryReader(File.Open(fname, FileMode.Open));
            inImage = new byte[XSIZE, YSIZE];

            for (int i = 0; i < XSIZE; i++)
                for (int k = 0; k < YSIZE; k++)
                    inImage[i, k] = fp.ReadByte();

            fp.Close();
        }

        void DisplayImage()
        {
            for (int i = 0; i < XSIZE; i++)
                for (int k = 0; k < YSIZE; k++)
                {
                    byte data = inImage[k, i];
                    Color c = Color.FromArgb(data, data, data);
                    bitmap.SetPixel(i, k, c);
                }

            picturebox.Image = bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.ClientSize = new System.Drawing.Size(XSIZE, YSIZE);
                picturebox.Location = new System.Drawing.Point(0, 0);
                picturebox.Size = new System.Drawing.Size(XSIZE, YSIZE);

                bitmap = new Bitmap(XSIZE, YSIZE);

                // 파일 --> 메모리
                string fileName = "C:/Users/yclee/Desktop/250219_실습/BWpicture/images/LENNA512.raw";
                LoadImage(fileName);

                // 메모리 --> 화면
                DisplayImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
