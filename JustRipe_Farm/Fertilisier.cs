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
	public partial class Fertilisier : Form
	{
		public Fertilisier()
		{
			InitializeComponent();
		}

		private void Homepage_Click(object sender, EventArgs e)
		{
			// Takes the user back to the homepage 
			this.Close();
			Homepage page2 = new Homepage();
			page2.Show();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            // creating instance of login class
            Login page1 = new Login();

            // taking user back to the login page
            page1.Show();

            // closing the current page
            this.Close();
        }
    }
}
