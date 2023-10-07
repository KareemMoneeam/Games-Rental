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
    public partial class Renting : Form
    {
        public Renting()
        {
            InitializeComponent();
        }

        private void Renting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'games_Rental_SystemDataSet.RENT' table. You can move, or remove it, as needed.
            this.rENTTableAdapter.Fill(this.games_Rental_SystemDataSet.RENT);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (GameID.Text == "" && ClientID.Text == "" && Date.Text == "" )
            {
                MessageBox.Show("Please Enter the required information", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlConnection sqlConnection = new SqlConnection("Data Source =.; Initial Catalog = Games_Rental_System; Integrated Security = True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM RENT WHERE ('" + GameID.Text + "')";
            sqlConnection.Close();

            MessageBox.Show("Deletion has been successfully", "DELETION Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.rENTTableAdapter.Fill(this.games_Rental_SystemDataSet.RENT);

        }
    }
}
