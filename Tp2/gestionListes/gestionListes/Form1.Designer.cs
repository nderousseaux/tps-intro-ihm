namespace gestionListes
{
    partial class frmGestionListes
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
            this.lstGauche = new System.Windows.Forms.ListBox();
            this.lstDroite = new System.Windows.Forms.ListBox();
            this.btnGD = new System.Windows.Forms.Button();
            this.btnToutGD = new System.Windows.Forms.Button();
            this.btnToutDG = new System.Windows.Forms.Button();
            this.btnDG = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.lblNouveau = new System.Windows.Forms.Label();
            this.txtNouveau = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGauche
            // 
            this.lstGauche.FormattingEnabled = true;
            this.lstGauche.Location = new System.Drawing.Point(12, 12);
            this.lstGauche.Name = "lstGauche";
            this.lstGauche.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstGauche.Size = new System.Drawing.Size(338, 368);
            this.lstGauche.TabIndex = 0;
            // 
            // lstDroite
            // 
            this.lstDroite.FormattingEnabled = true;
            this.lstDroite.Location = new System.Drawing.Point(450, 12);
            this.lstDroite.Name = "lstDroite";
            this.lstDroite.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDroite.Size = new System.Drawing.Size(338, 368);
            this.lstDroite.TabIndex = 1;
            // 
            // btnGD
            // 
            this.btnGD.Location = new System.Drawing.Point(381, 22);
            this.btnGD.Name = "btnGD";
            this.btnGD.Size = new System.Drawing.Size(44, 23);
            this.btnGD.TabIndex = 2;
            this.btnGD.Text = ">";
            this.btnGD.UseVisualStyleBackColor = true;
            this.btnGD.Click += new System.EventHandler(this.btnGD_Click);
            // 
            // btnToutGD
            // 
            this.btnToutGD.Location = new System.Drawing.Point(381, 51);
            this.btnToutGD.Name = "btnToutGD";
            this.btnToutGD.Size = new System.Drawing.Size(44, 23);
            this.btnToutGD.TabIndex = 3;
            this.btnToutGD.Text = ">>";
            this.btnToutGD.UseVisualStyleBackColor = true;
            this.btnToutGD.Click += new System.EventHandler(this.btnToutGD_Click);
            // 
            // btnToutDG
            // 
            this.btnToutDG.Location = new System.Drawing.Point(381, 80);
            this.btnToutDG.Name = "btnToutDG";
            this.btnToutDG.Size = new System.Drawing.Size(44, 23);
            this.btnToutDG.TabIndex = 4;
            this.btnToutDG.Text = "<<";
            this.btnToutDG.UseVisualStyleBackColor = true;
            // 
            // btnDG
            // 
            this.btnDG.Location = new System.Drawing.Point(381, 109);
            this.btnDG.Name = "btnDG";
            this.btnDG.Size = new System.Drawing.Size(44, 23);
            this.btnDG.TabIndex = 5;
            this.btnDG.Text = "<";
            this.btnDG.UseVisualStyleBackColor = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(356, 357);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(88, 23);
            this.btnNouveau.TabIndex = 6;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // lblNouveau
            // 
            this.lblNouveau.AutoSize = true;
            this.lblNouveau.Location = new System.Drawing.Point(306, 410);
            this.lblNouveau.Name = "lblNouveau";
            this.lblNouveau.Size = new System.Drawing.Size(87, 13);
            this.lblNouveau.TabIndex = 7;
            this.lblNouveau.Text = "Nouvelle valeur :";
            this.lblNouveau.Visible = false;
            // 
            // txtNouveau
            // 
            this.txtNouveau.Location = new System.Drawing.Point(399, 407);
            this.txtNouveau.Name = "txtNouveau";
            this.txtNouveau.Size = new System.Drawing.Size(100, 20);
            this.txtNouveau.TabIndex = 8;
            this.txtNouveau.Visible = false;
            this.txtNouveau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNouveau_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmGestionListes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNouveau);
            this.Controls.Add(this.lblNouveau);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnDG);
            this.Controls.Add(this.btnToutDG);
            this.Controls.Add(this.btnToutGD);
            this.Controls.Add(this.btnGD);
            this.Controls.Add(this.lstDroite);
            this.Controls.Add(this.lstGauche);
            this.Name = "frmGestionListes";
            this.Text = "Gestion des zones de liste";
            this.Load += new System.EventHandler(this.frmGestionListes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGauche;
        private System.Windows.Forms.ListBox lstDroite;
        private System.Windows.Forms.Button btnGD;
        private System.Windows.Forms.Button btnToutGD;
        private System.Windows.Forms.Button btnToutDG;
        private System.Windows.Forms.Button btnDG;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Label lblNouveau;
        private System.Windows.Forms.TextBox txtNouveau;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

