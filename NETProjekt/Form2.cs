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
    public partial class frmAllUsers : Form
    {
        
        Database db = new Database();
        public frmAllUsers()
        {
            InitializeComponent();
        }

        private void frmAllUsers_Load(object sender, EventArgs e)
        {
            List<User> users = db.GetUsers();

            foreach (var user in users)
            {
                List<string> row = new List<string>();
                row.AddRange(new List<string>()
                {
                user.Name,user.Surname,user.Username, user.Password, user.IsAdmin.ToString()
                });

                ListViewItem item = new ListViewItem(row.ToArray());

                listViewUsers.Items.Add(item);
            }
            
        }

        private void listViewUsers_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
