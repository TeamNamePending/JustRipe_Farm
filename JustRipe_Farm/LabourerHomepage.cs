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
			//This code takes the user to the orders page (Page 6)
			
			this.Close();
			Orders page6 = new Orders();
			page6.Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			//This code takes the user to the Vehicle page (Page5)
		
			this.Close();
			Vehicle page5 = new Vehicle();
			page5.Show();
		}

	}
}
