namespace updatecomptoir
{
    partial class frmCommande
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
            this.lblNumCom = new System.Windows.Forms.Label();
            this.lblClientConc = new System.Windows.Forms.Label();
            this.lblEmployeResp = new System.Windows.Forms.Label();
            this.lblDateCommande = new System.Windows.Forms.Label();
            this.lblDestinataire = new System.Windows.Forms.Label();
            this.txtNumCommande = new System.Windows.Forms.TextBox();
            this.txtDestinataire = new System.Windows.Forms.TextBox();
            this.cboClientConc = new System.Windows.Forms.ComboBox();
            this.cboEmployeResp = new System.Windows.Forms.ComboBox();
            this.mClDateCommande = new System.Windows.Forms.MonthCalendar();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumCom
            // 
            this.lblNumCom.AutoSize = true;
            this.lblNumCom.Location = new System.Drawing.Point(12, 40);
            this.lblNumCom.Name = "lblNumCom";
            this.lblNumCom.Size = new System.Drawing.Size(120, 13);
            this.lblNumCom.TabIndex = 0;
            this.lblNumCom.Text = "Numéro de commande :";
            // 
            // lblClientConc
            // 
            this.lblClientConc.AutoSize = true;
            this.lblClientConc.Location = new System.Drawing.Point(12, 70);
            this.lblClientConc.Name = "lblClientConc";
            this.lblClientConc.Size = new System.Drawing.Size(87, 13);
            this.lblClientConc.TabIndex = 1;
            this.lblClientConc.Text = "Client concerné :";
            // 
            // lblEmployeResp
            // 
            this.lblEmployeResp.AutoSize = true;
            this.lblEmployeResp.Location = new System.Drawing.Point(12, 100);
            this.lblEmployeResp.Name = "lblEmployeResp";
            this.lblEmployeResp.Size = new System.Drawing.Size(113, 13);
            this.lblEmployeResp.TabIndex = 2;
            this.lblEmployeResp.Text = "Employé responsable :";
            // 
            // lblDateCommande
            // 
            this.lblDateCommande.AutoSize = true;
            this.lblDateCommande.Location = new System.Drawing.Point(12, 130);
            this.lblDateCommande.Name = "lblDateCommande";
            this.lblDateCommande.Size = new System.Drawing.Size(91, 13);
            this.lblDateCommande.TabIndex = 3;
            this.lblDateCommande.Text = "Date commande :";
            // 
            // lblDestinataire
            // 
            this.lblDestinataire.AutoSize = true;
            this.lblDestinataire.Location = new System.Drawing.Point(12, 309);
            this.lblDestinataire.Name = "lblDestinataire";
            this.lblDestinataire.Size = new System.Drawing.Size(69, 13);
            this.lblDestinataire.TabIndex = 4;
            this.lblDestinataire.Text = "Destinataire :";
            // 
            // txtNumCommande
            // 
            this.txtNumCommande.Enabled = false;
            this.txtNumCommande.Location = new System.Drawing.Point(138, 37);
            this.txtNumCommande.Name = "txtNumCommande";
            this.txtNumCommande.Size = new System.Drawing.Size(227, 20);
            this.txtNumCommande.TabIndex = 5;
            // 
            // txtDestinataire
            // 
            this.txtDestinataire.Location = new System.Drawing.Point(138, 306);
            this.txtDestinataire.Name = "txtDestinataire";
            this.txtDestinataire.Size = new System.Drawing.Size(227, 20);
            this.txtDestinataire.TabIndex = 6;
            // 
            // cboClientConc
            // 
            this.cboClientConc.FormattingEnabled = true;
            this.cboClientConc.Location = new System.Drawing.Point(138, 67);
            this.cboClientConc.Name = "cboClientConc";
            this.cboClientConc.Size = new System.Drawing.Size(227, 21);
            this.cboClientConc.TabIndex = 7;
            // 
            // cboEmployeResp
            // 
            this.cboEmployeResp.FormattingEnabled = true;
            this.cboEmployeResp.Location = new System.Drawing.Point(138, 99);
            this.cboEmployeResp.Name = "cboEmployeResp";
            this.cboEmployeResp.Size = new System.Drawing.Size(227, 21);
            this.cboEmployeResp.TabIndex = 8;
            // 
            // mClDateCommande
            // 
            this.mClDateCommande.Location = new System.Drawing.Point(138, 132);
            this.mClDateCommande.Name = "mClDateCommande";
            this.mClDateCommande.TabIndex = 9;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(290, 332);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 10;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // frmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 370);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.mClDateCommande);
            this.Controls.Add(this.cboEmployeResp);
            this.Controls.Add(this.cboClientConc);
            this.Controls.Add(this.txtDestinataire);
            this.Controls.Add(this.txtNumCommande);
            this.Controls.Add(this.lblDestinataire);
            this.Controls.Add(this.lblDateCommande);
            this.Controls.Add(this.lblEmployeResp);
            this.Controls.Add(this.lblClientConc);
            this.Controls.Add(this.lblNumCom);
            this.Name = "frmCommande";
            this.Text = "Saisie d\'une commande client";
            this.Load += new System.EventHandler(this.frmCommande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumCom;
        private System.Windows.Forms.Label lblClientConc;
        private System.Windows.Forms.Label lblEmployeResp;
        private System.Windows.Forms.Label lblDateCommande;
        private System.Windows.Forms.Label lblDestinataire;
        private System.Windows.Forms.TextBox txtNumCommande;
        private System.Windows.Forms.TextBox txtDestinataire;
        private System.Windows.Forms.ComboBox cboClientConc;
        private System.Windows.Forms.ComboBox cboEmployeResp;
        private System.Windows.Forms.MonthCalendar mClDateCommande;
        private System.Windows.Forms.Button btnValider;
    }
}

