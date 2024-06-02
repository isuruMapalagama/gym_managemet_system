using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymManagement1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            if (userN.Text == "admin" && passwrdB.Text == "admin")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User Name or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
