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

/*  ListView - Similar to a ListBox.  User can select one or more items.
 *  More versatile:
    * Can display icons next list items.
    * Show details of item in columns.
 *  Properties:
    * Activation = Determine hoe the user activate an item.  
        * Options = OneClick, TwoClick and Standard (Default. Double click and item does not change color
    * Checkboxes = Indicates whterher checkboxes are rpesent
    * LargeImageList = Specifies the ImageList containing large icons
    * Items = Collection of ListViewItems in the control
    * MultiSelect = Set if mulitple selections are allowed. 
    * SelectItems = Collection of selected items as ListView.SelectedListViewItemCollection
    * SmallImageList = Specifies the ImageList containing large icons 
    * View = Determines appearance of ListViewItems.  
        * Options = LargeIcon, SmallIcons.  
          List (small iconsm items appear in single column.
          Details = Multiple columns of information can be displayed.   
          Tile = Large icons displayed, information provided to the right of icon.  
 * Events:
    * Click = Generated when item is clicked
    * ItemActivate = Generated when a item in a ListView is actives. Does not contain the
        specifics of the which item is actives.  Use SelectedItem or SelectedIndicies to determine. 
 * 
*/


namespace Week7_ListView
{
    public partial class ListViewTest : Form
    {
        string currentDirectory = Directory.GetCurrentDirectory();

        public ListViewTest()
        {
            InitializeComponent();
        }

        


        private void LoadFilesInDirectory(string currentDirectoryValue)
        {
            try
            {
                browserListView.Items.Clear();
                browserListView.Items.Add("Go Up One Level");

                currentDirectory = currentDirectoryValue;               
                DirectoryInfo newCurrentDirectory = new DirectoryInfo(currentDirectory);

                DirectoryInfo[] directroyArray = newCurrentDirectory.GetDirectories();
                FileInfo[] fileArray = newCurrentDirectory.GetFiles();

                foreach (DirectoryInfo dir in directroyArray)
                {
                    ListViewItem newDirectoryItem = browserListView.Items.Add(dir.Name);

                    newDirectoryItem.ImageIndex = 0;
                }

                foreach(FileInfo file in fileArray)
                {
                    ListViewItem newFileItem = browserListView.Items.Add(file.Name);
                    newFileItem.ImageIndex = 1;
                }
            } catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Warning: SomeFiles may not be " +
                    "visible due to permission settings", "Attention", 0, MessageBoxIcon.Warning);
            }
        }

        private void ListViewTest_Load(object sender, EventArgs e)
        {
            fileFolderImageList.Images.Add(Properties.Resources.folder);
            fileFolderImageList.Images.Add(Properties.Resources.file);

            LoadFilesInDirectory(currentDirectory);
            displayLabel.Text = currentDirectory;
        }

        private void browserListView_Click(object sender, EventArgs e)
        {
            if (browserListView.Items.Count != 0)
            {
                if (browserListView.Items[0].Selected)
                {
                    DirectoryInfo directoryObject = new DirectoryInfo(currentDirectory);

                    if (directoryObject.Parent != null)
                    {
                        LoadFilesInDirectory(directoryObject.Parent.FullName);
                    }
                } else
                {
                    string chosen = browserListView.SelectedItems[0].Text;

                    if (Directory.Exists(Path.Combine(currentDirectory, chosen)))
                    {
                        LoadFilesInDirectory(Path.Combine(currentDirectory, chosen));
                    }
                }

                displayLabel.Text = currentDirectory;
            }
        }
    }
}
