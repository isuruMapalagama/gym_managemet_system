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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace gymManagement1
{
    public partial class search_member : Form
    {
        public search_member()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management;";
            string Query = "SELECT * FROM new_member WHERE user_id = " + searchM.Text + "";
            MySqlConnection database_con = new MySqlConnection(connection);

            DataSet ds = new DataSet();
            if (searchM.Text != "")
            {
                MySqlDataAdapter da = new MySqlDataAdapter(Query, database_con);
                da.Fill(ds);

                database_con.Open();
                dataGridView1.DataSource = ds.Tables[0];
                database_con.Close();
            }
            else
            {
                MessageBox.Show("Please Enter ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void search_member_Load(object sender, EventArgs e)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management;";
            string Query = "SELECT * FROM new_member";
            MySqlConnection database_con = new MySqlConnection(connection);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(Query, database_con);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }    
    }
 }
