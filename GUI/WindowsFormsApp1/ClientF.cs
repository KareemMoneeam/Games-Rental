using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClientF : Form
    {
        public ClientF()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Games_Rental_SystemEntities1 context = new Games_Rental_SystemEntities1();
            Renting r = new Renting();
            r.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Games_Rental_SystemEntities1 context = new Games_Rental_SystemEntities1();
            Return r = new Return();
            r.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
