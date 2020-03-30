using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETProjekt
{
    public partial class Main : Form
    {
        
        public User LoggedInUser { get; set; }
        private Contact SelectedContact { get; set; }
        Database db = new Database();
        public Main()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Common.ExitApplication();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrUpdateUser newUser = new CreateOrUpdateUser();
            newUser.Show();
        }

        private void popisSvihKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllUsers frmAllUsers = new frmAllUsers();
            frmAllUsers.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            IfAdminShowUser();

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

        private void IfAdminShowUser()
        {
            string a = ("Username: " + LoggedInUser.Username);
            tsslLoggedInUser.Text = a;

            if (LoggedInUser.IsAdmin == false)
            {
                korisniciToolStripMenuItem.Visible = false;
                tsslAdminLabel.Text = "Ovlast: Korisnik";
            }
            else if (LoggedInUser.IsAdmin == true)
            {
                tsslAdminLabel.Text = "Ovlast: Administrator";
            }
        }

        private void tsbAddNewContact_Click(object sender, EventArgs e)
        {
            frmAddContact addContact = new frmAddContact()
            {
                IsNew = true,
            };
            addContact.Show();
            lvImenik.Items.Clear();
            

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


        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedContact == null) return;

            frmAddContact updateForm = new frmAddContact
            {
                IsNew = false,
                Contact = SelectedContact
            };

            updateForm.Show();
            
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (SelectedContact == null) return;

            var dialogResult = MessageBox.Show($"Do you want to delete user: {SelectedContact.Name}", "Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogResult != DialogResult.Yes) return;

            string deleteContact = SelectedContact.Name;
            db.DeleteContact(deleteContact);
            RefreshListView();
            
            
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPrintAllContacts_Click(object sender, EventArgs e)
        {
            frmPrintAllContacts printAllContacts = new frmPrintAllContacts();
            printAllContacts.Show();
        }

        public void RefreshListView()
        {
            lvImenik.Items.Clear();
            List<Contact> contacts = db.GetContacts();
            ListAllContacts(contacts);
        }

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.aspira.hr/");
            Process.Start(sInfo);
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }
    }
}
