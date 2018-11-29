using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            SqlConnection connection;
            using( connection = new SqlConnection(Properties.Settings.Default.ConnectDatabase))
            {
                connection.Open();
                SqlCommand sqlAdd = new SqlCommand("INSERT INTO Orders (CustomerID, OrderInformation, TotalPrice, StorageRequired) VALUES (@Cust_ID_Txt, @Order_Info_Txt, @Total_Cost_Txt, @Item_Count_Txt); ", connection);

                sqlAdd.CommandType = CommandType.Text;

                sqlAdd.Parameters.AddWithValue("@Cust_ID_Txt", Cust_ID_Txt.Text);
                sqlAdd.Parameters.AddWithValue("@Order_Info_Txt", Order_Info_Txt.Text);
                sqlAdd.Parameters.AddWithValue("@Total_Cost_Txt", Total_Cost_Txt.Text);
                sqlAdd.Parameters.AddWithValue("@Item_Count_Txt", Item_Count_Txt.Text);
                int n = sqlAdd.ExecuteNonQuery();

                connection.Close();

            }

            MessageBox.Show("Completed!");
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
