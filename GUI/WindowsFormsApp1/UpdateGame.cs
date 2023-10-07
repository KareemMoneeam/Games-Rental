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
    public partial class UpdateGame : Form
    {
        public UpdateGame()
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
                sqlCommand.CommandText = "UPDATE UPDATEGAMEDETAIL SET VALUES ('" + AdminID.Text + "','" + GameID.Text + "','" + PlatForm.Text + "','" + Category.Text + "','" + GameName.Text + "')";
                sqlConnection.Close();

                MessageBox.Show("Updating has been successfully", "UPDATING Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (AdminID.Text == "" && GameID.Text == "" && PlatForm.Text == "" && Category.Text == "" && GameName.Text == "")
            {
                MessageBox.Show("Please Enter the required information", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlConnection sqlConnection = new SqlConnection("Data Source =.; Initial Catalog = Games_Rental_System; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM UPDATEGAMEDETAIL WHERE ('" + GameName.Text + "')";
            sqlConnection.Close();

            MessageBox.Show("Deletion has been successfully", "DELETION Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.uPDATEGAMEDETAILSTableAdapter.Fill(this.games_Rental_SystemDataSet.UPDATEGAMEDETAILS);

        }

        private void UpdateGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'games_Rental_SystemDataSet.UPDATEGAMEDETAILS' table. You can move, or remove it, as needed.
            this.uPDATEGAMEDETAILSTableAdapter.Fill(this.games_Rental_SystemDataSet.UPDATEGAMEDETAILS);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
