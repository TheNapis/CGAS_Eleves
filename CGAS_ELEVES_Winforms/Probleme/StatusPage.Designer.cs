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
            this.label1 = new System.Windows.Forms.Label();
            this.statusButton = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.appsButton1 = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(1159, 93);
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
            this.statusButton.Location = new System.Drawing.Point(594, 132);
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
            this.label2.Location = new System.Drawing.Point(165, 150);
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
            this.label3.Location = new System.Drawing.Point(3, 301);
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
            this.label4.Location = new System.Drawing.Point(167, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(745, 69);
            this.label4.TabIndex = 4;
            this.label4.Text = "1 : Je détache puis attache le clavier de l\'ordinateur\r\n    (si son clavier est d" +
    "étachable)\r\n     \r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(167, 438);
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
            this.appsButton1.Location = new System.Drawing.Point(569, 434);
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
            this.label6.Location = new System.Drawing.Point(19, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 41);
            this.label6.TabIndex = 7;
            this.label6.Text = "Autres problèmes :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(167, 711);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(443, 51);
            this.label7.TabIndex = 8;
            this.label7.Text = "Je m\'adresse à mon enseignant";
            // 
            // StatusPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
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
            this.Size = new System.Drawing.Size(1159, 800);
            this.Load += new System.EventHandler(this.StatusPage_Load);
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
    }
}
