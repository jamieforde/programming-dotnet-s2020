using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_LinkLabels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cDriveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cDriveLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(@"C:\");
        }

        private void microsoftDocsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            microsoftDocsLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://docs.microsoft.com/");
        }

        private void notepadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            notepadLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
