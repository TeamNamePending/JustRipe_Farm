    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipe_Farm
{
    class DatabaseCode
    {

       

       
        private static string connectionString;
        private static DatabaseCode databaseCode;


        // acting as the connection to SQL server Database,  the SqlConnection is the constructor, new instance of the class
        System.Data.SqlClient.SqlConnection connectToDataBase;


        // creating an instance of the SqlDataAdapter class- we need  data adapter which enables communcation between dataSet and dataSource
        System.Data.SqlClient.SqlDataAdapter dataAdapter;

        public static string ConnectionString {set => connectionString = value; }

        // set up constructor here

        public static DatabaseCode _instance()
        {

            if (databaseCode == null)
                databaseCode = new DatabaseCode();

            return databaseCode;
        }

        // METHODS

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

        // Method to retrieve the data generated from SQL statements. DataSet class represent in memory collection of data
        public DataSet getDataSet(string sqlStatement)  // name of method getDataSet
        {
            // creating an instance of the DataSet class
            DataSet dataSet;

            openConnection();

            // creating an object to use a table from Database, the DataAdapter will enable communication between datasource and dataset
            dataAdapter = new System.Data.SqlClient.SqlDataAdapter(sqlStatement, connectToDataBase);

            // creating the Dataset
            dataSet = new System.Data.DataSet();

            // .Fill method will fill the dataSet with data. It can add or refresh rows, in a specific range in DataSet, to match that in the DataSource
            //  using DataSet and source table names
            dataAdapter.Fill(dataSet);
            dataAdapter.Update(dataSet);

            //  ending the method, return needs to be used otherwise will get an error with the code not returning a value
            //  as void is not being used,  return needs to be used.

            closeConnection();

            return dataSet;

            // end of method
        }

       


    }
}
