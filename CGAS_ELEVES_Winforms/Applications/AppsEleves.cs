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

namespace CGAS_ELEVES_Winforms.Applications
{
    public partial class AppsEleves : UserControl
    {
        public AppsEleves()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void AppsEleves_Load(object sender, EventArgs e)
        {

        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\LibreOffice 6.3\LibreOffice Calc.lnk");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Il semble que l'application Calculatrice à un problème.","Erreur",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void WriterButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\LibreOffice 6.3\LibreOffice Writer.lnk");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Il semble que l'application Texte à un problème.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void PresentationButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\LibreOffice 6.3\LibreOffice Impress.lnk");
        }

        private void CalculatriceButton_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void VocalButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"shell:appsFolder\Microsoft.WindowsSoundRecorder_8wekyb3d8bbwe!App");
        }

        private void VLCButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\VideoLAN\VLC media player.lnk");
        }

        private void GlobeButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Google Earth Pro.lnk");
        }

        private void ScratchButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Scratch 3.lnk");
        }

        private void InternetButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Edge.lnk");
        }

        private void OBSButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\OBS Studio\OBS Studio (64bit).lnk");
        }

        private void GIMPButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\GIMP 2.10.34.lnk");
        }

        private void PDFButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\PDF-XChange PDF Viewer\PDF-Viewer.lnk");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
