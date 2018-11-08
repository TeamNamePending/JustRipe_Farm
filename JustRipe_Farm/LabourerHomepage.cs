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
	public partial class LabourerHomepage : Form
	{
		public LabourerHomepage()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//This code takes the user to the orders page (Page 6). As Ashley recomended we used 'this.close' rather 'this.hide'.

			this.Close();
			Orders page6 = new Orders();
			page6.Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			//This code takes the user to the Vehicle page (Page5). As Ashley recomended we used 'this.close' rather 'this.hide'.

			this.Close();
			Vehicle page5 = new Vehicle();
			page5.Show();
		}

		private void Storage_Click(object sender, EventArgs e)
		{
			//this takes the user to the storage page (page4). As Ashley recomended we used 'this.close' rather 'this.hide'.

			this.Close();
			Storage page4 = new Storage();
			page4.Show();
		}


		private void button1_Click_2(object sender, EventArgs e)
		{
			// Takes the user to page. which is the crops page (Page3). As Ashley recomended we used 'this.close' rather 'this.hide'.
			this.Close();
			Crops page3 = new Crops();
			page3.Show();
		}

		private void Fertiliser_Click(object sender, EventArgs e)
		{
			//This takes the user to the fertiliser page (page7). As Ashley recomended i used 'this.close' rather then 'this.hide'.
			this.Close();
			Fertilisier page7 = new Fertilisier();
			page7.Show();
		}
	}
}
