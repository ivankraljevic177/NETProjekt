namespace NETProjekt
{
    partial class frmAddContact
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFix = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFixed = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.btnCancelContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(104, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(104, 108);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblFix
            // 
            this.lblFix.AutoSize = true;
            this.lblFix.Location = new System.Drawing.Point(104, 170);
            this.lblFix.Name = "lblFix";
            this.lblFix.Size = new System.Drawing.Size(95, 17);
            this.lblFix.TabIndex = 2;
            this.lblFix.Text = "Fixed Number";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(104, 237);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(103, 17);
            this.lblMobile.TabIndex = 3;
            this.lblMobile.Text = "Mobile Number";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(104, 306);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(84, 17);
            this.lblFax.TabIndex = 4;
            this.lblFax.Text = "Fax Number";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(214, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(225, 22);
            this.tbName.TabIndex = 5;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(214, 102);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(225, 22);
            this.tbSurname.TabIndex = 6;
            // 
            // tbFixed
            // 
            this.tbFixed.Location = new System.Drawing.Point(214, 167);
            this.tbFixed.Name = "tbFixed";
            this.tbFixed.Size = new System.Drawing.Size(225, 22);
            this.tbFixed.TabIndex = 7;
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(214, 234);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(225, 22);
            this.tbMobile.TabIndex = 8;
            // 
            // tbFax
            // 
            this.tbFax.Location = new System.Drawing.Point(214, 303);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(225, 22);
            this.tbFax.TabIndex = 9;
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Location = new System.Drawing.Point(107, 392);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(116, 41);
            this.btnSaveContact.TabIndex = 10;
            this.btnSaveContact.Text = "Save";
            this.btnSaveContact.UseVisualStyleBackColor = true;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // btnCancelContact
            // 
            this.btnCancelContact.Location = new System.Drawing.Point(323, 392);
            this.btnCancelContact.Name = "btnCancelContact";
            this.btnCancelContact.Size = new System.Drawing.Size(116, 41);
            this.btnCancelContact.TabIndex = 11;
            this.btnCancelContact.Text = "Cancel";
            this.btnCancelContact.UseVisualStyleBackColor = true;
            this.btnCancelContact.Click += new System.EventHandler(this.btnCancelContact_Click);
            // 
            // frmAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 483);
            this.Controls.Add(this.btnCancelContact);
            this.Controls.Add(this.btnSaveContact);
            this.Controls.Add(this.tbFax);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbFixed);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblFix);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddContact";
            this.Text = "AddContact";
            this.Load += new System.EventHandler(this.frmAddContact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFix;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbFixed;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.Button btnCancelContact;
    }
}