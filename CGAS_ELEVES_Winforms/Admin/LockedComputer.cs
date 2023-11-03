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

namespace CGAS_ELEVES_Winforms.Admin
{
    public partial class LockedComputer : UserControl
    {
        public LockedComputer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void appsButton1_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment redémarrer l'ordinateur ?";
            string title = "Redémarrer l'ordinateur";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Process.Start("shutdown", "/r /t 0");
            }
            else
            {
                // Do something
            }
        }

        private void LockedComputer_Load(object sender, EventArgs e)
        {

        }
    }
}
