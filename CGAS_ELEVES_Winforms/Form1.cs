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
using System.Messaging;
using CGAS_ELEVES_Winforms.Admin;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Input;
using System.Runtime.CompilerServices;

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
            Logger("CGAS started");
            statusPage1.Visible = false;
            appsEleves1.Visible = true;
            passwordAdmin1.Visible = false;
            
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                statusButton.IconColor = Color.LightGreen;

            }
            else
            {
                MainForm.Logger("The computer is not connected");
                statusButton.IconColor = Color.Red;
            }



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

        private void batteryButton_Click(object sender, EventArgs e)
        {
            if (adminCount >= 10)
            {
                panel1.BackColor = Color.FromArgb(255, 0, 68, 163);
                panel2.BackColor = Color.FromArgb(255, 0, 68, 163);
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
            try
            {
                Process.Start(@"C:\Users\Eleves\Desktop");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                Logger("Missing Folder : Patte de canard");
                string message = "Le chemin d'accès pour le dossier C:\\Users\\Eleves\\Desktop est inacessible.\nCode erreur : Patte de canard";
                string title = "Contacter votre enseignant";
                DialogResult result = MessageBox.Show(message, title);
            }
        }


        private void shutdownButton_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment éteindre l'ordinateur ?";
            string title = "Éteindre l'ordinateur";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Logger("The computer shuts down");
                Process.Start("shutdown", "/s /t 0");
            }
            else
            {
                // Do something
            }
            
        }

        private void problemButton_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 0, 68, 163);
            panel2.BackColor = Color.FromArgb(255, 0, 68, 163);
            statusPage1.Visible = true;
            appsEleves1.Visible = false;
            passwordAdmin1.Visible = false;
        }

        private void appsButton_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 46, 117, 216);
            panel2.BackColor = Color.FromArgb(255, 46, 117, 216);
            statusPage1.Visible = false;
            appsEleves1.Visible = true;
            passwordAdmin1.Visible = false;
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }//Useless

        private void passerrorfrom(object sender, EventArgs e) 
        {

        }//Useless

        private void lockedComputer2_Load(object sender, EventArgs e)
        {

        }//Useless

        public static void VerifyDir(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                if (!dir.Exists)
                {
                    dir.Create();
                }
            }
            catch { }
        }

        public static void Logger(string lines)
        {
            string path = @"C:\CGAS\";
            VerifyDir(path);
            string fileName = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + ".txt";
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(path + "CGAS_Logs " + fileName, true);
                file.WriteLine(DateTime.Now.ToString() + " : " + lines);
                file.Close();
            }
            catch (Exception) { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger("CGAS stopped");
        }

        private void statusButton_Click(object sender, EventArgs e)
        {

        }

        private void appsEleves1_Load(object sender, EventArgs e)
        {
            
        }

        public static void SwitchForm()
        {
            AdminMenu AD = new AdminMenu();
            AD.Visible = true;
            
        }
        
    }
}