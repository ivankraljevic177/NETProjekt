namespace NETProjekt
{
    partial class frmPrintAllContacts
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
            this.lvImenik = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFixed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMobile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lvImenik.Location = new System.Drawing.Point(12, 46);
            this.lvImenik.Name = "lvImenik";
            this.lvImenik.Size = new System.Drawing.Size(776, 358);
            this.lvImenik.TabIndex = 1;
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
            // frmPrintAllContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvImenik);
            this.Name = "frmPrintAllContacts";
            this.Text = "frmPrintAllContacts";
            this.Load += new System.EventHandler(this.frmPrintAllContacts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvImenik;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSurname;
        private System.Windows.Forms.ColumnHeader chFixed;
        private System.Windows.Forms.ColumnHeader chMobile;
        private System.Windows.Forms.ColumnHeader chFax;
    }
}