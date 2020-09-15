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

namespace PasswordManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Signup sgn = new Signup();
            this.Hide();
            sgn.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajvi\source\repos\ATM\ATM\db\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from librarylogin_Table Where Username= '" +jMaterialTextbox1.TextName.Trim() + "' and Password= '" + jMaterialTextbox2.TextName.Trim() + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            

            if (dtbl.Rows.Count == 1)
            {

                Dashboard dsh = new Dashboard();

                this.Hide();

                dsh.Show();

            }
            else
            {
                MessageBox.Show("Incorrect login details, please try again");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {

            


        }

        private void richTextBox2_Enter(object sender, EventArgs e)
        {
          
        }

        private void richTextBox2_Leave(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                jMaterialTextbox2.IsPassword = false;
            }
            else
            {
                jMaterialTextbox2.IsPassword = true;
            }
           
        }
    }
}
