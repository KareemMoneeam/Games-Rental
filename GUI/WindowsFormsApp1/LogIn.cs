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
    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Games_Rental_System; Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader rdr = null;
        public string LoginUser = null;
        string query = null;
        Games_Rental_SystemEntities1 GM = new Games_Rental_SystemEntities1();

        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Games_Rental_SystemEntities1 context = new Games_Rental_SystemEntities1();
            if (textEmail.Text != string.Empty || textPassword.Text != string.Empty)
            {
                var user = context.ADMIN_ACCOUNT.Where(a => a.A_EMAIL.Equals(textEmail.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.A_PASSWORD.Equals(textPassword.Text))
                    {
                        AdminF f = new AdminF();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password is not correct");
                    }
                }
                else
                {
                    MessageBox.Show("Email is not correct");
                }

            }
            else
            {
                MessageBox.Show("Email and Password are required");
            }
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Games_Rental_SystemEntities1 context = new Games_Rental_SystemEntities1();

            if (textEmail.Text != string.Empty || textPassword.Text != string.Empty)
            {
                var user = context.CLIENT_ACCOUNT.Where(a => a.C_EMAIL.Equals(textEmail.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.C_PASSWORD.Equals(textPassword.Text))
                    {
                        ClientF f = new ClientF();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password is not correct");
                    }
                }
                else
                {
                    MessageBox.Show("Email is not correct");
                }

            }
            else
            {
                MessageBox.Show("Email and Password are required");
            }
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Games_Rental_SystemEntities1 context = new Games_Rental_SystemEntities1();
            SignUp S = new SignUp();
            S.Show();
            this.Hide();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
