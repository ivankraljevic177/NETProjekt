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
    public partial class frmPrintAllContacts : Form
    {
        private Contact SelectedContact { get; set; }
        Database db = new Database();
        public frmPrintAllContacts()
        {
            InitializeComponent();
        }

        private void frmPrintAllContacts_Load(object sender, EventArgs e)
        {
            List<Contact> contacts = db.GetContacts();
            ListAllContacts(contacts);
        }

        public void ListAllContacts(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                List<string> row = new List<string>();
                row.AddRange(new List<string>()
                {
                contact.Name,contact.Surname,contact.FixNumber, contact.MobileNumber, contact.FaxNumber
                });

                ListViewItem item = new ListViewItem(row.ToArray());

                lvImenik.Items.Add(item);
            }
        }

        private void lvImenik_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedContact = new Contact();
            //var selectedC = lvImenik.SelectedItems;
            var selectedContact = lvImenik.SelectedItems[0];

            SelectedContact.Name = selectedContact.SubItems[0].Text;
            SelectedContact.Surname = selectedContact.SubItems[1].Text;
            SelectedContact.FixNumber = selectedContact.SubItems[2].Text;
            SelectedContact.MobileNumber = selectedContact.SubItems[3].Text;
            SelectedContact.FaxNumber = selectedContact.SubItems[4].Text;

            frmPrintContact printContact = new frmPrintContact
            {
                Selected = SelectedContact,
            };
            printContact.Show();
        }
    }
}
