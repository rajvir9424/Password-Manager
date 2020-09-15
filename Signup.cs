using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();

            this.Hide();
            lgn.Show(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
