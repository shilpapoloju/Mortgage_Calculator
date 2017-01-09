//********************Help form************************
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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //navigates to main form from help form
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //hides the previous window
            this.Hide();
            //creating an object to the main form
            Main M = new Main();
            //displays the current window
            M.Show();
        }
    }
}
