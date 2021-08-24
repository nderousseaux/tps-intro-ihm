namespace gestionUtilisateur
{
    partial class frmUtilisateur
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblPromotion = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grpPrincipal = new System.Windows.Forms.GroupBox();
            this.cboPromotion = new System.Windows.Forms.ComboBox();
            this.grpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(48, 56);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(48, 108);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblPromotion
            // 
            this.lblPromotion.AutoSize = true;
            this.lblPromotion.Location = new System.Drawing.Point(48, 160);
            this.lblPromotion.Name = "lblPromotion";
            this.lblPromotion.Size = new System.Drawing.Size(60, 13);
            this.lblPromotion.TabIndex = 2;
            this.lblPromotion.Text = "Promotion :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(48, 212);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "Login :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(48, 264);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(77, 13);
            this.lblMdp.TabIndex = 4;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(131, 53);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(163, 20);
            this.txtNom.TabIndex = 5;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(131, 105);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(163, 20);
            this.txtPrenom.TabIndex = 6;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtPrenom_TextChanged);
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrenom_KeyPress);
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(131, 261);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(163, 20);
            this.txtMdp.TabIndex = 7;
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(131, 209);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(163, 20);
            this.txtLogin.TabIndex = 8;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(138, 331);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(219, 331);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(300, 331);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // grpPrincipal
            // 
            this.grpPrincipal.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.grpPrincipal.Controls.Add(this.cboPromotion);
            this.grpPrincipal.Controls.Add(this.btnAnnuler);
            this.grpPrincipal.Controls.Add(this.btnModifier);
            this.grpPrincipal.Controls.Add(this.btnEnregistrer);
            this.grpPrincipal.Controls.Add(this.txtNom);
            this.grpPrincipal.Controls.Add(this.txtPrenom);
            this.grpPrincipal.Controls.Add(this.lblMdp);
            this.grpPrincipal.Controls.Add(this.txtMdp);
            this.grpPrincipal.Controls.Add(this.txtLogin);
            this.grpPrincipal.Controls.Add(this.lblNom);
            this.grpPrincipal.Controls.Add(this.lblPrenom);
            this.grpPrincipal.Controls.Add(this.lblPromotion);
            this.grpPrincipal.Controls.Add(this.lblLogin);
            this.grpPrincipal.ForeColor = System.Drawing.Color.Black;
            this.grpPrincipal.Location = new System.Drawing.Point(12, 12);
            this.grpPrincipal.Name = "grpPrincipal";
            this.grpPrincipal.Size = new System.Drawing.Size(381, 363);
            this.grpPrincipal.TabIndex = 12;
            this.grpPrincipal.TabStop = false;
            // 
            // cboPromotion
            // 
            this.cboPromotion.DisplayMember = "(Collection)";
            this.cboPromotion.FormattingEnabled = true;
            this.cboPromotion.Location = new System.Drawing.Point(131, 157);
            this.cboPromotion.Name = "cboPromotion";
            this.cboPromotion.Size = new System.Drawing.Size(163, 21);
            this.cboPromotion.TabIndex = 12;
            this.cboPromotion.SelectedIndexChanged += new System.EventHandler(this.cboPromotion_SelectedIndexChanged);
            this.cboPromotion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboPromotion_KeyPress);
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(405, 383);
            this.Controls.Add(this.grpPrincipal);
            this.Name = "frmUtilisateur";
            this.Text = "Saisie Utilisateur";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            this.grpPrincipal.ResumeLayout(false);
            this.grpPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblPromotion;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox grpPrincipal;
        private System.Windows.Forms.ComboBox cboPromotion;
    }
}

