using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter DB=new SqlDataAdapter();
       

        public SignUp()
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" && txtEmail.Text == "" && txtPassword.Text == "" && txtConf.Text == "")
            {
                MessageBox.Show("Please Enter the required information", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConf.Text)
            {

                SqlConnection sqlConnection = new SqlConnection("Data Source =.; Initial Catalog = Games_Rental_System; Integrated Security = True");
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.CommandText = "INSERT INTO CLIENT_ACCOUNT VALUES ('" + txtUser.Text + "','" + txtEmail + "','" + txtPassword + "')";
                sqlConnection.Close();

                txtUser.Text = "";
                txtPassword.Text = "";
                txtConf.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";

                MessageBox.Show("Registeration has been successfully", "Registeration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password doesn't match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUser.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
                txtConf.Text = "";
                txtPassword.Focus();
            }
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtConf.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtUser.Focus();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (txtUser.Text == "" && txtEmail.Text == "" && txtPassword.Text == "" && txtConf.Text == "")
            {
                MessageBox.Show("Please Enter the required information", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConf.Text)
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source =.; Initial Catalog = Games_Rental_System; Integrated Security = True");
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.CommandText = "INSERT INTO ADMIN_ACCOUNT VALUES ('" + txtUser.Text + "','" + txtEmail + "','" + txtPassword + "')";
                sqlConnection.Close();

                txtUser.Text = "";
                txtPassword.Text = "";
                txtConf.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";

                MessageBox.Show("Registeration has been successfully", "Registeration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password doesn't match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUser.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
                txtConf.Text = "";
                txtPassword.Focus();
            }
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
