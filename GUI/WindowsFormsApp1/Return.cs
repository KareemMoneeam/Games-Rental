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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (AdminID.Text == "" && GameID.Text == "")
            {
                MessageBox.Show("Please Enter the required information", "Adding Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlConnection sqlConnection = new SqlConnection("Data Source =.; Initial Catalog = Games_Rental_System; Integrated Security = True");
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.CommandText = "INSERT INTO RETURN VALUES ('" + AdminID.Text + "','" + GameID.Text + "')";
                sqlConnection.Close();

                MessageBox.Show("Adding has been successfully", "Adding Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.rETURNTableAdapter.Fill(this.games_Rental_SystemDataSet.RETURN);
        }
    }
}
