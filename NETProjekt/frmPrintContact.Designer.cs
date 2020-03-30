namespace NETProjekt
{
    partial class frmPrintContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintContact));
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFix = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFix = new System.Windows.Forms.TextBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(69, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(69, 119);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblFix
            // 
            this.lblFix.AutoSize = true;
            this.lblFix.Location = new System.Drawing.Point(69, 164);
            this.lblFix.Name = "lblFix";
            this.lblFix.Size = new System.Drawing.Size(95, 17);
            this.lblFix.TabIndex = 2;
            this.lblFix.Text = "Fixed Number";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(69, 217);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(103, 17);
            this.lblMobile.TabIndex = 3;
            this.lblMobile.Text = "Mobile Number";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(69, 270);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(84, 17);
            this.lblFax.TabIndex = 4;
            this.lblFax.Text = "Fax Number";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(309, 65);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(241, 22);
            this.tbName.TabIndex = 5;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(309, 116);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.ReadOnly = true;
            this.tbSurname.Size = new System.Drawing.Size(241, 22);
            this.tbSurname.TabIndex = 6;
            // 
            // tbFix
            // 
            this.tbFix.Location = new System.Drawing.Point(309, 161);
            this.tbFix.Name = "tbFix";
            this.tbFix.ReadOnly = true;
            this.tbFix.Size = new System.Drawing.Size(241, 22);
            this.tbFix.TabIndex = 7;
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(309, 214);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.ReadOnly = true;
            this.tbMobile.Size = new System.Drawing.Size(241, 22);
            this.tbMobile.TabIndex = 8;
            // 
            // tbFax
            // 
            this.tbFax.Location = new System.Drawing.Point(309, 267);
            this.tbFax.Name = "tbFax";
            this.tbFax.ReadOnly = true;
            this.tbFax.Size = new System.Drawing.Size(241, 22);
            this.tbFax.TabIndex = 9;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(72, 338);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(478, 29);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "PRINT CONTACT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument2;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // frmPrintContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 389);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.tbFax);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.tbFix);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblFix);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Name = "frmPrintContact";
            this.Text = "Print Contact";
            this.Load += new System.EventHandler(this.frmPrintContact_Load);
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
        private System.Windows.Forms.TextBox tbFix;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}