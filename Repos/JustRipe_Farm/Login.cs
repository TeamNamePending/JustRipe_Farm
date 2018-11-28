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
	public partial class Login : Form
	{
        string userNameInput;
        string jobTypeCheck = "select userType from UserInfo where (userType == Manager)";

        string passwordInput;      

        

        string validPasswordCheck = "select * from UserInfo where Username like @Username and Password like @Password";

        



        private void load_dgvUserInfo()
        {
            DataSet ds = DatabaseCode._instance().getDataSet("SELECT * FROM UserInfo");
            dgvUserLogin.DataSource = ds.Tables[0]; 

        }
  
		public Login()
		{
			InitializeComponent();

            // To protect the password that the user enters into the text box
            textBox2.PasswordChar = '*';

            // Can limit the length of the password that the user enters
            textBox2.MaxLength = 15;
        }

		private void button1_Click(object sender, EventArgs e)
		{
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.ConnectDatabase;
            connection.Open();

            
            string validUserCheck = "select UserID from Userinfo where Username = @Username AND Password = @pwd; ";
            

            SqlCommand sql = new SqlCommand(validUserCheck, connection);
            SqlCommand userMenu = new SqlCommand(jobTypeCheck, connection);

            sql.Parameters.Add(new SqlParameter("Username", textBox1.Text));
            sql.Parameters.Add(new SqlParameter("pwd", textBox2.Text));

            SqlDataReader dr= sql.ExecuteReader();

            DataSet ds = new DataSet();

            ds.Load(dr, LoadOption.PreserveChanges, "UserInfo");

            dgvUserLogin.DataSource = ds.Tables[0];  // ds.Rows?
            // if there is one row in the table then the credentials are correct


            if (ds.Tables[0].Rows.Count == 1 )

            {
                MessageBox.Show("Correct login, proceed!");

                // I realise this may not be the most efficient way to check to see if this is the manager or not
                // So if there is time can try to optimize so able to check if UserID == 1, which we know is manager
                if (textBox1.Text == "Mark")
                {
                    ManagerHomePage managerMenu = new ManagerHomePage();
                    managerMenu.Show();

                    this.Hide();

                }

                // If it isn't manager it is labourer, and the labourer menu will be displayed
                else
                {
                    Homepage page2 = new Homepage();
                    page2.Show();

                    this.Hide();
                }


            }

            else
            {
                MessageBox.Show("Incorrect credentials, please try again");

            }
            
            












        }

        private void button2_Click(object sender, EventArgs e)
        {
            // AS: Closing the program
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {          
            userNameInput = Console.ReadLine();

            
            // else then it's labourer
        }

        private void dgvUserLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            passwordInput = Console.ReadLine();

        }
    }
}
