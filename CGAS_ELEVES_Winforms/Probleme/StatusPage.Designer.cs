namespace CGAS_ELEVES_Winforms.Probleme
{
    partial class StatusPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusPage));
            this.label1 = new System.Windows.Forms.Label();
            this.statusButton = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.appsButton1 = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(163)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1280, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Un problème ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusButton
            // 
            this.statusButton.FlatAppearance.BorderSize = 0;
            this.statusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusButton.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.statusButton.IconColor = System.Drawing.Color.Black;
            this.statusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusButton.IconSize = 60;
            this.statusButton.Location = new System.Drawing.Point(390, 96);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(107, 92);
            this.statusButton.TabIndex = 1;
            this.statusButton.UseVisualStyleBackColor = true;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connexion à Internet : ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(579, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Problème de clavier ou souris :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(630, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(556, 69);
            this.label4.TabIndex = 4;
            this.label4.Text = "1 : Je détache puis attache le clavier de l\'ordinateur\r\n    (si son clavier est d" +
    "étachable)\r\n     \r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(630, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(396, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "2 : Essaye de redémarrer l\'ordinateur : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // appsButton1
            // 
            this.appsButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.appsButton1.FlatAppearance.BorderSize = 0;
            this.appsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appsButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appsButton1.ForeColor = System.Drawing.Color.White;
            this.appsButton1.Location = new System.Drawing.Point(1032, 201);
            this.appsButton1.Name = "appsButton1";
            this.appsButton1.Size = new System.Drawing.Size(195, 40);
            this.appsButton1.TabIndex = 6;
            this.appsButton1.Text = "Redémarrer";
            this.appsButton1.UseVisualStyleBackColor = false;
            this.appsButton1.Click += new System.EventHandler(this.appsButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 41);
            this.label6.TabIndex = 7;
            this.label6.Text = "Autres problèmes :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(68, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(346, 69);
            this.label7.TabIndex = 8;
            this.label7.Text = "Je m\'adresse à mon enseignant";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(895, 443);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(579, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(422, 41);
            this.label8.TabIndex = 10;
            this.label8.Text = "Problème de chargement :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(630, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(574, 69);
            this.label9.TabIndex = 11;
            this.label9.Text = "1 : Je regarde si la lumière à côté du chargeur s\'allume\r\n    \r\n";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(630, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(509, 36);
            this.label10.TabIndex = 12;
            this.label10.Text = "2 : Je vérifie que j\'ai bien branché l\'ordinateur";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(630, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(509, 36);
            this.label11.TabIndex = 13;
            this.label11.Text = "3 : Je signale l\'ordinateur à mon enseignant.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CGAS_ELEVES_Winforms.Properties.Resources.SCHEMA_BATT2;
            this.pictureBox2.Location = new System.Drawing.Point(586, 443);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // StatusPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.appsButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.label1);
            this.Name = "StatusPage";
            this.Size = new System.Drawing.Size(1280, 800);
            this.Load += new System.EventHandler(this.StatusPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton statusButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Class.AppsButton appsButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
