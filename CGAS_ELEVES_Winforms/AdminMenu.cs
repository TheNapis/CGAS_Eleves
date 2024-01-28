using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CGAS_ELEVES_Winforms
{
    public partial class AdminMenu : Form
    {
        bool StatusButton = false;
        public AdminMenu()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = false;
            VerifyDir(@"C:\CGAS\Eleves\");
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string message = "Voulez vous vraiment fermer la session ?";
            string title = "Fermer la session";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MainForm.Logger("Log Off");
                Process.Start("shutdown", "/f");
            }
            else
            {
                // Do something
            }
        }

        public static void VerifyDir(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                if (!dir.Exists)
                {
                    MessageBox.Show("Le fichier de paramètres de CGAS Elèves n'avait pas été créé. Il a donc été créé.");
                    dir.Create();
                    System.IO.StreamWriter file = new System.IO.StreamWriter(path + "Settings.txt", true);
                    file.WriteLine("0");
                    file.Close();
                }
            }
            catch { }
        }

        
        
        static void lineChanger(bool activate)
        {
            if (activate == true)
            {
                string File_Dir = @"C:\CGAS\Eleves\Settings.txt";
                String strFile = File.ReadAllText(File_Dir);

                strFile = strFile.Replace("0", "1"); // Passe du status "Opérationnel" à "En panne"

                File.WriteAllText(File_Dir, strFile);
            }
            else if (activate == false)
            {
                string File_Dir = @"C:\CGAS\Eleves\Settings.txt";
                String strFile = File.ReadAllText(File_Dir);

                strFile = strFile.Replace("1", "0"); // Passe du status "Opérationnel" à "En panne"

                File.WriteAllText(File_Dir, strFile);
            }
            
        }
        
        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (File.ReadLines(@"C:\CGAS\Eleves\Settings.txt").Skip(0).Take(1).First() == "0")
            {
                lineChanger(true);
                iconButton5.Text = "Marquer l'ordinateur comme \r\n\"OPERATIONNEL\"";
                MessageBox.Show("Le status de l'ordinateur a été changé");
            }
            else
            {
                lineChanger(false);
                iconButton5.Text = "Marquer l'ordinateur comme \r\n\"EN PANNE\"";
                MessageBox.Show("Le status de l'ordinateur a été changé");
            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
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

        private void iconButton6_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment redémarrer l'ordinateur ?";
            string title = "Redémarrer l'ordinateur";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                MainForm.Logger("The computer reboot");
                Process.Start("shutdown", "/r /t 0");
            }
            else
            {
                // Do something
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        public static void VerifyDir(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                if (!dir.Exists)
                {
                    MessageBox.Show("Le fichier de paramètres de CGAS Elèves n'avait pas été créé. Il a donc été créé.");
                    dir.Create();
                    System.IO.StreamWriter file = new System.IO.StreamWriter(path + "Settings.txt", true);
                    file.WriteLine("0");
                    file.Close();
                }
            }
            catch { }
        }

        
        
        static void lineChanger(bool activate)
        {
            if (activate == true)
            {
                string File_Dir = @"C:\CGAS\Eleves\Settings.txt";
                String strFile = File.ReadAllText(File_Dir);

                strFile = strFile.Replace("0", "1"); // Passe du status "Opérationnel" à "En panne"

                File.WriteAllText(File_Dir, strFile);
            }
            else if (activate == false)
            {
                string File_Dir = @"C:\CGAS\Eleves\Settings.txt";
                String strFile = File.ReadAllText(File_Dir);

                strFile = strFile.Replace("1", "0"); // Passe du status "Opérationnel" à "En panne"

                File.WriteAllText(File_Dir, strFile);
            }
            
        }
        
        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (File.ReadLines(@"C:\CGAS\Eleves\Settings.txt").Skip(0).Take(1).First() == "0")
            {
                lineChanger(true);
                iconButton5.Text = "Marquer l'ordinateur comme \r\n\"OPERATIONNEL\"";
                MessageBox.Show("Le status de l'ordinateur a été changé");
            }
            else
            {
                lineChanger(false);
                iconButton5.Text = "Marquer l'ordinateur comme \r\n\"EN PANNE\"";
                MessageBox.Show("Le status de l'ordinateur a été changé");
            }
        }
    }
}
