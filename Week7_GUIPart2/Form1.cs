using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Menus provide groups of related commands.
 * Organize commands so as not to clutter the UI
 * 
 * Alt Key Shortcuts - accessed by pressing and the underlined letter e.g.  Alt-F for expands the file menu.
 * Shortcut keys - Combinatsion of Ctrlm Shift Alt, F1, F2 etc.  
 * 
 * Create a menu:
 * Select menu strip
 * Add menu items (ToolStripMenuItem): 
    * Click the Type here
    * Alt-Shortcut keys - add ampersand in front of letter
 * Properties of ToolStripMenuItem:
    * ShortCutKeys
    * Show shortcutkeys
 * Seperator bar to logically group menu items
 * Not limited to text -> can also add 
    * Combobox (ToolStripComboBox)
    * TextBox (ToolStripTextBox)
 * Generating click events
    *  
 */


namespace Week7_GUIPart2
{
    public partial class Form1 : Form
    {
        float defaultFontSize = 10F;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearFont()
        {
            broadwayToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }

        private void ClearColor()
        {
            redToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = false;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This a demo app for Week 7");
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            courierToolStripMenuItem.Checked = true;
            userInputTextBox.Font = new Font("Courier", defaultFontSize);
        }
        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            comicSansToolStripMenuItem.Checked = true;
            userInputTextBox.Font = new Font("Comic Sans MS", defaultFontSize);
        }

        private void broadwayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            broadwayToolStripMenuItem.Checked = true;
            userInputTextBox.Font = new Font("Broadway", defaultFontSize);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            redToolStripMenuItem.Checked = true;
            userInputTextBox.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            greenToolStripMenuItem.Checked = true;
            userInputTextBox.ForeColor = Color.Green;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            orangeToolStripMenuItem.Checked = true;
            userInputTextBox.ForeColor = Color.Orange;
        }
    }
}
