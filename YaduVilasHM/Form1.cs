using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using YaduVilasHM.DataService;

namespace YaduVilasHM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
            lblError.Visible = false;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            List<string> lstInput = new List<string> { txtUsername.Text,txtPassword.Text};
            if(Helper.ValidateTextFields(lstInput))
            {
                LogInService _service = new LogInService();
                var user = await _service.GetUserLoggedIn(txtUsername.Text, txtPassword.Text);
                if (user != null)
                    MessageBox.Show("Logged in.");
                else
                {
                    txtPassword.Text = "";
                    lblError.Text = "Invalid Username or Password";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Username and password are required";
                lblError.Visible = true;
            }
        }
    }
}
