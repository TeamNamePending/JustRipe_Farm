using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRipe_Farm
{
    public partial class Harvesting : Form
    {
        public Harvesting()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // maybe need to do a check to make sure that labourer is available and only assign if possible
            MessageBox.Show("Labourer successfully assigned!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerHomePage managerMenu = new ManagerHomePage();

            managerMenu.Show();

            this.Close();


        }

        private void Harvesting_Load(object sender, EventArgs e)
        {
            // For datagrid view, need an SQL command- to show all the data in the Crops, Harvest date column
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login page1 = new Login();

            page1.Show();

            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
