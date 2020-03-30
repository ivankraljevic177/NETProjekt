using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETProjekt
{
    public partial class frmLogin : Form
    {


        Database db = new Database();

        private int numberOfRetries = 3;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<User> users = db.GetUsers();
            var loggedInUser = users.FirstOrDefault(user => user.Username == tbUsername.Text && user.Password == tbPassword.Text);

            if (loggedInUser != null)
            {
                Main main = new Main
                {
                    LoggedInUser = loggedInUser
                };

                main.Show();

                SetErrorLabelsVisibilityToFalse();

                this.Hide();
            }
            else
            {
                numberOfRetries--;

                lblNumberOfRetriesNumber.Text = numberOfRetries.ToString();
                SetErrorLabelsVisibilityToTrue();
            }


            if (numberOfRetries == 0)
            {
                btnLogin.Enabled = false;
            }
        }

        private void SetErrorLabelsVisibilityToTrue()
        {
            lblError.Visible = true;
            lblNumberOfRetriesNumber.Visible = true;
            lblNumberOfRetriesText.Visible = true;
        }

        private void SetErrorLabelsVisibilityToFalse()
        {
            lblError.Visible = false;
            lblNumberOfRetriesNumber.Visible = false;
            lblNumberOfRetriesText.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Common.ExitApplication();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
