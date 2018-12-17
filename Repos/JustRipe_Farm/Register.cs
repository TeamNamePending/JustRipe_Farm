using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace JustRipe_Farm
{
    public partial class Register : Form
    {
        private string encryptedPwd;
        public Register()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
            textBox2.MaxLength = 15;
            textBox3.MaxLength = 15;


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
            userNameInput = textBox1.Text;


        }

        private void Load_dgvUserInfo()
        {
            DataSet ds = DatabaseCode._instance().getDataSet("SELECT * FROM UserInfo;");
            dataGridView1.DataSource = ds.Tables[0];

        }



        // if put static will get an error  when put in SqlCommand  the variable name
        private void InitializeDatabase()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnectDatabase;
            connection.Open();

            SqlCommand sql = new SqlCommand(UserNameExist, connection);
           // SqlCommand password = new SqlCommand(passwordInput, connection);
            //SqlCommand rePassword = new SqlCommand(confirmPasswordInput, connection);

            sql.Parameters.Add(new SqlParameter("NewUsername", textBox1.Text));

         //   if (string.IsNullOrEmpty(encryptedPwd))
       //     {
       //         sql.Parameters.AddWithValue("@pwd", DBNull.Value);
        //    }
         //   else
        //    {  // if i have encryptedPwd I will get error as seem to think it is null
                sql.Parameters.Add(new SqlParameter("pwd", passwordInput));
          //  }

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

            CheckPasswordValid();
            Encryption(textBox1.Text);

        }

        
        public String CreateSalt(int saltSize)
        {
            var range = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var size = new byte[saltSize];
            range.GetBytes(size);
            return Convert.ToBase64String(size);

        }

        public String GenerateSHA256Hash(string salt, string input)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed hashString = new System.Security.Cryptography.SHA256Managed();

            byte[] hash = hashString.ComputeHash(bytes);

            return ByteArrayToHexString(hash);

        }

        static string getMD5Hash(System.Security.Cryptography.MD5 md5Hash, string input)
        {
            byte[] info =  md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for ( int i = 0; i < info.Length; i++)
            {
                sBuilder.Append(info[i].ToString(" x2"));
            }
            return sBuilder.ToString();

        }

        public  static String ByteArrayToHexString(byte[] b)
        {
            StringBuilder hex = new StringBuilder(b.Length * 2);
            
            foreach(byte by in b)
            {
                hex.AppendFormat("{0:x2}", b);
            }

            return hex.ToString();
        }

        public static byte[] HexStringToByte(string hex)
        {
          int charNumbers = hex.Length;
            byte[] bytes = new byte[charNumbers / 2];

            for ( int i = 0; i < charNumbers; i += 2)
            {
                bytes[1 / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }



        public void CheckPasswordValid()
        {
             int MINIMUM_LENGTH  = 6;
             
            int numberCount = 0;
            int upperCount = 0;

            // checking password meets the minimum length
            if (passwordInput.Length >= MINIMUM_LENGTH )
            { 
                // if yes, then carry on

              
                
                    for ( int i = 0; i < passwordInput.Length; i++)
                    {
                        if (char.IsUpper(passwordInput[i])) upperCount++;
                        if (char.IsDigit(passwordInput[i])) numberCount++;

                    }
                    if (upperCount >= 1)
                    {
                        if (numberCount >= 1)
                        {
                            if (passwordInput == confirmPasswordInput)
                            {
                                MessageBox.Show("Account registered!");
                                    passwordInput =  Encryption(passwordInput);
                                    AddToDatabase();
                                    Load_dgvUserInfo();

                            }
                            else MessageBox.Show("Passwords do not match");

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


        static string Encryption( string s )
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 =  new UTF8Encoding();
                byte[] info = md5.ComputeHash(utf8.GetBytes(s));

                return Convert.ToBase64String(info);


            }



        }

        public void AddToDatabase()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnectDatabase;
            connection.Open();

            SqlCommand sqlAdd = new SqlCommand("INSERT INTO UserInfo (Username, Password) VALUES (@username, @password) ", connection);

            // must remember to change the datatype in the database Crops table for these, so they display date that reflects this

            
            
            
            sqlAdd.Parameters.AddWithValue("@username", userNameInput);
            sqlAdd.Parameters.AddWithValue("@password", passwordInput);
            

            sqlAdd.ExecuteNonQuery();

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
           passwordInput = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            confirmPasswordInput = textBox3.Text; ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

                
            Login page1 = new Login();
            page1.Show();
        }
    }
}
