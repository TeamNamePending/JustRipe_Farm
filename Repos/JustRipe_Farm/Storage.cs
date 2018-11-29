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
	public partial class Storage : Form
	{
		public Storage()
		{
			InitializeComponent();
            load_dgvStorage();
        }

        private void load_dgvStorage()
        {
            DataSet ds = DatabaseCode._instance().getDataSet("SELECT * FROM Storage");
            dgvStorage.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
		{
            // AS: Same again, this.Close() is more accurate than hide
            this.Close();
			Homepage page2 = new Homepage();
			page2.Show();
		}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Confirmation that the user has logged out of the system
            MessageBox.Show("You have successfully logged out.");

            // creating new instance of login class
            Login page1 = new Login();

            // Taking user back to login page
            page1.Show();

            // Closing the current ( storage) 
            this.Close();
        }

        private void dgvStorage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void Update_Click(object sender, EventArgs e)
		{
			//this closes the storage page to open a new form where the user can add new data to the database.
			this.Close();
			AddToStorageData page13 = new AddToStorageData();
			page13.Show();

		}
	}
}
