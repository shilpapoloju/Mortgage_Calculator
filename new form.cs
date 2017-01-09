//****************************new form*****************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mortgage_Calculator
{
    public partial class New_form : Form
    {
        public New_form()
        {
            InitializeComponent();
        }

        //navigates to main form from new form
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //hides the previous window
            this.Hide();
            //creating an object to the main form
            Main M = new Main();
            //displays the current window
            M.Show();
        }

        //navigates to open form from new form
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.Hide();
           Open_form OM = new Open_form();
            OM.Show();
        }

        //navigates to extra principle form from new form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.Hide();
            ExtraPrinciple EM = new ExtraPrinciple();
            EM.Show();
        }

        //this closes the current window
        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //navigates to help form from new form
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Help HM = new Help();
            HM.Show();
        }

        //navigates to about form from new form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this.Hide();
            About AM = new About();
            AM.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int LA;
            LA = Convert.ToInt32(LoanAmount.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int TT;
            TT = Convert.ToInt32(TotalTerms.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.Date.GetItemText(this.Date.SelectedItem);
            MessageBox.Show(selected);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int IR;
            IR = Convert.ToInt32(InterestRate.Text);
        }

        private void MonthlyPayment_TextChanged(object sender, EventArgs e)
        {
            int MP;
            MP = Convert.ToInt32(MonthlyPayment.Text);

        }

        private void ExtraPrincipal_TextChanged(object sender, EventArgs e)
        {
            int EP;
            EP = Convert.ToInt32(ExtraPrincipal.Text);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

           DialogResult dialog= MessageBox.Show("Are you sure you want to cancel it","Exit",MessageBoxButtons.YesNo);
           if(dialog==DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(dialog==DialogResult.No)

            {
                //e.Cancel = true;
            }
        }

       

        private void Save_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\work\\myproject\\Mortgage Calculator\\Mortgage Calculator\\Database1.mdf;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand("insert into Main_Table values(" + LoanAmount.Text+","+TotalTerms.Text+","+InterestRate.Text+",'"+Date.Text+"',"+Year.Text+")",con);
            int o = sc.ExecuteNonQuery();
            MessageBox.Show(o + "record has been inserted");
          
            con.Close();
        }

       
    }
}
