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
			// Log off
			this.Hide();
			Login page1 = new Login();
			page1.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Takes the user to page. which is the crops page
			this.Hide();
			Crops page3 = new Crops();
			page3.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//this takes the user to the storage page (page4)
			this.Hide();
			Storage page4 = new Storage();
			page4.Show();
		
		}
	}
}
