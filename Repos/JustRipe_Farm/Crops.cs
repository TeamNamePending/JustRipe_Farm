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
	public partial class Crops : Form
	{
		public Crops()
		{
			InitializeComponent();
            load_dgvCrops();
		}

        private void load_dgvCrops()
        {
            DataSet ds = DatabaseCode._instance().getDataSet("SELECT * FROM Crops");
            dgvCrops.DataSource = ds.Tables[0];
        }

        // this will store the treatment time, in milliseconds
        int treatmentTime;

        // this will store the harvest time, in milliseconds
        int harvestTime;

        // this will store the storage temperature, in degrees.
        int storageTemperature;

        int cropNumber;

        // choose the fertilizer type ( temporarily a, b and c) which will be chosen at random in the constructor.
        string[] FertilizerType = { "a", "b", "c" };

        

        // Constructor method for crops

        public Crops(int cropID)
        {
            cropNumber = cropID;

            // Setting up the random, use this to select random treatment, harvest, fertilizer type and storage temperature
            Random random = new Random();
            // Treatment time will be between 4000,9000 in milliseconds
            treatmentTime = random.Next(4000, 9000);

            // Harvest time will be between 20000 and 60000 in milliseconds
            harvestTime = random.Next(20000, 60000);


         
        }


        private void button1_Click(object sender, EventArgs e)
		{
			//this code is for the Homepage button. Takes the user back to the homepage
			this.Hide();
			Homepage page2 = new Homepage();
			page2.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}

        private void button2_Click_1(object sender, EventArgs e)
        {
            // creating instance of Login class
            Login page1 = new Login();

            // taking user back to login page
            page1.Show();

            // closing current page
            this.Close();
        }

        private void dgvCrops_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Crops_Load(object sender, EventArgs e)
        {

        }
    }
}
