using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace gymManagement1
{
    public partial class New_Staff : Form
    {
        public New_Staff()
        {
            InitializeComponent();
        }

        private void New_Staff_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string f_name = fname.Text;
            string l_name = lname.Text;

            string gender = "";

            bool isChacked = radioButton1.Checked;
            if (isChacked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            String dob = DoB.Text;
            Int64 mobile_no = Int64.Parse(mobile.Text);
            String e_mail = email.Text;
            String join_Date = JoinD.Text;
            String State = state.Text;
            String City = city.Text;

            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management;";
            string query = "INSERT INTO new_staff(`first_name`, `last_name`, `gender`, `date_of_birth`, `mobile`, `e_mail`, `join_date`, `state`, `city`, `staff_id`) VALUES('" + f_name + " ', '" + l_name + "', '" + gender + "', '" + dob + "', '" + mobile_no + "', '" + e_mail + "', '" + join_Date + "', '" + State + "', '" + City + "', NULL)";
            MySqlConnection database_con = new MySqlConnection(connection);

            MySqlCommand command_datab = new MySqlCommand(query, database_con);
            command_datab.CommandTimeout = 60;

            try
            {
                database_con.Open();
                MySqlDataReader myRead = command_datab.ExecuteReader();

                MessageBox.Show("New Staff Member is Registered !");

                database_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void state_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fname.Clear();
            lname.Clear();
            mobile.Clear();
            email.Clear();
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            state.ResetText();
            city.Clear();
            

            DoB.Value = DateTime.Now;
            JoinD.Value = DateTime.Now;
        }
    }
}
