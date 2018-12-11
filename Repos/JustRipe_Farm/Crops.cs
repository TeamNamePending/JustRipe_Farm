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
          
        // this will store the storage temperature, in degrees.
        public static float storageTemperature;

        public static int cropNumber;

        // CREATING STRINGS AND LISTS.

        // choose the fertilizer type ( temporarily a, b and c) which will be chosen at random in the constructor.
       // char[] FertilizerTypes = { 'a', 'b', 'c' };
        string[] FertilizerTypes = { "High", "Medium", "Low" };
        string[] StorageTypes = { "Storage A", "Storage B", "Storage C" };

        string fertilizerType;
        public static string requirementMethod;
        public static string storageType;

        // Date time
        DateTime currentDateTime = DateTime.Now;
        DateTime harvestDateTime;
        DateTime treatmentDateTime;

             
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
         //   fertilizerType = FertilizerTypes[random.Next(FertilizerTypes.Length)];

            fertilizerType = FertilizerTypes[random.Next(FertilizerTypes.Length)];

            storageType = StorageTypes[random.Next(StorageTypes.Length)];

            // here call function

            //  UpdateCrops();
            // DisplayCropTotal();

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnectDatabase;
            connection.Open();

            SqlCommand sqlAdd = new SqlCommand("INSERT INTO Crops (FertiliserAmountRequired, Temperature, TreatmentTime, HarvestTime) VALUES (@fertType, @cropValue, @treatTime, @harvTime); ", connection);


            // must remember to change the datatype in the database Crops table for these, so they display date that reflects this
            sqlAdd.Parameters.AddWithValue("fertType", fertilizerType);
            sqlAdd.Parameters.AddWithValue("@cropValue", storageTemperature);
            sqlAdd.Parameters.AddWithValue("@treatTime", treatmentDateTime);
            sqlAdd.Parameters.AddWithValue("@harvTime", harvestDateTime);
            int n = sqlAdd.ExecuteNonQuery();
         
            // displaying the data, with the new entry
            load_dgvCrops();

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
            CropsInit(1);
            
        }


    }
}
