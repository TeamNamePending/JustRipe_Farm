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
	public partial class Login : Form
	{
        string userNameInput;
        string jobTypeCheck = "select userType from UserInfo where (userType == Manager)";

        string passwordInput;      

        string validUserCheck = "select * from Username where Username = @Username";

        string validPasswordCheck = "select * from UserInfo where Username like @Username and Password like @Password";





        private void load_dgvUserInfo()
        {
            DataSet ds = DatabaseCode._instance().getDataSet("SELECT * FROM UserInfo");
            dgvUserLogin.DataSource = ds.Tables[0];

        }

		public Login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            if (userNameInput == validUserCheck)
            {
                if (passwordInput == validPasswordCheck)
                {
                    // AS: If correct login is entered then a message box will appear with customized message
                    MessageBox.Show("Correct Login, proceed!");

                    if (userNameInput == jobTypeCheck)
                    {
                        ManagerHomePage managerMenu = new ManagerHomePage();
                        managerMenu.Show();

                    }
                    else
                    {
                        Homepage page2 = new Homepage();
                        page2.Show();

                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Incorrect password!");

                }

            }
            else
            {
                MessageBox.Show("Invalid username, please try again");

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

            if ( userNameInput == jobTypeCheck)
            {


            }
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
