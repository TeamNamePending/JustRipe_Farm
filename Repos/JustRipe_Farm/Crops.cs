using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// for the timers
using System.Timers;

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

        // SETTING UP TIMERS FOR CROPS

        // Timer, once elapsed will call method initializing new crops
        private static System.Timers.Timer createCropTimer;

        // Timer, once elapsed will call method, prompting user and pausing the harvest timer until the crop is treated
        private static System.Timers.Timer treatmentTimer;

        // Timer, once elapsed will call method, prompting user that the crop is ready to be harvested
        private static System.Timers.Timer harvestTimer;

        // SETTING UP INT VARIABLES FOR THE TIMING, STORAGE TEMPERATURE AND CROP NUMBER

        // this will store the treatment time, in milliseconds
        int treatmentTime;

        // this will store the harvest time, in milliseconds
        int harvestTime;

        // this will store the storage temperature, in degrees.
        int storageTemperature;

        int cropNumber;

        // CREATING STRINGS AND LISTS.

        // choose the fertilizer type ( temporarily a, b and c) which will be chosen at random in the constructor.
        char[] FertilizerTypes = { 'a', 'b', 'c'};

        char fertilizerType;

        // list to store crops and it's attributes
        List<CropAttributes> crops = new List<CropAttributes>();


        // Constructor method for crops. This method will be called when the createCropTimer elapses

        public Crops(int cropID)
        {
            cropNumber = cropID;

            // Setting up the random, use this to select random treatment, harvest, fertilizer type and storage temperature
            Random random = new Random();
            // Treatment time will be between 4000,9000 in milliseconds
            treatmentTime = random.Next(4000, 9000);

            // Harvest time will be between 20000 and 60000 in milliseconds
            harvestTime = random.Next(20000, 60000);

            storageTemperature = random.Next(-10, 10);

            // this will select a random fertilizer type from the array and assign to each crop
            fertilizerType = FertilizerTypes[random.Next(FertilizerTypes.Length)];


            // Intend to use this to assign fertilizer type to crop. IF THIS IS NEEDED
            switch (fertilizerType)
            {
                case 'a':



                break;


                      case 'b':


                      break;

                case 'c':

                    break;
            }

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
