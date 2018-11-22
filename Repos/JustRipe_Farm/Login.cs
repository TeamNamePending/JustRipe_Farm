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
            // AS: If correct login is entered then a message box will appear with customized message
            MessageBox.Show("Correct Login, proceed!");

            

            Homepage page2 = new Homepage();
            page2.Show();
            
            this.Hide();

			
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

         //   if ( userNameInput == dgvUserLogin )

        }

        private void dgvUserLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
