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
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
        {





        }

        private string connectionString;


        // acting as the connection to SQL server Database,  the SqlConnection is the constructor, new instance of the class
        System.Data.SqlClient.SqlConnection connectToDataBase;


        // creating an instance of the SqlDataAdapter class- we need  data adapter which enables communcation between dataSet and dataSource
        System.Data.SqlClient.SqlDataAdapter dataAdapter;

        // set up constructor here

            public void databaseConnection(string connectionString)
        {
            this.connectionString = connectionString;

        }

        // Open Database connection
        public void openConnection()
        {
            // creating the Database connection  will be a new instance
            connectToDataBase = new
                  System.Data.SqlClient.SqlConnection(connectionString);
        
            //  Opening the connection
            connectToDataBase.Open();
      
        }  // end of method for opening the connection


        // Close Database connection
        public void closeConnection()
        {
            connectToDataBase.Close();

        }


        

    }
    

}
