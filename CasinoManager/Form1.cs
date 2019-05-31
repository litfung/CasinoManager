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
    public partial class Form1 : Form
    {
        public Information info = new Information();
        public Operations oper = new Operations();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            info.name = tbName.Text;
            info.username = tbLogin.Text;
            info.password = tbPassword.Text;

            int rows = oper.insertUser(info);
            if (rows > 0)
            {
                MessageBox.Show("User Data Entered Successfully");
            }


        }
    }
}
