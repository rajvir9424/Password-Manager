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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rajvi\source\repos\ATM\ATM\db\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                acpasstxt.IsPassword = false;
            }

            else
            {
                acpasstxt.IsPassword = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            displaydata();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into PassmanagerTable values ('" + Labeltxt.TextName + "','" + acnametxt.TextName + "','" + acpasstxt.TextName + "','" + urltxt.TextName + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata();

            MessageBox.Show("Added");

            Labeltxt.TextName = "Label";
            acnametxt.TextName = "Username";
            acpasstxt.TextName = "Password";
            urltxt.TextName = "Website Url";

           
        }

        private void displaydata()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PassmanagerTable";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;



            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Labeltxt.TextName = row.Cells["Label"].Value.ToString();
                acnametxt.TextName = row.Cells["Username"].Value.ToString();
                acpasstxt.TextName = row.Cells["Password"].Value.ToString();
                urltxt.TextName = row.Cells["Url"].Value.ToString();

               

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from PassmanagerTable where Label = '" + Labeltxt.TextName + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displaydata();

            MessageBox.Show("Deleted");

            Labeltxt.TextName = "Label";
            acnametxt.TextName = "Username";
            acpasstxt.TextName = "Password";
            urltxt.TextName = "Website Url";
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PassmanagerTable";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;



            con.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PassmanagerTable where Label = '" + searchtxt.TextName + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

            searchtxt.TextName = "Search";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "update PassmanagerTable set Username = '" + acnametxt.TextName + "',Password='" + acpasstxt.TextName+ "',Url='" + urltxt.TextName + "' where Label = '" +Labeltxt.TextName+"'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            displaydata();

            MessageBox.Show("Updated Successfully");



            Labeltxt.TextName = "Label";
            acnametxt.TextName = "Username";
            acpasstxt.TextName = "Password";
            urltxt.TextName = "Website Url";


        }
    }
}
