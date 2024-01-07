namespace CGAS_ELEVES_Winforms.Applications
{
    partial class AppsEleves
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WriterButton = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.ScratchButton = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.VocalButton = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.VLCButton = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.GlobeButton = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.GIMPButton = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.InternetButton = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.CalculatriceButton = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.PresentationButton = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.CalcButton = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Le monde du bureautique";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(907, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "J\'explore";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(511, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 46);
            this.label3.TabIndex = 15;
            this.label3.Text = "Les outils utiles";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // WriterButton
            // 
            this.WriterButton.BackColor = System.Drawing.Color.Salmon;
            this.WriterButton.FlatAppearance.BorderSize = 0;
            this.WriterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriterButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriterButton.ForeColor = System.Drawing.Color.White;
            this.WriterButton.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.Writer;
            this.WriterButton.Location = new System.Drawing.Point(384, 103);
            this.WriterButton.Name = "WriterButton";
            this.WriterButton.Size = new System.Drawing.Size(171, 106);
            this.WriterButton.TabIndex = 2;
            this.WriterButton.Text = "Texte LibreOffice";
            this.WriterButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WriterButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.WriterButton.UseVisualStyleBackColor = false;
            this.WriterButton.Click += new System.EventHandler(this.WriterButton_Click);
            // 
            // ScratchButton
            // 
            this.ScratchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScratchButton.BackColor = System.Drawing.Color.Salmon;
            this.ScratchButton.FlatAppearance.BorderSize = 0;
            this.ScratchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScratchButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScratchButton.ForeColor = System.Drawing.Color.White;
            this.ScratchButton.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.Scratch;
            this.ScratchButton.Location = new System.Drawing.Point(726, 103);
            this.ScratchButton.Name = "ScratchButton";
            this.ScratchButton.Size = new System.Drawing.Size(171, 106);
            this.ScratchButton.TabIndex = 12;
            this.ScratchButton.Text = "Programmation Scratch";
            this.ScratchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ScratchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ScratchButton.UseVisualStyleBackColor = false;
            this.ScratchButton.Click += new System.EventHandler(this.ScratchButton_Click);
            // 
            // VocalButton
            // 
            this.VocalButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VocalButton.BackColor = System.Drawing.Color.Salmon;
            this.VocalButton.FlatAppearance.BorderSize = 0;
            this.VocalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VocalButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VocalButton.ForeColor = System.Drawing.Color.White;
            this.VocalButton.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.Vocal;
            this.VocalButton.Location = new System.Drawing.Point(1080, 416);
            this.VocalButton.Name = "VocalButton";
            this.VocalButton.Size = new System.Drawing.Size(171, 106);
            this.VocalButton.TabIndex = 11;
            this.VocalButton.Text = "Enregistreur Vocal";
            this.VocalButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VocalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VocalButton.UseVisualStyleBackColor = false;
            this.VocalButton.Click += new System.EventHandler(this.VocalButton_Click);
            // 
            // VLCButton
            // 
            this.VLCButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VLCButton.BackColor = System.Drawing.Color.Salmon;
            this.VLCButton.FlatAppearance.BorderSize = 0;
            this.VLCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VLCButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VLCButton.ForeColor = System.Drawing.Color.White;
            this.VLCButton.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.VLC;
            this.VLCButton.Location = new System.Drawing.Point(30, 416);
            this.VLCButton.Name = "VLCButton";
            this.VLCButton.Size = new System.Drawing.Size(171, 106);
            this.VLCButton.TabIndex = 10;
            this.VLCButton.Text = "Vidéo / Audio VLC";
            this.VLCButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VLCButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VLCButton.UseVisualStyleBackColor = false;
            this.VLCButton.Click += new System.EventHandler(this.VLCButton_Click);
            // 
            // GlobeButton
            // 
            this.GlobeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GlobeButton.BackColor = System.Drawing.Color.Salmon;
            this.GlobeButton.FlatAppearance.BorderSize = 0;
            this.GlobeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GlobeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlobeButton.ForeColor = System.Drawing.Color.White;
            this.GlobeButton.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.Earth;
            this.GlobeButton.Location = new System.Drawing.Point(903, 181);
            this.GlobeButton.Name = "GlobeButton";
            this.GlobeButton.Size = new System.Drawing.Size(171, 106);
            this.GlobeButton.TabIndex = 8;
            this.GlobeButton.Text = "Globe virtuel";
            this.GlobeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GlobeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GlobeButton.UseVisualStyleBackColor = false;
            this.GlobeButton.Click += new System.EventHandler(this.GlobeButton_Click);
            // 
            // GIMPButton
            // 
            this.GIMPButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GIMPButton.BackColor = System.Drawing.Color.Salmon;
            this.GIMPButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GIMPButton.FlatAppearance.BorderSize = 0;
            this.GIMPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GIMPButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIMPButton.ForeColor = System.Drawing.Color.White;
            this.GIMPButton.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.GIMP;
            this.GIMPButton.Location = new System.Drawing.Point(384, 416);
            this.GIMPButton.Name = "GIMPButton";
            this.GIMPButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GIMPButton.Size = new System.Drawing.Size(171, 106);
            this.GIMPButton.TabIndex = 6;
            this.GIMPButton.Text = "Dessin G.I.M.P.";
            this.GIMPButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GIMPButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GIMPButton.UseVisualStyleBackColor = false;
            this.GIMPButton.Click += new System.EventHandler(this.GIMPButton_Click);
            // 
            // InternetButton
            // 
            this.InternetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InternetButton.BackColor = System.Drawing.Color.Salmon;
            this.InternetButton.FlatAppearance.BorderSize = 0;
            this.InternetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InternetButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternetButton.ForeColor = System.Drawing.Color.White;
            this.InternetButton.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.Edge;
            this.InternetButton.Location = new System.Drawing.Point(1080, 103);
            this.InternetButton.Name = "InternetButton";
            this.InternetButton.Size = new System.Drawing.Size(170, 105);
            this.InternetButton.TabIndex = 5;
            this.InternetButton.Text = "Internet";
            this.InternetButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InternetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.InternetButton.UseVisualStyleBackColor = false;
            this.InternetButton.Click += new System.EventHandler(this.InternetButton_Click);
            // 
            // CalculatriceButton
            // 
            this.CalculatriceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculatriceButton.BackColor = System.Drawing.Color.Salmon;
            this.CalculatriceButton.FlatAppearance.BorderSize = 0;
            this.CalculatriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculatriceButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatriceButton.ForeColor = System.Drawing.Color.White;
            this.CalculatriceButton.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.Calcdk;
            this.CalculatriceButton.Location = new System.Drawing.Point(726, 416);
            this.CalculatriceButton.Name = "CalculatriceButton";
            this.CalculatriceButton.Size = new System.Drawing.Size(171, 106);
            this.CalculatriceButton.TabIndex = 4;
            this.CalculatriceButton.Text = "Calculatrice";
            this.CalculatriceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CalculatriceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CalculatriceButton.UseVisualStyleBackColor = false;
            this.CalculatriceButton.Click += new System.EventHandler(this.CalculatriceButton_Click);
            // 
            // PresentationButton
            // 
            this.PresentationButton.BackColor = System.Drawing.Color.Salmon;
            this.PresentationButton.FlatAppearance.BorderSize = 0;
            this.PresentationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PresentationButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentationButton.ForeColor = System.Drawing.Color.White;
            this.PresentationButton.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.Presentation;
            this.PresentationButton.Location = new System.Drawing.Point(30, 102);
            this.PresentationButton.Name = "PresentationButton";
            this.PresentationButton.Size = new System.Drawing.Size(171, 106);
            this.PresentationButton.TabIndex = 3;
            this.PresentationButton.Text = "Presentation LibreOffice";
            this.PresentationButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PresentationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PresentationButton.UseVisualStyleBackColor = false;
            this.PresentationButton.Click += new System.EventHandler(this.PresentationButton_Click);
            // 
            // CalcButton
            // 
            this.CalcButton.BackColor = System.Drawing.Color.Salmon;
            this.CalcButton.FlatAppearance.BorderSize = 0;
            this.CalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcButton.ForeColor = System.Drawing.Color.White;
            this.CalcButton.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.Calc;
            this.CalcButton.Location = new System.Drawing.Point(207, 181);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(171, 106);
            this.CalcButton.TabIndex = 1;
            this.CalcButton.Text = "Tableur LibreOffice";
            this.CalcButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CalcButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CalcButton.UseVisualStyleBackColor = false;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // AppsEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WriterButton);
            this.Controls.Add(this.ScratchButton);
            this.Controls.Add(this.VocalButton);
            this.Controls.Add(this.VLCButton);
            this.Controls.Add(this.GlobeButton);
            this.Controls.Add(this.GIMPButton);
            this.Controls.Add(this.InternetButton);
            this.Controls.Add(this.CalculatriceButton);
            this.Controls.Add(this.PresentationButton);
            this.Controls.Add(this.CalcButton);
            this.Name = "AppsEleves";
            this.Size = new System.Drawing.Size(1280, 660);
            this.Load += new System.EventHandler(this.AppsEleves_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Class.AppsButton WriterButton;
        private Class.AppsButton PresentationButton;
        private Class.AppsButton CalculatriceButton;
        private Class.AppsButton InternetButton;
        private Class.AppsButton GIMPButton;
        private Class.AppsButton GlobeButton;
        private Class.AppsButton VLCButton;
        private Class.AppsButton VocalButton;
        private Class.AppsButton ScratchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Class.AppsButton CalcButton;
    }
}
