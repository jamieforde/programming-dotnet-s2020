using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExercise01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Subtracts value of secondTextBox from the firstTextBox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subtractButton_Click(object sender, EventArgs e)
        {
            double value1, value2;
            if (double.TryParse(firstTextBox.Text, out value1) && double.TryParse(secondTextBox.Text, out value2))
            {
                resultTextBox.Text = (value1 - value2).ToString();
            }
            else
            {
                resultTextBox.Text = "Only Numbers Allowed";
            }
        }

        /// <summary>
        /// Method clears values of all textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            firstTextBox.Text = string.Empty;
            secondTextBox.Text = "";
            resultTextBox.Text = "";
        }

        /// <summary>
        /// Method that flips values of firstTextBoxes and secondTextBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flipButton_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(firstTextBox.Text, out double value1) && 
                double.TryParse(secondTextBox.Text, out double value2))
            {
                firstTextBox.Text = value2.ToString();
                secondTextBox.Text = value1.ToString();
            }
            else
            {
                resultTextBox.Text = "Only Numbers Allowed";
            }
        }

        /// <summary>
        /// Method close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
