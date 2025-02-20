using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode petRoot = new TreeNode("동물");

            TreeNode dogTree = new TreeNode("강아지");
            dogTree.Nodes.Add("강아지1");
            dogTree.Nodes.Add("강아지2");
            petRoot.Nodes.Add(dogTree);

            TreeNode catTree = new TreeNode("고양이");
            catTree.Nodes.Add("고양이1");
            catTree.Nodes.Add("고양이2");
            petRoot.Nodes.Add(catTree);

            TreeNode birdTree = new TreeNode("새");
            birdTree.Nodes.Add("새1");
            birdTree.Nodes.Add("새2");
            petRoot.Nodes.Add(birdTree);

            tree_pet.Nodes.Add(petRoot);

            pb_pet.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tree_pet_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "강아지1")
                pb_pet.Image = Bitmap.FromFile("C:/Users/yclee/Desktop/250219_실습/ImageViewer/Images/dog1.png");
            else if (e.Node.Text == "강아지2")
                pb_pet.Image = Bitmap.FromFile("C:/Users/yclee/Desktop/250219_실습/ImageViewer/Images/dog2.png");
            else if (e.Node.Text == "고양이1")
                pb_pet.Image = Bitmap.FromFile("C:/Users/yclee/Desktop/250219_실습/ImageViewer/Images/cat1.png");
            else if (e.Node.Text == "고양이2")
                pb_pet.Image = Bitmap.FromFile("C:/Users/yclee/Desktop/250219_실습/ImageViewer/Images/cat2.png");
            else if (e.Node.Text == "새1")
                pb_pet.Image = Bitmap.FromFile("C:/Users/yclee/Desktop/250219_실습/ImageViewer/Images/bird1.png");
            else if (e.Node.Text == "새2")
                pb_pet.Image = Bitmap.FromFile("C:/Users/yclee/Desktop/250219_실습/ImageViewer/Images/bird2.png");
        }

        private void cb_original_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_original.Checked)
                pb_pet.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pb_pet.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
