using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Allows user to view and select mulitple items in a list.  
 * The list is static -> cannot be edited by the user.
 * Properties:
    * Items = Collection of items in the ListBox
    * MultiColumn = Eliminates vertical scrollbar -> data is presented in columns
    * SelectedIndex = Returns the index of the selected item.  If no item selected = -1.
    * SelectedIndicies = Returns a collection of all selected items
    * SelectedItem = Returns a reference to the selected item.  If multiple items are selected, it can
        any of the selected items.  
    * SelectedItems = Returns a collection of selected items. 
    * SelectionMode = Determines the number of items that can be selected.  
        * None
        * One - Default
        * MultiSimple = More than one item can be selected
        * MultiExtended = Multiple select but can use arrow keys, Ctrl and Shift with mouse clicks. 
 *      * Sorted = Indicated whether items are alphabetically sorted.
 *  * Methods:
 *      * ClearSelected = Deselects every item
 *      * GetSelected = Returns true if the item at the specified index is selected. 
 *  * Events:
 *      *  SelectedIndexChanged = Generated when the selectedIndex has changed.  
 * Adding Items:
    * Use Add Method 
    * Requires a string parameter
    * Objects = Calls the ToString method 
*/
namespace Week7_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Add(inputTextBox.Text);
            inputTextBox.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (displayListBox.SelectedIndex != -1)
            {
                displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
