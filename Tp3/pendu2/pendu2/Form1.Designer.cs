namespace pendu2
{
    partial class frmPendu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPendu));
            this.lblMot = new System.Windows.Forms.Label();
            this.lblProposition = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpMot = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pcbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMot
            // 
            this.lblMot.AutoSize = true;
            this.lblMot.Location = new System.Drawing.Point(12, 9);
            this.lblMot.Name = "lblMot";
            this.lblMot.Size = new System.Drawing.Size(90, 13);
            this.lblMot.TabIndex = 0;
            this.lblMot.Text = "Le mot à trouver :";
            // 
            // lblProposition
            // 
            this.lblProposition.AutoSize = true;
            this.lblProposition.Location = new System.Drawing.Point(590, 9);
            this.lblProposition.Name = "lblProposition";
            this.lblProposition.Size = new System.Drawing.Size(92, 13);
            this.lblProposition.TabIndex = 1;
            this.lblProposition.Text = "Votre proposition :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // grpMot
            // 
            this.grpMot.Location = new System.Drawing.Point(12, 32);
            this.grpMot.Name = "grpMot";
            this.grpMot.Size = new System.Drawing.Size(776, 100);
            this.grpMot.TabIndex = 3;
            this.grpMot.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            this.imageList1.Images.SetKeyName(5, "6.png");
            this.imageList1.Images.SetKeyName(6, "7.png");
            this.imageList1.Images.SetKeyName(7, "8.png");
            this.imageList1.Images.SetKeyName(8, "9.jpg");
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(327, 151);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(150, 150);
            this.pcbImage.TabIndex = 4;
            this.pcbImage.TabStop = false;
            // 
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.grpMot);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProposition);
            this.Controls.Add(this.lblMot);
            this.Name = "frmPendu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pendu";
            this.Load += new System.EventHandler(this.frmPendu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMot;
        private System.Windows.Forms.Label lblProposition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpMot;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pcbImage;
    }
}

