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
    public partial class AdminRegister : Form
    {
        public Casino casino = new Casino();
        public Operations oper = new Operations();

        public static string acLabel = "oops?";

        public AdminRegister()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (tbPassword.Text.Length >= 8)
            {
                if (tbPassword.Text == tbConfirmPW.Text)
                {

                    Guid userGuid = System.Guid.NewGuid();
                    string hashedPassword = Security.HashSHA1(tbPassword.Text + userGuid.ToString());

                    casino.firstname = tbFirst.Text;
                    casino.lastname = tbLast.Text;
                    casino.username = tbUsername.Text;
                    casino.password = hashedPassword;
                    casino.email = tbEmail.Text; ;
                    casino.casinoname = tbCasino.Text;
                    casino.clubname = tbClub.Text;
                    casino.casinolocation = tbLocation.Text;
                    casino.userguid = userGuid;

                    int rowsc = oper.insertCasino(casino);
                    if (rowsc > 0)
                    {
                        Operations.lastFrom = "AdminReg";
                        acLabel = "You have created a new casino.";

                        AdminCreated adminCreated = new AdminCreated();
                        adminCreated.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Your passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Your password must be at least 8 characters");
            }





        }

    }
}
