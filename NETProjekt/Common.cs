using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETProjekt
{
    public static class Common
    {
        public static void ExitApplication()
        {
            var dialogResult = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (dialogResult != DialogResult.Yes) return;
            Application.Exit();

        }
    }
}
