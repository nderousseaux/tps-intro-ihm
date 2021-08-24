namespace traducVerbe
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
            this.lblChoix = new System.Windows.Forms.Label();
            this.cmbVerbe = new System.Windows.Forms.ComboBox();
            this.grpLangue = new System.Windows.Forms.GroupBox();
            this.rdoItalien = new System.Windows.Forms.RadioButton();
            this.rdoEspagnol = new System.Windows.Forms.RadioButton();
            this.rdoAllemand = new System.Windows.Forms.RadioButton();
            this.rdoAnglais = new System.Windows.Forms.RadioButton();
            this.grpResultat = new System.Windows.Forms.GroupBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.grpLangue.SuspendLayout();
            this.grpResultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Location = new System.Drawing.Point(9, 37);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(84, 13);
            this.lblChoix.TabIndex = 0;
            this.lblChoix.Text = "Choix du verbe :";
            // 
            // cmbVerbe
            // 
            this.cmbVerbe.FormattingEnabled = true;
            this.cmbVerbe.Location = new System.Drawing.Point(99, 34);
            this.cmbVerbe.Name = "cmbVerbe";
            this.cmbVerbe.Size = new System.Drawing.Size(184, 21);
            this.cmbVerbe.TabIndex = 1;
            this.cmbVerbe.SelectedIndexChanged += new System.EventHandler(this.traduction);
            // 
            // grpLangue
            // 
            this.grpLangue.Controls.Add(this.rdoItalien);
            this.grpLangue.Controls.Add(this.rdoEspagnol);
            this.grpLangue.Controls.Add(this.rdoAllemand);
            this.grpLangue.Controls.Add(this.rdoAnglais);
            this.grpLangue.Location = new System.Drawing.Point(12, 70);
            this.grpLangue.Name = "grpLangue";
            this.grpLangue.Size = new System.Drawing.Size(380, 116);
            this.grpLangue.TabIndex = 2;
            this.grpLangue.TabStop = false;
            this.grpLangue.Text = "Choix de la langue";
            // 
            // rdoItalien
            // 
            this.rdoItalien.AutoSize = true;
            this.rdoItalien.Location = new System.Drawing.Point(6, 88);
            this.rdoItalien.Name = "rdoItalien";
            this.rdoItalien.Size = new System.Drawing.Size(53, 17);
            this.rdoItalien.TabIndex = 3;
            this.rdoItalien.TabStop = true;
            this.rdoItalien.Tag = "italien";
            this.rdoItalien.Text = "Italien";
            this.rdoItalien.UseVisualStyleBackColor = true;
            this.rdoItalien.Click += new System.EventHandler(this.traduction);
            // 
            // rdoEspagnol
            // 
            this.rdoEspagnol.AutoSize = true;
            this.rdoEspagnol.Location = new System.Drawing.Point(6, 65);
            this.rdoEspagnol.Name = "rdoEspagnol";
            this.rdoEspagnol.Size = new System.Drawing.Size(69, 17);
            this.rdoEspagnol.TabIndex = 2;
            this.rdoEspagnol.TabStop = true;
            this.rdoEspagnol.Tag = "espagnol";
            this.rdoEspagnol.Text = "Espagnol";
            this.rdoEspagnol.UseVisualStyleBackColor = true;
            this.rdoEspagnol.Click += new System.EventHandler(this.traduction);
            // 
            // rdoAllemand
            // 
            this.rdoAllemand.AutoSize = true;
            this.rdoAllemand.Location = new System.Drawing.Point(6, 42);
            this.rdoAllemand.Name = "rdoAllemand";
            this.rdoAllemand.Size = new System.Drawing.Size(68, 17);
            this.rdoAllemand.TabIndex = 1;
            this.rdoAllemand.TabStop = true;
            this.rdoAllemand.Tag = "allemand";
            this.rdoAllemand.Text = "Allemand";
            this.rdoAllemand.UseVisualStyleBackColor = true;
            this.rdoAllemand.Click += new System.EventHandler(this.traduction);
            // 
            // rdoAnglais
            // 
            this.rdoAnglais.AutoSize = true;
            this.rdoAnglais.Location = new System.Drawing.Point(6, 19);
            this.rdoAnglais.Name = "rdoAnglais";
            this.rdoAnglais.Size = new System.Drawing.Size(59, 17);
            this.rdoAnglais.TabIndex = 0;
            this.rdoAnglais.TabStop = true;
            this.rdoAnglais.Tag = "anglais";
            this.rdoAnglais.Text = "Anglais";
            this.rdoAnglais.UseVisualStyleBackColor = true;
            this.rdoAnglais.Click += new System.EventHandler(this.traduction);
            // 
            // grpResultat
            // 
            this.grpResultat.Controls.Add(this.lblResultat);
            this.grpResultat.Location = new System.Drawing.Point(12, 192);
            this.grpResultat.Name = "grpResultat";
            this.grpResultat.Size = new System.Drawing.Size(380, 83);
            this.grpResultat.TabIndex = 3;
            this.grpResultat.TabStop = false;
            this.grpResultat.Text = "Résultat";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(6, 25);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(184, 13);
            this.lblResultat.TabIndex = 0;
            this.lblResultat.Text = "Sélectionnez un verbe et une langue.";
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(289, 34);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(103, 21);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "Ajouter un verbe";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 285);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.grpResultat);
            this.Controls.Add(this.grpLangue);
            this.Controls.Add(this.cmbVerbe);
            this.Controls.Add(this.lblChoix);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLangue.ResumeLayout(false);
            this.grpLangue.PerformLayout();
            this.grpResultat.ResumeLayout(false);
            this.grpResultat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.ComboBox cmbVerbe;
        private System.Windows.Forms.GroupBox grpLangue;
        private System.Windows.Forms.RadioButton rdoItalien;
        private System.Windows.Forms.RadioButton rdoEspagnol;
        private System.Windows.Forms.RadioButton rdoAllemand;
        private System.Windows.Forms.RadioButton rdoAnglais;
        private System.Windows.Forms.GroupBox grpResultat;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnAjout;
    }
}

