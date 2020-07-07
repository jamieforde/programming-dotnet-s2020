using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_CheckedListBox
{
    /* CheckListBoxControl
     * Derives from ListBox 
     * Displays a checkbox next to each item
     * String Collection Editor
     * Properties:
        * Checked items.  Only accessible at runtime.  Returns a collection of items that check as 
              as CheckedListBox.CheckedItemCollection.  Distinct from the selected item.  An item may be
              selected but not checked.  Only one selected item at a time.    
        * CheckedIndicies = Accessible at runtime.  Returns an indicies of all the checked items as 
        *     a CheckedListBox.CheckedIndicesCollection 
        * CheckedOnClick = When true the items is selected and checked.
        * SelectionMode = Can only be one or none.  Cannot set to MultiSimple or MultiExtended.
     * Methods:
        * GetItemChecked = Takes an index and rtutrn true if the corresponing item is checked
     * Events:
        * ItemChecked = Generated when an item is checked or unchecked. 
        * CurrentValue = Indicates whether the current item is checked or unchecked. Possible
            values are Checked, Unchecked, Indeterminate.  
        * Index = Return the index of the items that changed 
        * NewValue = Specifies the new state of the object
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countriesTravelledCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = countriesTravelledCheckedListBox.SelectedItem.ToString();

            if (e.NewValue == CheckState.Checked)
            {
                displayListBox.Items.Add(item);
            } else
            {
                displayListBox.Items.Remove(item);
            }
        }
    }
}
