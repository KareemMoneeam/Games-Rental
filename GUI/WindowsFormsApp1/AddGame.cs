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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdminID.Text == "" && GameID.Text == "" && PlatForm.Text == "" && Category.Text == "" && GameName.Text == "")
            {
                MessageBox.Show("Please Enter the required information", "Adding Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlConnection sqlConnection = new SqlConnection("Data Source =.; Initial Catalog = Games_Rental_System; Integrated Security = True");
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.CommandText = "INSERT INTO UPDATEGAMEDETAILS VALUES ('" + AdminID.Text + "','" + GameID.Text + "','" + PlatForm.Text + "','" + Category.Text + "','" + GameName.Text + "','"+textBox1.Text+"')";
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Adding has been successfully", "Adding Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            AdminID.Text = "";
            GameID.Text = "";
            PlatForm.Text = "";
            Category.Text = "";
            GameName.Text = "";

            AdminID.Focus();
        }

        private void AddGame_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.uPDATEGAMEDETAILSTableAdapter.Fill(this.games_Rental_SystemDataSet.UPDATEGAMEDETAILS);
        }

    }
}
