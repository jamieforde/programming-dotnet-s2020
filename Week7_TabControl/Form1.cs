using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Creates tab windows
 * Specify more information in the same space
 * Logically group displayed data
 * TabControls contain TabPages.  
 * Only one TabPage is displayed at a time.
 * 
*/


namespace Week7_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void blackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Black;
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Red;
        }

        private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.ForeColor = Color.Green;
        }

        private void size12RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 12);
        }

        private void size16RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 16);

        }

        private void size20RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.Name, 20);

        }

        private void helloRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Hello!";
        }

        private void goodbyeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayLabel.Text = "Goodbye!";
        }
    }
}
