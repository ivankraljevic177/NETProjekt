using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETProjekt
{
    public partial class frmPrintContact : Form
    {
        public Contact Selected { get; set; }
        private PrintDocument printDocument1 = new PrintDocument();
        public frmPrintContact()
        {
            InitializeComponent();
        }

        private void frmPrintContact_Load(object sender, EventArgs e)
        {
            tbName.Text = Selected.Name;
            tbSurname.Text = Selected.Surname;
            tbFix.Text = Selected.FixNumber;
            tbMobile.Text = Selected.MobileNumber;
            tbFax.Text = Selected.FaxNumber;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            
        }
        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y,0, 0, s);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
