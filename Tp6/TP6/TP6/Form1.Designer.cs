namespace TP6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trvCate = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvDonnees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).BeginInit();
            this.SuspendLayout();
            // 
            // trvCate
            // 
            this.trvCate.ImageIndex = 0;
            this.trvCate.ImageList = this.imageList1;
            this.trvCate.Location = new System.Drawing.Point(12, 12);
            this.trvCate.Name = "trvCate";
            this.trvCate.SelectedImageIndex = 0;
            this.trvCate.Size = new System.Drawing.Size(285, 426);
            this.trvCate.StateImageList = this.imageList1;
            this.trvCate.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lp_Baseball_l.jpg");
            this.imageList1.Images.SetKeyName(1, "drag_petit.jpg");
            // 
            // dgvDonnees
            // 
            this.dgvDonnees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonnees.Location = new System.Drawing.Point(303, 193);
            this.dgvDonnees.Name = "dgvDonnees";
            this.dgvDonnees.Size = new System.Drawing.Size(532, 245);
            this.dgvDonnees.TabIndex = 1;
            this.dgvDonnees.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.dgvDonnees);
            this.Controls.Add(this.trvCate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonnees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvCate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvDonnees;
    }
}

