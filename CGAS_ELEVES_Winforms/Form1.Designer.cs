namespace CGAS_ELEVES_Winforms
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LeftMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appsButton = new FontAwesome.Sharp.IconButton();
            this.batteryButton = new FontAwesome.Sharp.IconButton();
            this.dateLabel = new System.Windows.Forms.Label();
            this.problemButton = new FontAwesome.Sharp.IconButton();
            this.folderButton = new FontAwesome.Sharp.IconButton();
            this.timeLabel = new System.Windows.Forms.Label();
            this.shutdownButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.appsEleves1 = new CGAS_ELEVES_Winforms.Applications.AppsEleves();
            this.passwordAdmin1 = new CGAS_ELEVES_Winforms.Admin.passwordAdmin();
            this.statusPage1 = new CGAS_ELEVES_Winforms.Probleme.StatusPage();
            this.LeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMenu
            // 
            this.LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(163)))));
            this.LeftMenu.Controls.Add(this.panel2);
            this.LeftMenu.Controls.Add(this.statusButton);
            this.LeftMenu.Controls.Add(this.panel1);
            this.LeftMenu.Controls.Add(this.appsButton);
            this.LeftMenu.Controls.Add(this.batteryButton);
            this.LeftMenu.Controls.Add(this.dateLabel);
            this.LeftMenu.Controls.Add(this.problemButton);
            this.LeftMenu.Controls.Add(this.folderButton);
            this.LeftMenu.Controls.Add(this.timeLabel);
            this.LeftMenu.Controls.Add(this.shutdownButton);
            this.LeftMenu.Controls.Add(this.pictureBox1);
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftMenu.Location = new System.Drawing.Point(0, 0);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(1264, 90);
            this.LeftMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.panel2.Location = new System.Drawing.Point(375, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 90);
            this.panel2.TabIndex = 5;
            // 
            // statusButton
            // 
            this.statusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(163)))));
            this.statusButton.FlatAppearance.BorderSize = 0;
            this.statusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusButton.ForeColor = System.Drawing.Color.White;
            this.statusButton.IconChar = FontAwesome.Sharp.IconChar.WifiStrong;
            this.statusButton.IconColor = System.Drawing.Color.White;
            this.statusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusButton.IconSize = 40;
            this.statusButton.Location = new System.Drawing.Point(315, 47);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(59, 43);
            this.statusButton.TabIndex = 8;
            this.statusButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.statusButton.UseVisualStyleBackColor = false;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.panel1.Location = new System.Drawing.Point(304, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 90);
            this.panel1.TabIndex = 4;
            // 
            // appsButton
            // 
            this.appsButton.FlatAppearance.BorderSize = 0;
            this.appsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appsButton.ForeColor = System.Drawing.Color.White;
            this.appsButton.IconChar = FontAwesome.Sharp.IconChar.House;
            this.appsButton.IconColor = System.Drawing.Color.White;
            this.appsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.appsButton.Location = new System.Drawing.Point(391, 3);
            this.appsButton.Name = "appsButton";
            this.appsButton.Size = new System.Drawing.Size(137, 84);
            this.appsButton.TabIndex = 2;
            this.appsButton.Text = "Applications";
            this.appsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.appsButton.UseVisualStyleBackColor = true;
            this.appsButton.Click += new System.EventHandler(this.appsButton_Click);
            // 
            // batteryButton
            // 
            this.batteryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(163)))));
            this.batteryButton.FlatAppearance.BorderSize = 0;
            this.batteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batteryButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryButton.ForeColor = System.Drawing.Color.White;
            this.batteryButton.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.batteryButton.IconColor = System.Drawing.Color.White;
            this.batteryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.batteryButton.IconSize = 50;
            this.batteryButton.Location = new System.Drawing.Point(315, 3);
            this.batteryButton.Name = "batteryButton";
            this.batteryButton.Size = new System.Drawing.Size(59, 43);
            this.batteryButton.TabIndex = 7;
            this.batteryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.batteryButton.UseVisualStyleBackColor = false;
            this.batteryButton.Click += new System.EventHandler(this.batteryButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(149, 47);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(111, 28);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "dateLabel";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // problemButton
            // 
            this.problemButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.problemButton.FlatAppearance.BorderSize = 0;
            this.problemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.problemButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemButton.ForeColor = System.Drawing.Color.White;
            this.problemButton.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.problemButton.IconColor = System.Drawing.Color.White;
            this.problemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.problemButton.IconSize = 70;
            this.problemButton.Location = new System.Drawing.Point(1064, 0);
            this.problemButton.Name = "problemButton";
            this.problemButton.Size = new System.Drawing.Size(100, 90);
            this.problemButton.TabIndex = 5;
            this.problemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.problemButton.UseVisualStyleBackColor = true;
            this.problemButton.Click += new System.EventHandler(this.problemButton_Click);
            // 
            // folderButton
            // 
            this.folderButton.FlatAppearance.BorderSize = 0;
            this.folderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderButton.ForeColor = System.Drawing.Color.White;
            this.folderButton.IconChar = FontAwesome.Sharp.IconChar.List;
            this.folderButton.IconColor = System.Drawing.Color.White;
            this.folderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.folderButton.Location = new System.Drawing.Point(534, 3);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(145, 84);
            this.folderButton.TabIndex = 4;
            this.folderButton.Text = "Vos dossiers";
            this.folderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(148, 11);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(161, 39);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "timeLabel";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shutdownButton
            // 
            this.shutdownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(163)))));
            this.shutdownButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.shutdownButton.FlatAppearance.BorderSize = 0;
            this.shutdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdownButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownButton.ForeColor = System.Drawing.Color.White;
            this.shutdownButton.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.shutdownButton.IconColor = System.Drawing.Color.White;
            this.shutdownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.shutdownButton.IconSize = 70;
            this.shutdownButton.Location = new System.Drawing.Point(1164, 0);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(100, 90);
            this.shutdownButton.TabIndex = 1;
            this.shutdownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.shutdownButton.UseVisualStyleBackColor = false;
            this.shutdownButton.Click += new System.EventHandler(this.shutdownButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.logo_CGAS;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Time
            // 
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // appsEleves1
            // 
            this.appsEleves1.AutoSize = true;
            this.appsEleves1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.appsEleves1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appsEleves1.Location = new System.Drawing.Point(0, 90);
            this.appsEleves1.Margin = new System.Windows.Forms.Padding(4);
            this.appsEleves1.Name = "appsEleves1";
            this.appsEleves1.Size = new System.Drawing.Size(1264, 659);
            this.appsEleves1.TabIndex = 1;
            this.appsEleves1.Load += new System.EventHandler(this.appsEleves1_Load);
            // 
            // passwordAdmin1
            // 
            this.passwordAdmin1.AutoSize = true;
            this.passwordAdmin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.passwordAdmin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordAdmin1.Location = new System.Drawing.Point(0, 90);
            this.passwordAdmin1.Margin = new System.Windows.Forms.Padding(4);
            this.passwordAdmin1.Name = "passwordAdmin1";
            this.passwordAdmin1.Size = new System.Drawing.Size(1264, 659);
            this.passwordAdmin1.TabIndex = 3;
            // 
            // statusPage1
            // 
            this.statusPage1.AutoSize = true;
            this.statusPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.statusPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusPage1.Location = new System.Drawing.Point(0, 90);
            this.statusPage1.Margin = new System.Windows.Forms.Padding(4);
            this.statusPage1.Name = "statusPage1";
            this.statusPage1.Size = new System.Drawing.Size(1264, 659);
            this.statusPage1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.appsEleves1);
            this.Controls.Add(this.passwordAdmin1);
            this.Controls.Add(this.statusPage1);
            this.Controls.Add(this.LeftMenu);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "CGAS Élèves";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftMenu.ResumeLayout(false);
            this.LeftMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftMenu;
        private FontAwesome.Sharp.IconButton shutdownButton;
        private FontAwesome.Sharp.IconButton appsButton;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Label timeLabel;
        private FontAwesome.Sharp.IconButton problemButton;
        private FontAwesome.Sharp.IconButton folderButton;
        private System.Windows.Forms.Label dateLabel;
        private Applications.AppsEleves appsEleves1;
        private Probleme.StatusPage statusPage1;
        private Admin.passwordAdmin passwordAdmin1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton batteryButton;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton statusButton;
        private System.Windows.Forms.Panel panel2;
    }
}

