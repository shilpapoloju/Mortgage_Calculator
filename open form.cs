
//******************open form******************
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
    public partial class Open_form : Form
    {
        public Open_form()
        {
            InitializeComponent();
        }

        //navigate back to the main form
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //hides the previous window
            this.Hide();
            //creating an object to the main form
            Main M = new Main();
            //displays the current window
            M.Show();
        }

        //navigates to new form from open form
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            New_form NM = new New_form();
            NM.Show();
        }

        //navigates to extra principle  from open
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ExtraPrinciple EM = new ExtraPrinciple();
            EM.Show();
        }

        //this closes the current window
        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //navigates to help form from open form
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Help HM = new Help();
            HM.Show();
        }
        //navigates to about form from open
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.Hide();
            About AM = new About();
            AM.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
