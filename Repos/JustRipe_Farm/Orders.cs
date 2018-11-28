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
	public partial class Orders : Form
	{
		public Orders()
		{
			InitializeComponent();
            load_dgvOrders();
		}

        private void load_dgvOrders()
        {
            DataSet ds = DatabaseCode._instance().getDataSet("SELECT * FROM Orders");
            dgvOrders.DataSource = ds.Tables[0];
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
            // Confirmation that the user has logged out of the system
            MessageBox.Show("You have successfully logged out.");

            // creating new instance of login class
            Login page1 = new Login();

            // taking user back to login page
            page1.Show();

            // closing the current ( orders) page
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            New_Order page9 = new New_Order();
            page9.Show();
        }
    }
}
