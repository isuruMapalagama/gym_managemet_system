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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void equipment_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            string equipment_name = equipmentN.Text;
            string Description = description.Text;
            string Musceles = musclesU.Text;
            string Delivery = deliveryD.Text;
            int Cost = int.Parse(cost.Text);

            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management;";
            string query = "INSERT INTO equipment(`equipment_name`, `description`, `muscles_used`, `delivery_date`, `cost`, `equipment_id`) VALUES ('" + equipment_name + "','" + Description + "','" + Musceles + "','" + Delivery + "','" + Cost + "',NULL)";
            MySqlConnection database_con = new MySqlConnection(connection);

            MySqlCommand command_datab = new MySqlCommand(query, database_con);
            command_datab.CommandTimeout = 60;

            try
            {
                database_con.Open();
                MySqlDataReader myRead = command_datab.ExecuteReader();

                MessageBox.Show("New Equipment is Added !");

                database_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            equipmentN.Clear();
            description.Clear();
            musclesU.Clear();
            deliveryD.Value = DateTime.Now;
            cost.Clear();

        }

        private void viewEquip_Click(object sender, EventArgs e)
        {
            view_equipment ve = new view_equipment();
            ve.Show();
        }
    }

}
