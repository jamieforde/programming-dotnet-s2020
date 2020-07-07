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

/*  TreeViews
 *  Displays nodes heirarchally in a tree
 *  Nodes are objects 
 *  A parent node contains child nodes. 
 *  Two child nodes of the same parent node are sibiling nodes.
 *  Root node = First parent node
 *  A parent node can be expanded or collapsed by clicking the plus box
 *  Nodes in a TreeView are to type TreeNode.  Each TreeNode
    *  Has a Nodes collection
    *  Property that returns a reference to the parent node or NULL if the node is the root node. 
 * TreeView Properties 
    *  CheckBoxes = Indicates whether checkboxes appear next to the node. 
    *  ImageList = Collection of Image objects
    *  Nodes = Colection of TreeNodes in the control as a TreeNodeCollection.  
        *  Methods = Add, Remove and Clear.  Removing a parent node removes all the children.  
    *  Events
        * AfterSelect = Generated after selected node changes.
* TreeNode 
    * Properties
        * Checked = Is the TreeNode check (Checkboxes property must be set to true)
        * FirstNode = Sepcifies the first node in Nodes colection
        * FullPath = Starting at the root of the tree
        * ImageIndex = 
        * LastNode = Specifies the last node in the Nodes Collection
        * NextNode = Next sibiling node
        * Nodes = Collection of TreeNodes in the current node (i.e All the Children of the current node)
        * PrevNode = Previous sibiling node
        * SelectImageIndex = Specifies the index in the TreeView's ImageList of the
             image to use when the node is selected.
        * Text = Text of the node
    * Methods: 
        *  Expand = Expands a node
        *  ExpandAll = Expands all the children of a node
        *  Collapse = Collapses a node
        *  GetNodeCount = Returns the number of children of a node. 
*/


namespace Week7_TreeView
{
    public partial class TreeViewDirectoryStructureForm : Form
    {

        string subStringDirectory;


        public TreeViewDirectoryStructureForm()
        {
            InitializeComponent();
        }

        public void PopulateTreeView(string directoryValue, TreeNode parentNode)
        {
            string[] directoryArray = Directory.GetDirectories(directoryValue);

            try
            {
                if (directoryArray.Any())
                {
                    foreach (string directory in directoryArray)
                    {
                        subStringDirectory = Path.GetFileNameWithoutExtension(directory);

                        TreeNode myNode = new TreeNode(subStringDirectory);
                        parentNode.Nodes.Add(myNode);

                        PopulateTreeView(directory, myNode);
                    }
                }
            } catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access Denied");
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            directoryTreeView.Nodes.Clear();

            if (Directory.Exists(inputTextBox.Text))
            {
                directoryTreeView.Nodes.Add(inputTextBox.Text);

                PopulateTreeView(inputTextBox.Text, directoryTreeView.Nodes[0]);
            } else
            {
                MessageBox.Show($"{inputTextBox.Text} could not be found", "Directory Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
