namespace NETProjekt
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lvImenik = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFixed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMobile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisSvihKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoggedUser = new System.Windows.Forms.StatusStrip();
            this.tsslLoggedInUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAdminLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddNewContact = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.btnPrintAllContacts = new System.Windows.Forms.ToolStripButton();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefreshList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.LoggedUser.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvImenik
            // 
            this.lvImenik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSurname,
            this.chFixed,
            this.chMobile,
            this.chFax});
            this.lvImenik.FullRowSelect = true;
            this.lvImenik.HideSelection = false;
            this.lvImenik.Location = new System.Drawing.Point(12, 58);
            this.lvImenik.Name = "lvImenik";
            this.lvImenik.Size = new System.Drawing.Size(776, 358);
            this.lvImenik.TabIndex = 0;
            this.lvImenik.UseCompatibleStateImageBehavior = false;
            this.lvImenik.View = System.Windows.Forms.View.Details;
            this.lvImenik.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvImenik_MouseClick);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 100;
            // 
            // chSurname
            // 
            this.chSurname.Text = "Surname";
            this.chSurname.Width = 100;
            // 
            // chFixed
            // 
            this.chFixed.Text = "Fixed Number";
            this.chFixed.Width = 125;
            // 
            // chMobile
            // 
            this.chMobile.Text = "Mobile Number";
            this.chMobile.Width = 125;
            // 
            // chFax
            // 
            this.chFax.Text = "Fax Number";
            this.chFax.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviKorisnikToolStripMenuItem,
            this.popisSvihKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // popisSvihKorisnikaToolStripMenuItem
            // 
            this.popisSvihKorisnikaToolStripMenuItem.Name = "popisSvihKorisnikaToolStripMenuItem";
            this.popisSvihKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.popisSvihKorisnikaToolStripMenuItem.Text = "Popis svih korisnika";
            this.popisSvihKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.popisSvihKorisnikaToolStripMenuItem_Click);
            // 
            // LoggedUser
            // 
            this.LoggedUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LoggedUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLoggedInUser,
            this.tsslAdminLabel});
            this.LoggedUser.Location = new System.Drawing.Point(0, 427);
            this.LoggedUser.Name = "LoggedUser";
            this.LoggedUser.Size = new System.Drawing.Size(800, 26);
            this.LoggedUser.TabIndex = 2;
            this.LoggedUser.Text = "statusStrip1";
            // 
            // tsslLoggedInUser
            // 
            this.tsslLoggedInUser.Name = "tsslLoggedInUser";
            this.tsslLoggedInUser.Size = new System.Drawing.Size(151, 20);
            this.tsslLoggedInUser.Text = "toolStripStatusLabel1";
            // 
            // tsslAdminLabel
            // 
            this.tsslAdminLabel.Name = "tsslAdminLabel";
            this.tsslAdminLabel.Size = new System.Drawing.Size(53, 20);
            this.tsslAdminLabel.Text = "Ovlast:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddNewContact,
            this.tsbUpdate,
            this.tsbDelete,
            this.btnRefreshList,
            this.toolStripSeparator1,
            this.btnPrintAllContacts});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddNewContact
            // 
            this.tsbAddNewContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddNewContact.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddNewContact.Image")));
            this.tsbAddNewContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddNewContact.Name = "tsbAddNewContact";
            this.tsbAddNewContact.Size = new System.Drawing.Size(29, 24);
            this.tsbAddNewContact.Text = "Add new user";
            this.tsbAddNewContact.Click += new System.EventHandler(this.tsbAddNewContact_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(67, 24);
            this.tsbUpdate.Text = "UPDATE";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(63, 24);
            this.tsbDelete.Text = "DELETE";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // btnPrintAllContacts
            // 
            this.btnPrintAllContacts.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPrintAllContacts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrintAllContacts.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintAllContacts.Image")));
            this.btnPrintAllContacts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintAllContacts.Name = "btnPrintAllContacts";
            this.btnPrintAllContacts.Size = new System.Drawing.Size(158, 24);
            this.btnPrintAllContacts.Text = "PRINT ALL CONTACTS";
            this.btnPrintAllContacts.Click += new System.EventHandler(this.btnPrintAllContacts_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            this.pomoćToolStripMenuItem.Click += new System.EventHandler(this.pomoćToolStripMenuItem_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnRefreshList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefreshList.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshList.Image")));
            this.btnRefreshList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(104, 24);
            this.btnRefreshList.Text = "REFRESH LIST";
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LoggedUser);
            this.Controls.Add(this.lvImenik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LoggedUser.ResumeLayout(false);
            this.LoggedUser.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvImenik;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.StatusStrip LoggedUser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisSvihKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbAddNewContact;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripStatusLabel tsslLoggedInUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslAdminLabel;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSurname;
        private System.Windows.Forms.ColumnHeader chFixed;
        private System.Windows.Forms.ColumnHeader chMobile;
        private System.Windows.Forms.ColumnHeader chFax;
        private System.Windows.Forms.ToolStripButton btnPrintAllContacts;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnRefreshList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}