using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;

namespace CasinoManager
{

    public partial class Login : Form
    {
        public Information info = new Information();
        public Operations oper = new Operations();

        DataTable dt = new DataTable();

        public static string dtName = "oops?";
        public static string acLabel = "oops?";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            info.username = tbUsername.Text;
            info.password = tbPassword.Text;

            dt = oper.login(info);

            if (dt.Rows.Count == 1)
            {
                foreach(DataRow row in dt.Rows)
                {
                    string fname = row["FirstName"].ToString();
                    string lname = row["LastName"].ToString();

                    dtName = fname + " " + lname;
                }
                Operations.lastFrom = "Login";
                acLabel = "You have succesfully logged in.";

                AdminCreated adminCreated = new AdminCreated();
                adminCreated.Show();
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }

        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            AdminRegister adminRegister = new AdminRegister();
            adminRegister.Show();
        }
    }
}
