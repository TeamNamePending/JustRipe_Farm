using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


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
        // Have to use public static, otherwise will have errors when using this in the update function
        public static int treatmentTime;

        // this will store the harvest time, in milliseconds
        public static int harvestTime;

        // this will store the storage temperature, in degrees.
        public static float storageTemperature;


        public static int cropNumber;

        // CREATING STRINGS AND LISTS.

        // choose the fertilizer type ( temporarily a, b and c) which will be chosen at random in the constructor.
        char[] FertilizerTypes = { 'a', 'b', 'c' };
        string[] RequirementMethods = { "Method A", "Method B", "Method C" };
        string[] StorageTypes = { "Storage A", "Storage B", "Storage C" };

        char fertilizerType;
        public static string requirementMethod;
        public static string storageType;

        // Date time
        DateTime currentDateTime = DateTime.Now;
        DateTime harvestDateTime;
        DateTime treatmentDateTime;

        

        // list to store crops and it's attributes
        public static List<CropAttributes> crops = new List<CropAttributes>();


        // Constructor method for crops. This method will be called when the createCropTimer elapses

        public void CropsInit(int ID)
        {
            cropNumber = ID;

            cropNumber++;

            // Setting up the random, use this to select random treatment, harvest, fertilizer type and storage temperature
            Random random = new Random();


            // For the treatment time will be one day from the current time, when the crop is planted
            treatmentDateTime = currentDateTime.AddDays(+1);

            // Harvest time will be three days from the current time, when the crop is planted
            harvestDateTime = currentDateTime.AddDays(+3);

            

          

            storageTemperature = random.Next(-10, 10);

            // this will select a random fertilizer type from the array and assign to each crop
            fertilizerType = FertilizerTypes[random.Next(FertilizerTypes.Length)];

            requirementMethod = RequirementMethods[random.Next(RequirementMethods.Length)];

            storageType = StorageTypes[random.Next(StorageTypes.Length)];

            // here call function

            //  UpdateCrops();
            // DisplayCropTotal();


            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnectDatabase;
            connection.Open();

            SqlCommand sqlAdd = new SqlCommand("INSERT INTO Crops (Temperature, TreatmentTime, HarvestTime) VALUES ( @cropValue, @treatTime, @harvTime); ", connection);

            
            // must remember to change the datatype in the database Crops table for these, so they display date that reflects this
            sqlAdd.Parameters.AddWithValue("@cropValue", storageTemperature);
            sqlAdd.Parameters.AddWithValue("@treatTime", treatmentDateTime);
            sqlAdd.Parameters.AddWithValue("@harvTime", harvestDateTime);
            sqlAdd.ExecuteNonQuery();


        }

        private void UpdateCrops()
        {   // a suggestion as a potential fix, before I was getting an error on line 98 when call UpdateCrops method
            // something about no arguement given that corresponds to the required formal parameter
            throw new NotImplementedException();
        }

        public static void UpdateCrops(CropAttributes cropAttributes)

        {
            

            cropAttributes.cropID = cropNumber;
            cropAttributes.requiredMethods = requirementMethod;
            cropAttributes.treatmentTime = treatmentTime;
            cropAttributes.harvestTime = harvestTime;
        //    cropAttributes.storageTemperature = storageTemperature;
            cropAttributes.storageType = storageType;

            crops.Add(cropAttributes);
        }

        public static void DisplayCropTotal()
   
        {
            foreach (var ca in crops)
                Console.WriteLine("crop no{0}, required method is:{1}, treatment time ( in milliseconds) is:{2}, harvest time ( in milliseconds) is:{3}, storage Temperature(in degrees){4},storage type{5}", ca.cropID, ca.requiredMethods, ca.treatmentTime, ca.harvestTime, ca.storageTemperature, ca.storageType);



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
            // Confirmation that the user has logged out of the system
            MessageBox.Show("You have successfully logged out.");

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          

            CropsInit(8);
            
        }


    }
}
