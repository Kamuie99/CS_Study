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

namespace Exam17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        DirectoryInfo parentFolder = new DirectoryInfo("C:\\");
        DirectoryInfo currentFolder;

        void SetFolderAndFile(DirectoryInfo folder)
        {
            currentFolder = folder;

            DirectoryInfo[] dirInfos = currentFolder.GetDirectories("*.*", SearchOption.TopDirectoryOnly);
            FileInfo[] fileInfos = currentFolder.GetFiles();

            lbox_folders.Items.Clear();
            lbox_files.Items.Clear();

            tb_folder.Text = currentFolder.FullName;
            lbox_folders.Items.Add("<상위 폴더>");
            foreach (DirectoryInfo dInfo in dirInfos)
                lbox_folders.Items.Add(dInfo.Name);

            foreach (FileInfo fInfo in fileInfos)
                lbox_files.Items.Add(fInfo.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetFolderAndFile(parentFolder);
        }

        private void lbox_folders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_folders.SelectedIndex == -1)
                return;
            
            if (lbox_folders.SelectedIndex == 0)
            {
                if (tb_folder.Text == "C:\\")
                    return;
                SetFolderAndFile(parentFolder);
                parentFolder = parentFolder.Parent;               
            }
            else
            {
                parentFolder = currentFolder;
                string folderStr = parentFolder.FullName + "\\" + lbox_folders.SelectedItem.ToString() ;
                DirectoryInfo selectFolder = new DirectoryInfo(folderStr);
                SetFolderAndFile(selectFolder);
            }
        }
    }
}
