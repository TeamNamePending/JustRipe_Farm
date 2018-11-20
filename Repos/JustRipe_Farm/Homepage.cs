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
	public partial class Homepage : Form
	{
		public Homepage()
		{
			InitializeComponent();
		}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
            // Log off (Page 1)
            // AS: I think it should be this.Close  NOT this.Hide, I think one of the mistakes I noticed
            // AS: because it is better to use this.Close  since  this.Hide just makes it invisible to the user
            // AS: Close  will actually close it and so the system should run quicker

            // Confirmation that the user has logged out of the system
            MessageBox.Show("You have successfully logged out.");

            this.Close();
			Login page1 = new Login();
			page1.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Takes the user to page. which is the crops page (Page3)
            // AS: As above, this.Close() is more accurate
			this.Close();
			Crops page3 = new Crops();
			page3.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
            //this takes the user to the storage page (page4)
            // AS: As above, this.Close() is more accurate
            this.Close();
			Storage page4 = new Storage();
			page4.Show();
		
		}

		private void button4_Click(object sender, EventArgs e)
		{
            //This code takes the user to the Vehicle page (Page5)
            // AS: As above, this.Close() is more accurate
            this.Close();
			Vehicle page5 = new Vehicle();
			page5.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
            //This code takes the user to the orders page (Page 6)
            // AS: As above, this.Close() is more accurate
            this.Close();
			Orders page6 = new Orders();
			page6.Show();
		}

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
