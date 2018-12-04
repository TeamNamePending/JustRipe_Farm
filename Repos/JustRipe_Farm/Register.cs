﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JustRipe_Farm
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public string userNameInput;
       public  string passwordInput;
       public  string confirmPasswordInput;
       
      public string UserNameExist = "select UserID from  Userinfo where Username = @NewUsername ;";

        // SqlDataReader dr = sql.ExecuteReader();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          userNameInput = Console.ReadLine();


        }

        private void Load_dgvUserInfo()
        {
            DataSet ds = DatabaseCode._instance().getDataSet("SELECT  FROM UserInfo[Username];");
            dataGridView1.DataSource = ds.Tables[0];

        }



        // if put static will get an error  when put in SqlCommand  the variable name
        private void InitializeDatabase()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnectDatabase;
            connection.Open();

            SqlCommand sql = new SqlCommand(UserNameExist, connection);
            SqlCommand password = new SqlCommand(passwordInput, connection);
            SqlCommand rePassword = new SqlCommand(confirmPasswordInput, connection);

            sql.Parameters.Add(new SqlParameter("NewUsername", textBox1.Text));
            sql.Parameters.Add(new SqlParameter("pwd", textBox2.Text));

            SqlDataReader dr = sql.ExecuteReader();
            DataSet ds = new DataSet();
         

             ds.Load(dr, LoadOption.PreserveChanges, "UserInfo");

            dataGridView1.DataSource = ds.Tables[0];

            if (ds.Tables[0].Rows.Count == 0)
            {
                




            }
            else
            {
                MessageBox.Show("Username Already exists!");
            }

     //      dgvUserLogin.DataSource = ds.Tables[0];  // ds.Rows?
     //     dataGridView1.DataSource = ds.

        }

        public void CheckNewLogin()
        {
            


        }

        public void CheckPasswordValid()
        {
            const int MINIMUM_LENGTH  = 6;
            const int MAX_LENGTH = 15;
            int numberCount = 0;
            int upperCount = 0;

            // checking password meets the minimum length
            if (passwordInput.Length >= MINIMUM_LENGTH )
            { 
                // if yes, then carry on

              if (passwordInput.Length <= MAX_LENGTH)
                {
                    for ( int i = 0; i < passwordInput.Length; i++)
                    {
                        if (char.IsUpper(passwordInput[i])) upperCount++;
                        if (char.IsDigit(passwordInput[i])) numberCount++;

                    }
                    if (upperCount >= 1)
                    {
                        if (numberCount >= 1)
                        {

                        }
                        else
                        {
                            MessageBox.Show("You have not used any numbers, please use atleast one number");

                        }

                    }
                    else
                    {
                        MessageBox.Show("You have not used any Upper case, please use atleast one");
                    }
                }
              else
                {
                    MessageBox.Show("Password is too long, please enter between 6 to 15 digits");
                }

            }
            else
            {
                MessageBox.Show("Password is too short, please enter between 6 to 15 digits");
            }

        }


        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeDatabase();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}