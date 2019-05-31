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
    public partial class AdminCreated : Form
    {
        public AdminCreated()
        {
            InitializeComponent();
        }

        private void AdminCreated_Load(object sender, EventArgs e)
        {
            lblName.Text = Login.dtName;

            if (Operations.lastFrom == "Login")
            {
                lblGreeting.Text = Login.acLabel;
            }
            else if (Operations.lastFrom == "AdminReg")
            {
                lblGreeting.Text = AdminRegister.acLabel;
            }

        }
    }
}
