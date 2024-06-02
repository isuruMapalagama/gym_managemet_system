using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace gymManagement1
{
    public partial class NewMember : Form
    {

        public NewMember()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewMember_Load(object sender, EventArgs e)
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
            String gym_Time = gymTime.Text;
            String Address = address.Text;
            String Membership = membershipT.Text;

            string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management;";
            string query = "INSERT INTO new_member(`first_name`, `last_name`, `gender`, `date_of_birth`, `mobile`, `email`, `join_date`, `gym_time`, `address`, `membership_time`, `user_id`) VALUES ('" + f_name + "','" + l_name + "','" + gender + "','" + dob + "','" + mobile_no + "','" + e_mail + "','" + join_Date + "','" + gym_Time + "','" + Address + "','" + Membership + "',NULL)";
            MySqlConnection database_con = new MySqlConnection(connection);

            MySqlCommand command_datab = new MySqlCommand(query, database_con);
            command_datab.CommandTimeout = 60;

            try
            {
                database_con.Open();
                MySqlDataReader myRead = command_datab.ExecuteReader();

                MessageBox.Show("New Member is Registered !");

                database_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            fname.Clear();
            lname.Clear();
            mobile.Clear();
            email.Clear();
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            address.Clear();
            gymTime.ResetText();
            membershipT.ResetText();

            DoB.Value = DateTime.Now;
            JoinD.Value = DateTime.Now;
        }

        private void JoinD_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
