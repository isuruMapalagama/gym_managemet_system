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
    public partial class view_equipment : Form
    {
        public view_equipment()
        {
            InitializeComponent();
        }

        private void view_equipment_Load(object sender, EventArgs e)
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management;";
            string Query = "SELECT * FROM equipment";
            MySqlConnection database_con = new MySqlConnection(connection);

            DataSet ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(Query, database_con);
                da.Fill(ds);

                database_con.Open();
                dataGridView1.DataSource = ds.Tables[0];
                database_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
