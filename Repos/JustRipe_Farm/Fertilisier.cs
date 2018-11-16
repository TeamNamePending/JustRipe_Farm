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
        /*/public Fertiliser()  // brings an error - method needs a return type (didnt bring this error up for the other storage, crops, vehicles, orders, possibly because fertaliser page is not on homepage but on the labourer homepage?
        {
            InitializeComponent();
            load_dgvFertilisers();
        }*/

        private void load_dgvFertilisers()
        {
            DataSet ds = DatabaseCode._instance().getDataSet("SELECT * FROM Fertilisers");
            dgvFertilisers.DataSource = ds.Tables[0];
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
