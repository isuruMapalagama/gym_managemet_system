using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace gymManagement1
{
    public partial class Delete_Member : Form
    {
        string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management;";
        public Delete_Member()
        {
            InitializeComponent();
        }

        public void populate()
        {
            string Query = "SELECT * FROM new_member";
            MySqlConnection database_con = new MySqlConnection(connection);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(Query, database_con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            string Query = "DELETE FROM new_member WHERE user_id = " + deleteM.Text + "";

            try
            {
                if (deleteM.Text != "")
                {
                    
                    DataSet ds = new DataSet();
                    MySqlConnection database_con = new MySqlConnection(connection);
                    database_con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(Query, database_con);
                    da.Fill(ds);

                    populate();
                    database_con.Close();
                    MessageBox.Show("Successfully Deleted");

                }
                else
                {
                    MessageBox.Show("Please Enter ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            //populate();
        }

        private void Delete_Member_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
