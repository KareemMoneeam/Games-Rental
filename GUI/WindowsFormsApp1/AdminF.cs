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
    public partial class AdminF : Form
    {
        public AdminF()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Games_Rental_SystemEntities1 context = new Games_Rental_SystemEntities1();
            AddGame f = new AddGame();
            f.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            Games_Rental_SystemEntities1 context = new Games_Rental_SystemEntities1();
            UpdateGame f = new UpdateGame();
            f.Show();
            this.Hide();
        }
    }
}
