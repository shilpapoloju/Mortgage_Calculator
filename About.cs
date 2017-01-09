//*********************About form*********************
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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        //navigates to main form from about form
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //hides the previous window
            this.Hide();
            //creating an object to the main form
            Main M = new Main();
            //displays the current window
            M.Show();
        }
        //navigates to open form from about form
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Open_form OM = new Open_form();
            OM.Show();
        }

        //navigates to newform from about form
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            New_form NM = new New_form();
            NM.Show();
        }
        //navigates to extraprinciple form from about form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.Hide();
            ExtraPrinciple EM = new ExtraPrinciple();
            EM.Show();
        }
        //closes the current window
        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //navigates to help form from about form
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Help HM = new Help();
            HM.Show();
        }
    }
}
