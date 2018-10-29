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
	public partial class Login : Form
	{
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

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
