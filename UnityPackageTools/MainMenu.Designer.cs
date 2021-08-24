
namespace UnityPackageTools
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ExtractUnityPackage = new System.Windows.Forms.Button();
            this.OpenFolderBtn1 = new System.Windows.Forms.Button();
            this.ExtractPath = new System.Windows.Forms.TextBox();
            this.about1 = new System.Windows.Forms.Label();
            this.Title1 = new System.Windows.Forms.Label();
            this.ConvertToZIP = new System.Windows.Forms.TabPage();
            this.SaveZIP = new System.Windows.Forms.Button();
            this.ZIPShowDialogbtn = new System.Windows.Forms.Button();
            this.ZipPath_textbox = new System.Windows.Forms.TextBox();
            this.about2 = new System.Windows.Forms.Label();
            this.Title2 = new System.Windows.Forms.Label();
            this.ConvertToTAR = new System.Windows.Forms.TabPage();
            this.ConvertToTGZ = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unityPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenUnityPackage = new System.Windows.Forms.OpenFileDialog();
            this.OpenTargetFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SavePackageDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TAR_Path_textbox = new System.Windows.Forms.TextBox();
            this.TARShowDialogBtn = new System.Windows.Forms.Button();
            this.SaveTAR = new System.Windows.Forms.Button();
            this.SaveTGZ = new System.Windows.Forms.Button();
            this.TGZShowDialogBtn = new System.Windows.Forms.Button();
            this.TGZ_Path_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractUnityPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToZIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToTARGZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstStepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ConvertToZIP.SuspendLayout();
            this.ConvertToTAR.SuspendLayout();
            this.ConvertToTGZ.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.ConvertToZIP);
            this.tabControl1.Controls.Add(this.ConvertToTAR);
            this.tabControl1.Controls.Add(this.ConvertToTGZ);
            this.tabControl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.074766F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.ExtractUnityPackage);
            this.tabPage1.Controls.Add(this.OpenFolderBtn1);
            this.tabPage1.Controls.Add(this.ExtractPath);
            this.tabPage1.Controls.Add(this.about1);
            this.tabPage1.Controls.Add(this.Title1);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(469, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ExtractPackage";
            // 
            // ExtractUnityPackage
            // 
            this.ExtractUnityPackage.BackColor = System.Drawing.Color.Gray;
            this.ExtractUnityPackage.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtractUnityPackage.Location = new System.Drawing.Point(9, 251);
            this.ExtractUnityPackage.Name = "ExtractUnityPackage";
            this.ExtractUnityPackage.Size = new System.Drawing.Size(453, 45);
            this.ExtractUnityPackage.TabIndex = 4;
            this.ExtractUnityPackage.Text = "Extract";
            this.ExtractUnityPackage.UseVisualStyleBackColor = false;
            this.ExtractUnityPackage.Click += new System.EventHandler(this.ExtractUnityPackage_Click);
            // 
            // OpenFolderBtn1
            // 
            this.OpenFolderBtn1.BackColor = System.Drawing.Color.Gray;
            this.OpenFolderBtn1.Location = new System.Drawing.Point(430, 214);
            this.OpenFolderBtn1.Name = "OpenFolderBtn1";
            this.OpenFolderBtn1.Size = new System.Drawing.Size(31, 31);
            this.OpenFolderBtn1.TabIndex = 3;
            this.OpenFolderBtn1.Text = "...";
            this.OpenFolderBtn1.UseVisualStyleBackColor = false;
            this.OpenFolderBtn1.Click += new System.EventHandler(this.OpenFolderBtn1_Click);
            // 
            // ExtractPath
            // 
            this.ExtractPath.BackColor = System.Drawing.Color.Gray;
            this.ExtractPath.ForeColor = System.Drawing.Color.White;
            this.ExtractPath.Location = new System.Drawing.Point(9, 214);
            this.ExtractPath.Multiline = true;
            this.ExtractPath.Name = "ExtractPath";
            this.ExtractPath.ReadOnly = true;
            this.ExtractPath.Size = new System.Drawing.Size(415, 31);
            this.ExtractPath.TabIndex = 2;
            // 
            // about1
            // 
            this.about1.AutoSize = true;
            this.about1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.11215F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about1.ForeColor = System.Drawing.Color.White;
            this.about1.Location = new System.Drawing.Point(8, 63);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(401, 22);
            this.about1.TabIndex = 1;
            this.about1.Text = "Read And Extract UnityPackage To Folder.";
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.20561F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Location = new System.Drawing.Point(5, 3);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(384, 39);
            this.Title1.TabIndex = 0;
            this.Title1.Text = "Extract Unity Package";
            // 
            // ConvertToZIP
            // 
            this.ConvertToZIP.BackColor = System.Drawing.Color.DimGray;
            this.ConvertToZIP.Controls.Add(this.SaveZIP);
            this.ConvertToZIP.Controls.Add(this.ZIPShowDialogbtn);
            this.ConvertToZIP.Controls.Add(this.ZipPath_textbox);
            this.ConvertToZIP.Controls.Add(this.about2);
            this.ConvertToZIP.Controls.Add(this.Title2);
            this.ConvertToZIP.ForeColor = System.Drawing.Color.White;
            this.ConvertToZIP.Location = new System.Drawing.Point(4, 23);
            this.ConvertToZIP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ConvertToZIP.Name = "ConvertToZIP";
            this.ConvertToZIP.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ConvertToZIP.Size = new System.Drawing.Size(469, 305);
            this.ConvertToZIP.TabIndex = 1;
            this.ConvertToZIP.Text = "ConvertToZIP";
            // 
            // SaveZIP
            // 
            this.SaveZIP.BackColor = System.Drawing.Color.Gray;
            this.SaveZIP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveZIP.Location = new System.Drawing.Point(8, 251);
            this.SaveZIP.Name = "SaveZIP";
            this.SaveZIP.Size = new System.Drawing.Size(453, 45);
            this.SaveZIP.TabIndex = 4;
            this.SaveZIP.Text = "SaveZIP";
            this.SaveZIP.UseVisualStyleBackColor = false;
            this.SaveZIP.Click += new System.EventHandler(this.SaveZIP_Click);
            // 
            // ZIPShowDialogbtn
            // 
            this.ZIPShowDialogbtn.BackColor = System.Drawing.Color.Gray;
            this.ZIPShowDialogbtn.Location = new System.Drawing.Point(430, 214);
            this.ZIPShowDialogbtn.Name = "ZIPShowDialogbtn";
            this.ZIPShowDialogbtn.Size = new System.Drawing.Size(31, 31);
            this.ZIPShowDialogbtn.TabIndex = 3;
            this.ZIPShowDialogbtn.Text = "...";
            this.ZIPShowDialogbtn.UseVisualStyleBackColor = false;
            this.ZIPShowDialogbtn.Click += new System.EventHandler(this.ZIPShowDialogbtn_Click);
            // 
            // ZipPath_textbox
            // 
            this.ZipPath_textbox.BackColor = System.Drawing.Color.Gray;
            this.ZipPath_textbox.ForeColor = System.Drawing.Color.White;
            this.ZipPath_textbox.Location = new System.Drawing.Point(8, 214);
            this.ZipPath_textbox.Multiline = true;
            this.ZipPath_textbox.Name = "ZipPath_textbox";
            this.ZipPath_textbox.ReadOnly = true;
            this.ZipPath_textbox.Size = new System.Drawing.Size(415, 31);
            this.ZipPath_textbox.TabIndex = 2;
            // 
            // about2
            // 
            this.about2.AutoSize = true;
            this.about2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.11215F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about2.Location = new System.Drawing.Point(8, 71);
            this.about2.Name = "about2";
            this.about2.Size = new System.Drawing.Size(394, 22);
            this.about2.TabIndex = 1;
            this.about2.Text = "Convert UnityPackage File to ZIP package";
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.20561F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.Location = new System.Drawing.Point(8, 3);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(362, 39);
            this.Title2.TabIndex = 0;
            this.Title2.Text = "UnityPackage To ZIP";
            // 
            // ConvertToTAR
            // 
            this.ConvertToTAR.BackColor = System.Drawing.Color.DimGray;
            this.ConvertToTAR.Controls.Add(this.SaveTAR);
            this.ConvertToTAR.Controls.Add(this.TARShowDialogBtn);
            this.ConvertToTAR.Controls.Add(this.TAR_Path_textbox);
            this.ConvertToTAR.Controls.Add(this.label2);
            this.ConvertToTAR.Controls.Add(this.label1);
            this.ConvertToTAR.ForeColor = System.Drawing.Color.White;
            this.ConvertToTAR.Location = new System.Drawing.Point(4, 23);
            this.ConvertToTAR.Name = "ConvertToTAR";
            this.ConvertToTAR.Padding = new System.Windows.Forms.Padding(3);
            this.ConvertToTAR.Size = new System.Drawing.Size(469, 305);
            this.ConvertToTAR.TabIndex = 2;
            this.ConvertToTAR.Text = "ConvertToTAR";
            // 
            // ConvertToTGZ
            // 
            this.ConvertToTGZ.BackColor = System.Drawing.Color.DimGray;
            this.ConvertToTGZ.Controls.Add(this.SaveTGZ);
            this.ConvertToTGZ.Controls.Add(this.TGZShowDialogBtn);
            this.ConvertToTGZ.Controls.Add(this.TGZ_Path_textbox);
            this.ConvertToTGZ.Controls.Add(this.label3);
            this.ConvertToTGZ.Controls.Add(this.label4);
            this.ConvertToTGZ.Location = new System.Drawing.Point(4, 23);
            this.ConvertToTGZ.Name = "ConvertToTGZ";
            this.ConvertToTGZ.Padding = new System.Windows.Forms.Padding(3);
            this.ConvertToTGZ.Size = new System.Drawing.Size(469, 305);
            this.ConvertToTGZ.TabIndex = 3;
            this.ConvertToTGZ.Text = "ConvertToTGZ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unityPackageToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // unityPackageToolStripMenuItem
            // 
            this.unityPackageToolStripMenuItem.Name = "unityPackageToolStripMenuItem";
            this.unityPackageToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.unityPackageToolStripMenuItem.Text = "UnityPackage";
            this.unityPackageToolStripMenuItem.Click += new System.EventHandler(this.unityPackageToolStripMenuItem_Click);
            // 
            // OpenUnityPackage
            // 
            this.OpenUnityPackage.Filter = "UnityPackage File|*.unitypackage";
            this.OpenUnityPackage.Title = "Open .unitypackage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.07477F);
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "UnityPackage To TAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.07477F);
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Convert UnityPackage to TAR Archive";
            // 
            // TAR_Path_textbox
            // 
            this.TAR_Path_textbox.BackColor = System.Drawing.Color.Gray;
            this.TAR_Path_textbox.ForeColor = System.Drawing.Color.White;
            this.TAR_Path_textbox.Location = new System.Drawing.Point(7, 217);
            this.TAR_Path_textbox.Multiline = true;
            this.TAR_Path_textbox.Name = "TAR_Path_textbox";
            this.TAR_Path_textbox.ReadOnly = true;
            this.TAR_Path_textbox.Size = new System.Drawing.Size(415, 31);
            this.TAR_Path_textbox.TabIndex = 2;
            // 
            // TARShowDialogBtn
            // 
            this.TARShowDialogBtn.BackColor = System.Drawing.Color.Gray;
            this.TARShowDialogBtn.Location = new System.Drawing.Point(428, 217);
            this.TARShowDialogBtn.Name = "TARShowDialogBtn";
            this.TARShowDialogBtn.Size = new System.Drawing.Size(31, 31);
            this.TARShowDialogBtn.TabIndex = 3;
            this.TARShowDialogBtn.Text = "...";
            this.TARShowDialogBtn.UseVisualStyleBackColor = false;
            this.TARShowDialogBtn.Click += new System.EventHandler(this.TARShowDialogBtn_Click);
            // 
            // SaveTAR
            // 
            this.SaveTAR.BackColor = System.Drawing.Color.Gray;
            this.SaveTAR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.07477F);
            this.SaveTAR.Location = new System.Drawing.Point(6, 254);
            this.SaveTAR.Name = "SaveTAR";
            this.SaveTAR.Size = new System.Drawing.Size(453, 45);
            this.SaveTAR.TabIndex = 4;
            this.SaveTAR.Text = "SaveTAR";
            this.SaveTAR.UseVisualStyleBackColor = false;
            this.SaveTAR.Click += new System.EventHandler(this.SaveTAR_Click);
            // 
            // SaveTGZ
            // 
            this.SaveTGZ.BackColor = System.Drawing.Color.Gray;
            this.SaveTGZ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.07477F);
            this.SaveTGZ.ForeColor = System.Drawing.Color.White;
            this.SaveTGZ.Location = new System.Drawing.Point(9, 249);
            this.SaveTGZ.Name = "SaveTGZ";
            this.SaveTGZ.Size = new System.Drawing.Size(453, 45);
            this.SaveTGZ.TabIndex = 9;
            this.SaveTGZ.Text = "SaveTGZ";
            this.SaveTGZ.UseVisualStyleBackColor = false;
            this.SaveTGZ.Click += new System.EventHandler(this.SaveTGZ_Click);
            // 
            // TGZShowDialogBtn
            // 
            this.TGZShowDialogBtn.BackColor = System.Drawing.Color.Gray;
            this.TGZShowDialogBtn.ForeColor = System.Drawing.Color.White;
            this.TGZShowDialogBtn.Location = new System.Drawing.Point(431, 212);
            this.TGZShowDialogBtn.Name = "TGZShowDialogBtn";
            this.TGZShowDialogBtn.Size = new System.Drawing.Size(31, 31);
            this.TGZShowDialogBtn.TabIndex = 8;
            this.TGZShowDialogBtn.Text = "...";
            this.TGZShowDialogBtn.UseVisualStyleBackColor = false;
            this.TGZShowDialogBtn.Click += new System.EventHandler(this.TGZShowDialogBtn_Click);
            // 
            // TGZ_Path_textbox
            // 
            this.TGZ_Path_textbox.BackColor = System.Drawing.Color.Gray;
            this.TGZ_Path_textbox.ForeColor = System.Drawing.Color.White;
            this.TGZ_Path_textbox.Location = new System.Drawing.Point(10, 212);
            this.TGZ_Path_textbox.Multiline = true;
            this.TGZ_Path_textbox.Name = "TGZ_Path_textbox";
            this.TGZ_Path_textbox.ReadOnly = true;
            this.TGZ_Path_textbox.Size = new System.Drawing.Size(415, 31);
            this.TGZ_Path_textbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.07477F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Convert UnityPackage to TAR.GZ archive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.07477F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "UnityPackage To TGZ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstStepToolStripMenuItem,
            this.extractUnityPackageToolStripMenuItem,
            this.convertToZIPToolStripMenuItem,
            this.convertToTARToolStripMenuItem,
            this.convertToTARGZToolStripMenuItem});
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.howToUseToolStripMenuItem.Text = "How to use";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // extractUnityPackageToolStripMenuItem
            // 
            this.extractUnityPackageToolStripMenuItem.Name = "extractUnityPackageToolStripMenuItem";
            this.extractUnityPackageToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.extractUnityPackageToolStripMenuItem.Text = "Extract UnityPackage";
            this.extractUnityPackageToolStripMenuItem.Click += new System.EventHandler(this.extractUnityPackageToolStripMenuItem_Click);
            // 
            // convertToZIPToolStripMenuItem
            // 
            this.convertToZIPToolStripMenuItem.Name = "convertToZIPToolStripMenuItem";
            this.convertToZIPToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.convertToZIPToolStripMenuItem.Text = "Convert to ZIP";
            this.convertToZIPToolStripMenuItem.Click += new System.EventHandler(this.convertToZIPToolStripMenuItem_Click);
            // 
            // convertToTARToolStripMenuItem
            // 
            this.convertToTARToolStripMenuItem.Name = "convertToTARToolStripMenuItem";
            this.convertToTARToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.convertToTARToolStripMenuItem.Text = "Convert to TAR";
            this.convertToTARToolStripMenuItem.Click += new System.EventHandler(this.convertToTARToolStripMenuItem_Click);
            // 
            // convertToTARGZToolStripMenuItem
            // 
            this.convertToTARGZToolStripMenuItem.Name = "convertToTARGZToolStripMenuItem";
            this.convertToTARGZToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.convertToTARGZToolStripMenuItem.Text = "Convert to TAR.GZ";
            this.convertToTARGZToolStripMenuItem.Click += new System.EventHandler(this.convertToTARGZToolStripMenuItem_Click);
            // 
            // firstStepToolStripMenuItem
            // 
            this.firstStepToolStripMenuItem.Name = "firstStepToolStripMenuItem";
            this.firstStepToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.firstStepToolStripMenuItem.Text = "First step";
            this.firstStepToolStripMenuItem.Click += new System.EventHandler(this.firstStepToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(477, 359);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.728972F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "UnityPackageTools";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ConvertToZIP.ResumeLayout(false);
            this.ConvertToZIP.PerformLayout();
            this.ConvertToTAR.ResumeLayout(false);
            this.ConvertToTAR.PerformLayout();
            this.ConvertToTGZ.ResumeLayout(false);
            this.ConvertToTGZ.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage ConvertToZIP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabPage ConvertToTAR;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unityPackageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenUnityPackage;
        private System.Windows.Forms.Button OpenFolderBtn1;
        private System.Windows.Forms.TextBox ExtractPath;
        private System.Windows.Forms.Label about1;
        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.Button ExtractUnityPackage;
        private System.Windows.Forms.FolderBrowserDialog OpenTargetFolder;
        private System.Windows.Forms.TabPage ConvertToTGZ;
        private System.Windows.Forms.Label about2;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.TextBox ZipPath_textbox;
        private System.Windows.Forms.Button ZIPShowDialogbtn;
        private System.Windows.Forms.SaveFileDialog SavePackageDialog;
        private System.Windows.Forms.Button SaveZIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TAR_Path_textbox;
        private System.Windows.Forms.Button TARShowDialogBtn;
        private System.Windows.Forms.Button SaveTAR;
        private System.Windows.Forms.Button SaveTGZ;
        private System.Windows.Forms.Button TGZShowDialogBtn;
        private System.Windows.Forms.TextBox TGZ_Path_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractUnityPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToZIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToTARGZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstStepToolStripMenuItem;
    }
}

