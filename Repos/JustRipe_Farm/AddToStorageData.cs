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
			this.textBox1.Text = "";
			this.textBox2.Text = "";
			this.textBox3.Text = "";
			this.textBox4.Text = "";
		}
	}
}
