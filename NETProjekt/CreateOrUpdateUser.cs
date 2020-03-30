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
    public partial class CreateOrUpdateUser : Form
    {
        Database db = new Database();
        public CreateOrUpdateUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            db.CreateUser(txtbName.Text, txtbSurname.Text, txtbUsername.Text,txtbPassword.Text,chkbIsAdministrator.Checked);
            ShowMessage("User added successfully!");
            ClearFormValues();

        }

        private void ClearFormValues()
        {
            txtbName.Text = "";
            txtbSurname.Text ="";
            txtbPassword.Text = "";
            chkbIsAdministrator.Checked = false;
            txtbUsername.Text = "";
        }

        private static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
