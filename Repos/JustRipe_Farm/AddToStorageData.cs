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
	public partial class AddToStorageData : Form
	{
		public AddToStorageData()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
			Storage page4 = new Storage();
			page4.Show();

		}

		private void Reset_Txt_Click(object sender, EventArgs e)
		{
			//Empties all the texts boxes in the form
			this.textBox1.Text = "";	//textBox1 = CustomerID
			this.textBox2.Text = "";	//textBox2 = Type
			this.textBox3.Text = "";	//textBox3 = Size
			this.textBox4.Text = "";    //textBox4 = Price
			this.textBox5.Text = "";    //textBox5 = Latitude
			this.textBox6.Text = "";	//textBox6 = Longitude
			this.textBox7.Text = "";	//textBox7 = Availability
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlConnection connection;
			using (new SqlConnection(Properties.Settings.Default.ConnectDatabase))
			{

			}

		}
	}
}
