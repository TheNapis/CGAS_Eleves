using CGAS_ELEVES_Winforms.Applications;
using CGAS_ELEVES_Winforms.Probleme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using CGAS_ELEVES_Winforms;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Configuration;

namespace CGAS_ELEVES_Winforms.Admin
{
    
    public partial class passwordAdmin : UserControl
    {
        private string testedPassword;
        public int passerror = 0;
        string password = CGAS_ELEVES_Winforms.Properties.Resources.password;

        public passwordAdmin()
        {
            
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void passwordAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            testedPassword = textBox1.Text;
        }


        private void ValidButton_Click(object sender, EventArgs e)
        {
            if (passerror < 5)
            {
                if (testedPassword == password)
                {
                    MainForm.SwitchForm();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorect");
                    passerror++;
                }

            }
            else
            {
                MainForm.Logger("Enforced password : Canard énervé");
                MessageBox.Show("Veuillez redémarrer cet ordinateur.\nLe nombre essais a été dépassé.\nCeci a été noté dans le journal de l'ordinateur.");
                string message = "Redémarrer l'ordinateur ?\nCode erreur : Canard énervé";
                string title = "Mot de passe incorrect :(";
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

        }

        

        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (passerror < 5)
                {
                    if (testedPassword == password)
                    {
                        MainForm.SwitchForm();
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorect");
                        passerror++;
                    }

                }
                else
                {
                    MainForm.Logger("Enforced password : Canard énervé");
                    MessageBox.Show("Veuillez redémarrer cet ordinateur.\nVotre nombre essai est dépassé.\nCeci à été noté dans le journal de l'ordinateur.");
                    string message = "Redémarrer l'ordinateur ?\nCode erreur : Canard énervé";
                    string title = "Mot de passe incorrect :(";
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
            }
        }
    }
}
