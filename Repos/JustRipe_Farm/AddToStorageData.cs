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
			//Empties all the texts boxes in the AddToStorageData

			this.Typ_Txt.Text = "";		//Type
			this.Siz_Txt.Text = "";		//Size
			this.Pri_Txt.Text = "";		//Price
			this.Long_Txt.Text = "";    //Latitude
			this.Lat_Txt.Text = "";		//Longitude
			this.Avab_Txt.Text = "";    //Availability
			this.textBox1.Text = ""; //StorageId
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlConnection connection;
			using (connection = new SqlConnection(Properties.Settings.Default.ConnectDatabase))
			{
				connection.Open();
				SqlCommand sqlAdd = new SqlCommand("Insert into Storage (StorageId, Type, Size, Price, Longitude, Latitude, Availability) VALUES (@textBox1, @Typ_Txt, @Siz_Txt, @Pri_Txt, @Long_Txt, @Lat_Txt, @Avab_Txt); ", connection);
				sqlAdd.CommandType = CommandType.Text;

				//this code allows user to add new storage to the database

				sqlAdd.Parameters.AddWithValue("@textBox1", textBox1.Text);
				sqlAdd.Parameters.AddWithValue("@Typ_Txt", Typ_Txt.Text);
				sqlAdd.Parameters.AddWithValue("@Siz_Txt", Siz_Txt.Text);
				sqlAdd.Parameters.AddWithValue("@Pri_Txt", Pri_Txt.Text);
				sqlAdd.Parameters.AddWithValue("@Long_Txt", Long_Txt.Text);
				sqlAdd.Parameters.AddWithValue("@lat_Txt", Lat_Txt.Text);
				sqlAdd.Parameters.AddWithValue("@Avab_Txt", Avab_Txt.Text);

				int n = sqlAdd.ExecuteNonQuery();

				connection.Close();
				// Deletes text written 
				this.Typ_Txt.Text = "";     //Type
				this.Siz_Txt.Text = "";     //Size
				this.Pri_Txt.Text = "";     //Price
				this.Long_Txt.Text = "";    //Latitude
				this.Lat_Txt.Text = "";     //Longitude
				this.Avab_Txt.Text = "";    //Availability
				this.textBox1.Text = ""; //StorageId


			}

		}
	}
}
