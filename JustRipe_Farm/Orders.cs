﻿using System;
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
	public partial class Orders : Form
	{
		public Orders()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            //this code take the user back to the homepage
            // AS: Same again, this.Close() is more accurate than hide
            this.Close();
			Homepage page2 = new Homepage();
			page2.Show();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            // creating new instance of login class
            Login page1 = new Login();

            // taking user back to login page
            page1.Show();

            // closing the current ( orders) page
            this.Close();
        }
    }
}
