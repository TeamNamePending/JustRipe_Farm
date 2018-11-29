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
    public partial class AddToVehicleData : Form
    {
        public AddToVehicleData()
        {
            InitializeComponent();
        }
        

        private void load_dgvUpdateVehicleData()
        {
            //doesnt work
          //  DataSet ds = DatabaseCode._instance().getDataSet("SELECT * FROM Vehicles");
           // dgvUpdateVehicleData.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //doesnt work 
            //DataSet ds = DatabaseCode._instance().getDataSet("SELECT * FROM Vehicles");
            //dgvUpdateVehicleData.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this code take the user back to the homepage
            this.Hide();
            Homepage page2 = new Homepage();
            page2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Confirmation that the user has logged out of the system
            MessageBox.Show("You have successfully logged out.");

            Login page1 = new Login();

            page1.Show();
            this.Close();
        }
    }
}
