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
        public Information info = new Information();
        public Operations oper = new Operations();

        public AdminRegister()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            info.firstname = tbFirst.Text;
            info.lastname = tbLast.Text;
            info.username = tbUsername.Text;
            info.password = tbPassword.Text;
            info.isadmin = 1;

            info.casinoname = tbCasino.Text;
            info.clubname = tbClub.Text;
            info.casinolocation = tbLocation.Text;

            int rowsu = oper.insertUser(info);
            if (rowsu > 0)
            {
                int rowsc = oper.insertCasino(info);
                if (rowsc > 0)
                {
                    AdminCreated adminCreated = new AdminCreated();
                    adminCreated.Show();
                }
            }


        }

    }
}
