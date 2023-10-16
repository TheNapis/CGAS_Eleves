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
            this.batteryButton = new FontAwesome.Sharp.IconButton();
            this.dateLabel = new System.Windows.Forms.Label();
            this.problemButton = new FontAwesome.Sharp.IconButton();
            this.folderButton = new FontAwesome.Sharp.IconButton();
            this.timeLabel = new System.Windows.Forms.Label();
            this.appsButton = new FontAwesome.Sharp.IconButton();
            this.shutdownButton = new FontAwesome.Sharp.IconButton();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordAdmin1 = new CGAS_ELEVES_Winforms.Admin.passwordAdmin();
            this.statusPage1 = new CGAS_ELEVES_Winforms.Probleme.StatusPage();
            this.appsEleves1 = new CGAS_ELEVES_Winforms.Applications.AppsEleves();
            this.LeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMenu
            // 
            this.LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(163)))));
            this.LeftMenu.Controls.Add(this.batteryButton);
            this.LeftMenu.Controls.Add(this.dateLabel);
            this.LeftMenu.Controls.Add(this.problemButton);
            this.LeftMenu.Controls.Add(this.folderButton);
            this.LeftMenu.Controls.Add(this.timeLabel);
            this.LeftMenu.Controls.Add(this.appsButton);
            this.LeftMenu.Controls.Add(this.shutdownButton);
            this.LeftMenu.Controls.Add(this.pictureBox1);
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenu.Location = new System.Drawing.Point(0, 0);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(230, 761);
            this.LeftMenu.TabIndex = 0;
            this.LeftMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftMenu_Paint);
            // 
            // batteryButton
            // 
            this.batteryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.batteryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(163)))));
            this.batteryButton.FlatAppearance.BorderSize = 0;
            this.batteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batteryButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryButton.ForeColor = System.Drawing.Color.White;
            this.batteryButton.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.batteryButton.IconColor = System.Drawing.Color.White;
            this.batteryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.batteryButton.IconSize = 70;
            this.batteryButton.Location = new System.Drawing.Point(114, 664);
            this.batteryButton.Name = "batteryButton";
            this.batteryButton.Size = new System.Drawing.Size(113, 94);
            this.batteryButton.TabIndex = 7;
            this.batteryButton.Text = "Batterie";
            this.batteryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.batteryButton.UseVisualStyleBackColor = false;
            this.batteryButton.Click += new System.EventHandler(this.batteryButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(0, 164);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(230, 40);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "dateLabel";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // problemButton
            // 
            this.problemButton.FlatAppearance.BorderSize = 0;
            this.problemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.problemButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemButton.ForeColor = System.Drawing.Color.White;
            this.problemButton.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.problemButton.IconColor = System.Drawing.Color.White;
            this.problemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.problemButton.Location = new System.Drawing.Point(3, 358);
            this.problemButton.Name = "problemButton";
            this.problemButton.Size = new System.Drawing.Size(230, 50);
            this.problemButton.TabIndex = 5;
            this.problemButton.Text = "Un problème";
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
            this.folderButton.Location = new System.Drawing.Point(0, 302);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(230, 50);
            this.folderButton.TabIndex = 4;
            this.folderButton.Text = "Vos dossiers";
            this.folderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.folderButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(0, 99);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(230, 65);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "timeLabel";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.appsButton.Location = new System.Drawing.Point(0, 246);
            this.appsButton.Name = "appsButton";
            this.appsButton.Size = new System.Drawing.Size(230, 50);
            this.appsButton.TabIndex = 2;
            this.appsButton.Text = "Applications";
            this.appsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.appsButton.UseVisualStyleBackColor = true;
            this.appsButton.Click += new System.EventHandler(this.appsButton_Click);
            // 
            // shutdownButton
            // 
            this.shutdownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.shutdownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(163)))));
            this.shutdownButton.FlatAppearance.BorderSize = 0;
            this.shutdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shutdownButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownButton.ForeColor = System.Drawing.Color.White;
            this.shutdownButton.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.shutdownButton.IconColor = System.Drawing.Color.White;
            this.shutdownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.shutdownButton.Location = new System.Drawing.Point(0, 676);
            this.shutdownButton.Name = "shutdownButton";
            this.shutdownButton.Size = new System.Drawing.Size(113, 85);
            this.shutdownButton.TabIndex = 1;
            this.shutdownButton.Text = "Eteindre";
            this.shutdownButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.shutdownButton.UseVisualStyleBackColor = false;
            this.shutdownButton.Click += new System.EventHandler(this.shutdownButton_Click);
            // 
            // Time
            // 
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // passwordAdmin1
            // 
            this.passwordAdmin1.AutoSize = true;
            this.passwordAdmin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.passwordAdmin1.Location = new System.Drawing.Point(233, 0);
            this.passwordAdmin1.Name = "passwordAdmin1";
            this.passwordAdmin1.Size = new System.Drawing.Size(1050, 800);
            this.passwordAdmin1.TabIndex = 3;
            this.passwordAdmin1.Load += new System.EventHandler(this.passwordAdmin1_Load);
            // 
            // statusPage1
            // 
            this.statusPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.statusPage1.Location = new System.Drawing.Point(233, 0);
            this.statusPage1.Name = "statusPage1";
            this.statusPage1.Size = new System.Drawing.Size(1050, 800);
            this.statusPage1.TabIndex = 2;
            // 
            // appsEleves1
            // 
            this.appsEleves1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.appsEleves1.Location = new System.Drawing.Point(233, 0);
            this.appsEleves1.Name = "appsEleves1";
            this.appsEleves1.Size = new System.Drawing.Size(1050, 800);
            this.appsEleves1.TabIndex = 1;
            this.appsEleves1.Load += new System.EventHandler(this.appsEleves1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.passwordAdmin1);
            this.Controls.Add(this.statusPage1);
            this.Controls.Add(this.appsEleves1);
            this.Controls.Add(this.LeftMenu);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "CGAS Élèves";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftMenu.ResumeLayout(false);
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
        private FontAwesome.Sharp.IconButton batteryButton;
        private Applications.AppsEleves appsEleves1;
        private Probleme.StatusPage statusPage1;
        private Admin.passwordAdmin passwordAdmin1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

