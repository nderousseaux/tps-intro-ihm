namespace trombino
{
    partial class frmTrombino
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
            this.lblChoixPromo = new System.Windows.Forms.Label();
            this.cboChoixPromo = new System.Windows.Forms.ComboBox();
            this.grpEtudiant = new System.Windows.Forms.GroupBox();
            this.rdoListe = new System.Windows.Forms.RadioButton();
            this.rdoTrombino = new System.Windows.Forms.RadioButton();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnCocher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpEtudiant.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChoixPromo
            // 
            this.lblChoixPromo.AutoSize = true;
            this.lblChoixPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblChoixPromo.Location = new System.Drawing.Point(224, 13);
            this.lblChoixPromo.Name = "lblChoixPromo";
            this.lblChoixPromo.Size = new System.Drawing.Size(152, 17);
            this.lblChoixPromo.TabIndex = 0;
            this.lblChoixPromo.Text = "Choix de la promotion :";
            // 
            // cboChoixPromo
            // 
            this.cboChoixPromo.FormattingEnabled = true;
            this.cboChoixPromo.Location = new System.Drawing.Point(382, 12);
            this.cboChoixPromo.Name = "cboChoixPromo";
            this.cboChoixPromo.Size = new System.Drawing.Size(186, 21);
            this.cboChoixPromo.TabIndex = 1;
            this.cboChoixPromo.SelectedIndexChanged += new System.EventHandler(this.cboChoixPromo_SelectedIndexChanged);
            // 
            // grpEtudiant
            // 
            this.grpEtudiant.Controls.Add(this.label2);
            this.grpEtudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpEtudiant.Location = new System.Drawing.Point(15, 91);
            this.grpEtudiant.Name = "grpEtudiant";
            this.grpEtudiant.Size = new System.Drawing.Size(773, 418);
            this.grpEtudiant.TabIndex = 2;
            this.grpEtudiant.TabStop = false;
            this.grpEtudiant.Text = "Etudiants";
            // 
            // rdoListe
            // 
            this.rdoListe.AutoSize = true;
            this.rdoListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoListe.Location = new System.Drawing.Point(382, 39);
            this.rdoListe.Name = "rdoListe";
            this.rdoListe.Size = new System.Drawing.Size(56, 21);
            this.rdoListe.TabIndex = 0;
            this.rdoListe.TabStop = true;
            this.rdoListe.Text = "Liste";
            this.rdoListe.UseVisualStyleBackColor = true;
            this.rdoListe.Click += new System.EventHandler(this.rdoListe_Click);
            // 
            // rdoTrombino
            // 
            this.rdoTrombino.AutoSize = true;
            this.rdoTrombino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdoTrombino.Location = new System.Drawing.Point(444, 39);
            this.rdoTrombino.Name = "rdoTrombino";
            this.rdoTrombino.Size = new System.Drawing.Size(124, 21);
            this.rdoTrombino.TabIndex = 3;
            this.rdoTrombino.TabStop = true;
            this.rdoTrombino.Text = "Trombinoscope";
            this.rdoTrombino.UseVisualStyleBackColor = true;
            this.rdoTrombino.Click += new System.EventHandler(this.rdoTrombino_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRecherche.Location = new System.Drawing.Point(511, 515);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(277, 28);
            this.btnRecherche.TabIndex = 4;
            this.btnRecherche.Text = "Ouvrir la fiche de tout les éléves cochés";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // btnCocher
            // 
            this.btnCocher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCocher.Location = new System.Drawing.Point(690, 57);
            this.btnCocher.Name = "btnCocher";
            this.btnCocher.Size = new System.Drawing.Size(98, 28);
            this.btnCocher.TabIndex = 5;
            this.btnCocher.Text = "Tout cocher";
            this.btnCocher.UseVisualStyleBackColor = true;
            this.btnCocher.Click += new System.EventHandler(this.btnCocher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(224, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mode d\'affichage :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(222, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Veuillez sélectionner une promotion !";
            // 
            // frmTrombino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.btnCocher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoTrombino);
            this.Controls.Add(this.rdoListe);
            this.Controls.Add(this.grpEtudiant);
            this.Controls.Add(this.cboChoixPromo);
            this.Controls.Add(this.lblChoixPromo);
            this.Name = "frmTrombino";
            this.Text = "Suivi des étudiants";
            this.Load += new System.EventHandler(this.frmTrombino_Load);
            this.grpEtudiant.ResumeLayout(false);
            this.grpEtudiant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChoixPromo;
        private System.Windows.Forms.ComboBox cboChoixPromo;
        private System.Windows.Forms.GroupBox grpEtudiant;
        private System.Windows.Forms.RadioButton rdoListe;
        private System.Windows.Forms.RadioButton rdoTrombino;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnCocher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

