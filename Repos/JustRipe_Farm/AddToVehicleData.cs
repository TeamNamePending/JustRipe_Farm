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
            DataSet ds = DatabaseCode._instance().getDataSet("SELECT * FROM Vehicles");
            dgvUpdateVehicleData.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataSet ds = DatabaseCode._instance().getDataSet("SELECT * FROM Vehicles");
            //dgvUpdateVehicleData.DataSource = ds.Tables[0];

        }
    }
}
