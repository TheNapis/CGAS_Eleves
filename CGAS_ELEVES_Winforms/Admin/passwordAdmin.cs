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

namespace CGAS_ELEVES_Winforms.Admin
{
    
    public partial class passwordAdmin : UserControl
    {
        private string testedPassword;

        public passwordAdmin()
        {
            InitializeComponent();
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
            if (testedPassword == "echarm")
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Mot de passe incorect");
                
            }
        }
    }
}
