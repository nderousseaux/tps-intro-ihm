namespace tp5
{
    partial class Form1
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
            this.btnExo1 = new System.Windows.Forms.Button();
            this.btnExo2 = new System.Windows.Forms.Button();
            this.btnExo4 = new System.Windows.Forms.Button();
            this.grpCate = new System.Windows.Forms.GroupBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.txtCate = new System.Windows.Forms.TextBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.btnExo3 = new System.Windows.Forms.Button();
            this.grpChoix = new System.Windows.Forms.GroupBox();
            this.cboCate = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExo5 = new System.Windows.Forms.Button();
            this.btnExo6 = new System.Windows.Forms.Button();
            this.btnExoRetablissement = new System.Windows.Forms.Button();
            this.grpCateDyna = new System.Windows.Forms.GroupBox();
            this.btnRecherche3 = new System.Windows.Forms.Button();
            this.btnExo7 = new System.Windows.Forms.Button();
            this.grpCate.SuspendLayout();
            this.grpChoix.SuspendLayout();
            this.grpCateDyna.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExo1
            // 
            this.btnExo1.Location = new System.Drawing.Point(12, 12);
            this.btnExo1.Name = "btnExo1";
            this.btnExo1.Size = new System.Drawing.Size(75, 23);
            this.btnExo1.TabIndex = 0;
            this.btnExo1.Text = "Exercice n°1";
            this.btnExo1.UseVisualStyleBackColor = true;
            this.btnExo1.Click += new System.EventHandler(this.btnExo1_Click);
            // 
            // btnExo2
            // 
            this.btnExo2.Location = new System.Drawing.Point(93, 12);
            this.btnExo2.Name = "btnExo2";
            this.btnExo2.Size = new System.Drawing.Size(75, 23);
            this.btnExo2.TabIndex = 1;
            this.btnExo2.Text = "Exercice n°2";
            this.btnExo2.UseVisualStyleBackColor = true;
            this.btnExo2.Click += new System.EventHandler(this.btnExo2_Click);
            // 
            // btnExo4
            // 
            this.btnExo4.Location = new System.Drawing.Point(255, 12);
            this.btnExo4.Name = "btnExo4";
            this.btnExo4.Size = new System.Drawing.Size(75, 23);
            this.btnExo4.TabIndex = 2;
            this.btnExo4.Text = "Exercice n°4";
            this.btnExo4.UseVisualStyleBackColor = true;
            this.btnExo4.Click += new System.EventHandler(this.btnExo4_Click);
            // 
            // grpCate
            // 
            this.grpCate.Controls.Add(this.btnRecherche);
            this.grpCate.Controls.Add(this.txtCate);
            this.grpCate.Controls.Add(this.lblCate);
            this.grpCate.Location = new System.Drawing.Point(12, 41);
            this.grpCate.Name = "grpCate";
            this.grpCate.Size = new System.Drawing.Size(374, 69);
            this.grpCate.TabIndex = 3;
            this.grpCate.TabStop = false;
            this.grpCate.Text = "Choix de la catégorie";
            this.grpCate.Visible = false;
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(293, 24);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 5;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // txtCate
            // 
            this.txtCate.Location = new System.Drawing.Point(142, 26);
            this.txtCate.Name = "txtCate";
            this.txtCate.Size = new System.Drawing.Size(145, 20);
            this.txtCate.TabIndex = 4;
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(6, 29);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(130, 13);
            this.lblCate.TabIndex = 0;
            this.lblCate.Text = "Choisissez une catégorie :";
            // 
            // btnExo3
            // 
            this.btnExo3.Location = new System.Drawing.Point(174, 12);
            this.btnExo3.Name = "btnExo3";
            this.btnExo3.Size = new System.Drawing.Size(75, 23);
            this.btnExo3.TabIndex = 4;
            this.btnExo3.Text = "Exercice n°3";
            this.btnExo3.UseVisualStyleBackColor = true;
            this.btnExo3.Click += new System.EventHandler(this.btnExo3_Click);
            // 
            // grpChoix
            // 
            this.grpChoix.Controls.Add(this.cboCate);
            this.grpChoix.Controls.Add(this.button1);
            this.grpChoix.Controls.Add(this.label1);
            this.grpChoix.Location = new System.Drawing.Point(414, 41);
            this.grpChoix.Name = "grpChoix";
            this.grpChoix.Size = new System.Drawing.Size(374, 69);
            this.grpChoix.TabIndex = 6;
            this.grpChoix.TabStop = false;
            this.grpChoix.Text = "Choix de la catégorie v2.0";
            this.grpChoix.Visible = false;
            // 
            // cboCate
            // 
            this.cboCate.FormattingEnabled = true;
            this.cboCate.Location = new System.Drawing.Point(142, 26);
            this.cboCate.Name = "cboCate";
            this.cboCate.Size = new System.Drawing.Size(145, 21);
            this.cboCate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Recherche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choisissez une catégorie :";
            // 
            // btnExo5
            // 
            this.btnExo5.Location = new System.Drawing.Point(336, 12);
            this.btnExo5.Name = "btnExo5";
            this.btnExo5.Size = new System.Drawing.Size(75, 23);
            this.btnExo5.TabIndex = 7;
            this.btnExo5.Text = "Exercice n°5";
            this.btnExo5.UseVisualStyleBackColor = true;
            this.btnExo5.Click += new System.EventHandler(this.btnExo5_Click);
            // 
            // btnExo6
            // 
            this.btnExo6.Location = new System.Drawing.Point(417, 12);
            this.btnExo6.Name = "btnExo6";
            this.btnExo6.Size = new System.Drawing.Size(75, 23);
            this.btnExo6.TabIndex = 8;
            this.btnExo6.Text = "Exercice n°6";
            this.btnExo6.UseVisualStyleBackColor = true;
            this.btnExo6.Click += new System.EventHandler(this.btnExo6_Click);
            // 
            // btnExoRetablissement
            // 
            this.btnExoRetablissement.Location = new System.Drawing.Point(692, 12);
            this.btnExoRetablissement.Name = "btnExoRetablissement";
            this.btnExoRetablissement.Size = new System.Drawing.Size(96, 23);
            this.btnExoRetablissement.TabIndex = 9;
            this.btnExoRetablissement.Text = "Rétablissement";
            this.btnExoRetablissement.UseVisualStyleBackColor = true;
            this.btnExoRetablissement.Click += new System.EventHandler(this.btnExoRetablissement_Click);
            // 
            // grpCateDyna
            // 
            this.grpCateDyna.Controls.Add(this.btnRecherche3);
            this.grpCateDyna.Location = new System.Drawing.Point(12, 116);
            this.grpCateDyna.Name = "grpCateDyna";
            this.grpCateDyna.Size = new System.Drawing.Size(776, 322);
            this.grpCateDyna.TabIndex = 10;
            this.grpCateDyna.TabStop = false;
            this.grpCateDyna.Text = "Choix de la catégorie v3.0";
            this.grpCateDyna.Visible = false;
            // 
            // btnRecherche3
            // 
            this.btnRecherche3.Location = new System.Drawing.Point(680, 293);
            this.btnRecherche3.Name = "btnRecherche3";
            this.btnRecherche3.Size = new System.Drawing.Size(90, 23);
            this.btnRecherche3.TabIndex = 12;
            this.btnRecherche3.Text = "Rechercher";
            this.btnRecherche3.UseVisualStyleBackColor = true;
            this.btnRecherche3.Click += new System.EventHandler(this.btnRecherche3_Click);
            // 
            // btnExo7
            // 
            this.btnExo7.Location = new System.Drawing.Point(498, 12);
            this.btnExo7.Name = "btnExo7";
            this.btnExo7.Size = new System.Drawing.Size(75, 23);
            this.btnExo7.TabIndex = 11;
            this.btnExo7.Text = "Exercice n°7";
            this.btnExo7.UseVisualStyleBackColor = true;
            this.btnExo7.Click += new System.EventHandler(this.btnExo7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExo7);
            this.Controls.Add(this.grpCateDyna);
            this.Controls.Add(this.btnExoRetablissement);
            this.Controls.Add(this.btnExo6);
            this.Controls.Add(this.btnExo5);
            this.Controls.Add(this.grpChoix);
            this.Controls.Add(this.btnExo3);
            this.Controls.Add(this.grpCate);
            this.Controls.Add(this.btnExo4);
            this.Controls.Add(this.btnExo2);
            this.Controls.Add(this.btnExo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCate.ResumeLayout(false);
            this.grpCate.PerformLayout();
            this.grpChoix.ResumeLayout(false);
            this.grpChoix.PerformLayout();
            this.grpCateDyna.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExo1;
        private System.Windows.Forms.Button btnExo2;
        private System.Windows.Forms.Button btnExo4;
        private System.Windows.Forms.GroupBox grpCate;
        private System.Windows.Forms.TextBox txtCate;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnExo3;
        private System.Windows.Forms.GroupBox grpChoix;
        private System.Windows.Forms.Button btnExo5;
        private System.Windows.Forms.ComboBox cboCate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExo6;
        private System.Windows.Forms.Button btnExoRetablissement;
        private System.Windows.Forms.GroupBox grpCateDyna;
        private System.Windows.Forms.Button btnExo7;
        private System.Windows.Forms.Button btnRecherche3;
    }
}

