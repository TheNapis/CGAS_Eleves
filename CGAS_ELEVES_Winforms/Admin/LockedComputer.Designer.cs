namespace CGAS_ELEVES_Winforms.Admin
{
    partial class LockedComputer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appsButton1 = new CGAS_ELEVES_Winforms.Class.AppsButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1280, 93);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zone Enseignants";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(330, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordinateur Verrouillé";
            // 
            // appsButton1
            // 
            this.appsButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.appsButton1.FlatAppearance.BorderSize = 0;
            this.appsButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appsButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appsButton1.ForeColor = System.Drawing.Color.White;
            this.appsButton1.Location = new System.Drawing.Point(398, 584);
            this.appsButton1.Name = "appsButton1";
            this.appsButton1.Size = new System.Drawing.Size(223, 57);
            this.appsButton1.TabIndex = 7;
            this.appsButton1.Text = "Redémarrer";
            this.appsButton1.UseVisualStyleBackColor = false;
            this.appsButton1.Click += new System.EventHandler(this.appsButton1_Click);
            // 
            // LockedComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.appsButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "LockedComputer";
            this.Size = new System.Drawing.Size(1280, 788);
            this.Load += new System.EventHandler(this.LockedComputer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Class.AppsButton appsButton1;
    }
}
