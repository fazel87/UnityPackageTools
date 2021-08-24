using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using UnityPackageTools;
using System.IO.Compression;

namespace UnityPackageTools
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            RefreshForm();
        }
        public void RefreshForm()
        {
            if (Global.UnityPackage_Path != null)
            {
                MainMenu.ActiveForm.Text = "UnityPackageTools - " + Path.GetFileNameWithoutExtension(Global.UnityPackage_Path);
                EnableAllBtn();
            }
            else
                DisableAllBtn();

            if (Global.UnityPackage_Extract_Path == null)
                ExtractUnityPackage.Enabled = false;

            if (ZipPath_textbox.Text == "")
                SaveZIP.Enabled = false;

            if (TAR_Path_textbox.Text == "")
                SaveTAR.Enabled = false;

            if (TGZ_Path_textbox.Text == "")
                SaveTGZ.Enabled = false;
        }

        private void unityPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenUnityPackage.ShowDialog() == DialogResult.OK)
            {
                Global.UnityPackage_Path = OpenUnityPackage.FileName;
            }
            RefreshForm();
        }

        private void OpenFolderBtn1_Click(object sender, EventArgs e)
        {
            if (OpenTargetFolder.ShowDialog() == DialogResult.OK)
            {
                Global.UnityPackage_Extract_Path = OpenTargetFolder.SelectedPath;
                ExtractPath.Text = OpenTargetFolder.SelectedPath;
            }
            RefreshForm();
        }
        [Obsolete]
        private void ExtractUnityPackage_Click(object sender, EventArgs e)
        {
            UnityPackage_Extract_Tools.Extract_To_Folder();
        }

        private void ZIPShowDialogbtn_Click(object sender, EventArgs e)
        {
            SavePackageDialog.Filter = "ZIP Package|*.zip";
            SavePackageDialog.Title = "Save ZIP package";

            if (SavePackageDialog.ShowDialog() == DialogResult.OK)
                ZipPath_textbox.Text = SavePackageDialog.FileName;
        }

        public void EnableAllBtn()
        {
            ExtractUnityPackage.Enabled = true;
            SaveZIP.Enabled = true;
            SaveTAR.Enabled = true;
            SaveTGZ.Enabled = true;
        }
        public void DisableAllBtn()
        {
            ExtractUnityPackage.Enabled = false;
            SaveZIP.Enabled = false;
            SaveTAR.Enabled = false;
            SaveTGZ.Enabled = false;
        }
        [Obsolete]
        private void SaveZIP_Click(object sender, EventArgs e)
        {
            new Thread(() => UnityPackage_Extract_Tools.ConvertToZIP(ZipPath_textbox.Text)).Start();
        }

        private void TARShowDialogBtn_Click(object sender, EventArgs e)
        {
            SavePackageDialog.Filter = "TAR Archive|*.tar";
            SavePackageDialog.Title = "Save Tar Archive";

            if (SavePackageDialog.ShowDialog() == DialogResult.OK)
                TAR_Path_textbox.Text = SavePackageDialog.FileName;
        }
        [Obsolete]
        private void SaveTAR_Click(object sender, EventArgs e)
        {
            new Thread(() => UnityPackage_Extract_Tools.ConvertToTAR(TAR_Path_textbox.Text)).Start();
        }

        [Obsolete]
        private void SaveTGZ_Click(object sender, EventArgs e)
        {
            new Thread(() => UnityPackage_Extract_Tools.ConvertToTGZ(TGZ_Path_textbox.Text)).Start();
        }

        private void TGZShowDialogBtn_Click(object sender, EventArgs e)
        {
            SavePackageDialog.Filter = "TGZ Archive|*.tgz|Tar.GZ|*.tar.gz";
            SavePackageDialog.Title = "Save Tar.GZ(TGZ) Archive";

            if (SavePackageDialog.ShowDialog() == DialogResult.OK)
                TGZ_Path_textbox.Text = SavePackageDialog.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create by: seyyed fazel alavi\nLicense: MIT\nsource: https://github.com/fazel87/UnityPackageTools","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void firstStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("open the UnityPackage file in the File / Open / UnityPackage section", "Frist Step", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void extractUnityPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First do the frsit step \nthen click on the ExtractPackage section in ... section \nThen select the destination folder \nthen click Extract", "Extract UnityPackage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void convertToZIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First do the frsit step \nthen click on ConvertToZIP in ... section and save the ZIP file \nThen select SaveZIP", "Convert UnityPackage to ZIP",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void convertToTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First do the frsit step \nthen click on ConvertToTAR in ... section and save the TAR file \nThen select SaveTAR", "Convert UnityPackage to TAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void convertToTARGZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First do the frsit step \nthen click on ConvertToTGZ in ... section and save the TGZ file \nThen select SaveTGZ", "Convert UnityPackage to TGZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
