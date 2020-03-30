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
    public partial class frmAddContact : Form
    {
        Main main = new Main();
        Database db = new Database();
        public bool IsNew { get; set; }
        public Contact Contact { get; set; }
        public frmAddContact()
        {
            InitializeComponent();
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            
            if(IsNew)
            {
                db.CreateContact(tbName.Text, tbSurname.Text, tbFixed.Text, tbMobile.Text, tbFax.Text);
                ShowMessage("Contact added successfully!");
                ClearFormValues();
                
            }
            else
            {
                string oldContactName = Contact.Name;
                Contact.Name = tbName.Text;
                Contact.Surname = tbSurname.Text;
                Contact.FixNumber = tbFixed.Text;
                Contact.MobileNumber = tbMobile.Text;
                Contact.FaxNumber = tbFax.Text;

                db.UpdateContact(Contact, oldContactName);
                ShowMessage("Contact updated successfully!");
                this.Close();
                
            }
        }

        private void ClearFormValues()
        {
            tbName.Text = "";
            tbSurname.Text = "";
            tbFixed.Text = "";
            tbMobile.Text = "";
            tbFax.Text = "";
        }

        private static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        private void btnCancelContact_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddContact_Load(object sender, EventArgs e)
        {
            if (IsNew) return;

            tbName.Text = Contact.Name;
            tbSurname.Text = Contact.Surname;
            tbFixed.Text = Contact.FixNumber;
            tbMobile.Text = Contact.MobileNumber;
            tbFax.Text = Contact.MobileNumber;
        }

        
    }
}
