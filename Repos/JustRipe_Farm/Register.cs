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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           


        }

        // if put static will get an error  when put in SqlCommand  the variable name
        public void InitializeDatabase()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnectDatabase;
            connection.Open();

            SqlCommand sql = new SqlCommand(userNameInput, connection);
            SqlCommand password = new SqlCommand(passwordInput, connection);
            SqlCommand rePassword = new SqlCommand(confirmPasswordInput, connection);

            sql.Parameters.Add(new SqlParameter("Username", textBox1.Text));
            sql.Parameters.Add(new SqlParameter("pwd", textBox2.Text));

            SqlDataReader dr = sql.ExecuteReader();

            DataSet ds = new DataSet();

            ds.Load(dr, LoadOption.PreserveChanges, "UserInfo");

     //      dgvUserLogin.DataSource = ds.Tables[0];  // ds.Rows?

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
