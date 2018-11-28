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
    public partial class New_Order : Form
    {
        public New_Order()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DatabaseCode.getdatabaseConnection().insert(SQL.Insert,
                                                    //Cust_ID_Txt.Text,
                                                    //Order_Info_Txt.Text,
                                                    //Total_Cost_Txt.Text,
                                                    //Item_Count_Txt.Text);

            MessageBox.Show("Saved!");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
