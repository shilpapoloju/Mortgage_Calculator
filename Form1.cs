//*******************************************************************
//Name: Sindhu Thandra
//Subject:
//Project: Developing a GUI for calculating Mortage financing system
//*******************************************************************

//header files included
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortgage_Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        
        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        //navigates to new form from main
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //it hides the previous window
            this.Hide();
            //creating an object for new form window
            New_form NM = new New_form();
            //displays the window
            NM.Show();
        }
        //navigates to open form from main
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Open_form OM = new Open_form();
            OM.Show();
        }

        //navigates to about form from main
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            About AM = new About();
            AM.Show();
        }

        //this method closes the current window
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExtraPrinciple EM = new ExtraPrinciple();
            EM.Show();
        }

        //navigates to help form from main
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help HM = new Help();
            HM.Show();
        }
    }
}
