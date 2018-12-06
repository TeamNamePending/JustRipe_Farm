using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JustRipe_Farm
{
    public partial class Update_Order : Form
    {
        public Update_Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            using (connection = new SqlConnection(Properties.Settings.Default.ConnectDatabase))
            {
                connection.Open();
                SqlCommand sqlAdd = new SqlCommand("UPDATE Orders SET Completed = @Order_Status_Txt WHERE OrderID =  @Order_ID_Txt", connection);

                sqlAdd.CommandType = CommandType.Text;

                sqlAdd.Parameters.AddWithValue("@Order_ID_Txt", Order_ID_Txt.Text);
                sqlAdd.Parameters.AddWithValue("@Order_Status_Txt", Order_Status_Txt.Text);
                int n = sqlAdd.ExecuteNonQuery();

                connection.Close();
            }


                MessageBox.Show("Updated!");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
