using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_LinkLabel
{
    /*  Links to other resources
     *  Files, Web pages, Applications 
     *  Similiar to hyperlink
     *  Core properties:
        * ActiveLinkColor = Specifies the color of the link while the user is in the process of selecting
        * LinkArea = Specifies which portion of the text is part of the link
        * LinkBehaviour = Sepcifies the link's behaviour such as how the link appears when the mouse hovers over it.
        * LinkColor = Pre-visited color.  Blue by default
        * LinkVisited = If true then the color of the link is changed.
        * Text = What is displayed in the UI
        * UseMneumonic = Similar to the alt shortcut.  
        * VisitedLinkColor = The colour of a visited link
     *  LinkClicked = Generated when the link is clicked.  
    */

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

        private void notePadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            notePadLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
