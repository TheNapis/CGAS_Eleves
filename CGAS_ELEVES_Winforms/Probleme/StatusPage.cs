using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using static System.Net.WebRequestMethods;
using FontAwesome;
using FontAwesome.Sharp;
using System.Diagnostics;

namespace CGAS_ELEVES_Winforms.Probleme
{
    public partial class StatusPage : UserControl
    {
        public StatusPage()
        {
            InitializeComponent();
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                statusButton.IconChar = FontAwesome.Sharp.IconChar.Check;
                statusButton.IconColor = Color.LightGreen;

            }
            else
            {
                statusButton.IconChar = FontAwesome.Sharp.IconChar.X;
                statusButton.IconColor = Color.Red;
            }
            

        }

        private void StatusPage_Load(object sender, EventArgs e)
        {
            

        }



        private void connectionStatus_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statusButton_Click(object sender, EventArgs e)
        {

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
    }
}
