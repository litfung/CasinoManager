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
        public Casino casino = new Casino();
        public Operations oper = new Operations();

        DataTable dtUser = new DataTable();
        DataTable dtCasino = new DataTable();

        public static string acName = "oops?";
        public static string acLabel = "oops?";
        public static string acCasino = "oops?";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            casino.username = tbUsername.Text;
            casino.password = tbPassword.Text;

            //dtUser = oper.loginUser(casino);
            dtCasino = oper.loginCasino(casino);

            if (dtUser.Rows.Count == 1)
            {
                foreach(DataRow row in dtUser.Rows)
                {
                    string fname = row["FirstName"].ToString();
                    string lname = row["LastName"].ToString();

                    acName = fname + " " + lname;
                }

                foreach(DataRow row in dtCasino.Rows)
                {
                    acCasino = row["CasinoName"].ToString();
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
