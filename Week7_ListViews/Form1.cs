using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_ListViews
{
    public partial class Form1 : Form
    {
        string currentDirectory = Directory.GetCurrentDirectory();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadFilesInDirectory(string currentDirectoryValue)
        {
            try
            {
                listView1.Items.Clear();
                listView1.Items.Add("Go Up One Level");

                currentDirectory = currentDirectoryValue;

                DirectoryInfo newCurrentDirectory = new DirectoryInfo(currentDirectory);

                DirectoryInfo[] directoryArray = newCurrentDirectory.GetDirectories();

                FileInfo[] fileArray = newCurrentDirectory.GetFiles();

                foreach(DirectoryInfo dir in directoryArray)
                {
                    ListViewItem newDirectoryItem = listView1.Items.Add(dir.Name);
                    newDirectoryItem.ImageIndex = 0;
                }

                foreach (FileInfo file in fileArray)
                {
                    ListViewItem newFileItem = listView1.Items.Add(file.Name);
                    newFileItem.ImageIndex = 1;
                }
            } catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Warning: Some File may not be accessible");
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                if (listView1.Items[0].Selected)
                {
                    DirectoryInfo directoryObject = new DirectoryInfo(currentDirectory);


                    if (directoryObject.Parent != null)
                    {
                        LoadFilesInDirectory(directoryObject.Parent.FullName);
                    }
                }
                else
                {
                    string chosen = listView1.SelectedItems[0].Text;

                    if (Directory.Exists(Path.Combine(currentDirectory, chosen)))
                    {
                        LoadFilesInDirectory(Path.Combine(currentDirectory, chosen));
                    }
                }

                displayLabel.Text = currentDirectory;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imageList1.Images.Add(Properties.Resources.folder);
            imageList1.Images.Add(Properties.Resources.file);

            LoadFilesInDirectory(currentDirectory);
            displayLabel.Text = currentDirectory;          
        }
    }
}
