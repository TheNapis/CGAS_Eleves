using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using FontAwesome;
using FontAwesome.Sharp;
using System.Diagnostics;
using CGAS_ELEVES_Winforms.Probleme;

namespace CGAS_ELEVES_Winforms
{
    public partial class MainForm : Form
    {
        public int adminCount = 0;
        public MainForm()
        {
            
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = false;
            InitializeComponent();
            BatteryStatus();
            statusPage1.Visible = false;
            appsEleves1.Visible = true;
            passwordAdmin1.Visible = false;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Time.Start();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            dateLabel.Text = DateTime.Now.ToShortDateString();

        }

        private void Time_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString(); //30.5.2012
            timeLabel.Text = DateTime.Now.ToLongTimeString();
            Time.Start();
        }

        private void BatteryStatus()
        {
            System.Management.ManagementClass wmi = new System.Management.ManagementClass("Win32_Battery");
            var allBatteries = wmi.GetInstances();

            foreach (var battery in allBatteries)
            {
                int estimatedChargeRemaining = Convert.ToInt32(battery["EstimatedChargeRemaining"]);
                if (estimatedChargeRemaining >= 75)
                {
                    batteryButton.IconChar = FontAwesome.Sharp.IconChar.Battery;
                    batteryButton.IconColor = Color.PaleGreen;
                }

                else if (estimatedChargeRemaining >= 50)
                {
                    batteryButton.IconChar = FontAwesome.Sharp.IconChar.Battery4;
                    batteryButton.IconColor = Color.White;
                }

                else if (estimatedChargeRemaining >= 25)
                {
                    batteryButton.IconChar = FontAwesome.Sharp.IconChar.BatteryQuarter;
                    batteryButton.IconColor = Color.Orange;
                }
                else if (estimatedChargeRemaining <= 15)
                {
                    batteryButton.IconChar = FontAwesome.Sharp.IconChar.BatteryEmpty;
                    batteryButton.IconColor = Color.Red;
                }

                else 
                {
                    batteryButton.IconChar = FontAwesome.Sharp.IconChar.Question;
                }

            }
        }

        private void LeftMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void appsEleves1_Load(object sender, EventArgs e)
        {

        }

        private void batteryButton_Click(object sender, EventArgs e)
        {
            if (adminCount >= 20)
            {
                statusPage1.Visible = false;
                appsEleves1.Visible = false;
                passwordAdmin1.Visible = true;
                adminCount = 0;
            }
            else
            {
                adminCount = adminCount + 1;
            }
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Eleves\Desktop"); 
        }

        private void shutdownButton_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment éteindre l'ordinateur ?";
            string title = "Éteindre l'ordinateur";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Process.Start("shutdown", "/s /t 0");
            }
            else
            {
                // Do something
            }
            
        }

        private void problemButton_Click(object sender, EventArgs e)
        {
            statusPage1.Visible = true;
            appsEleves1.Visible = false;
            passwordAdmin1.Visible = false;
        }

        private void appsButton_Click(object sender, EventArgs e)
        {
            statusPage1.Visible = false;
            appsEleves1.Visible = true;
            passwordAdmin1.Visible = false;
        }

        private void passwordAdmin1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

