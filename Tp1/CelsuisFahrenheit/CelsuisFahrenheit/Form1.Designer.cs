namespace CelsuisFahrenheit
{
    partial class frmCelsiusFahrenheit
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
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSensConversion = new System.Windows.Forms.GroupBox();
            this.radFahrenheitCelsius = new System.Windows.Forms.RadioButton();
            this.radCelsiusFahrenheit = new System.Windows.Forms.RadioButton();
            this.btnRAZ = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grpSensConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(198, 63);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(116, 20);
            this.txtCelsius.TabIndex = 0;
            this.txtCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelsius_KeyPress);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(198, 98);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(116, 20);
            this.txtFahrenheit.TabIndex = 1;
            this.txtFahrenheit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFahrenheit_KeyPress);
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(52, 66);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(123, 13);
            this.lblCelsius.TabIndex = 2;
            this.lblCelsius.Text = "Valeur en degrés Celsius";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valeur en degrés Fahrenheit";
            // 
            // grpSensConversion
            // 
            this.grpSensConversion.Controls.Add(this.radFahrenheitCelsius);
            this.grpSensConversion.Controls.Add(this.radCelsiusFahrenheit);
            this.grpSensConversion.Location = new System.Drawing.Point(12, 137);
            this.grpSensConversion.Name = "grpSensConversion";
            this.grpSensConversion.Size = new System.Drawing.Size(596, 123);
            this.grpSensConversion.TabIndex = 4;
            this.grpSensConversion.TabStop = false;
            this.grpSensConversion.Text = "Sens de Conversion";
            // 
            // radFahrenheitCelsius
            // 
            this.radFahrenheitCelsius.AutoSize = true;
            this.radFahrenheitCelsius.Location = new System.Drawing.Point(43, 68);
            this.radFahrenheitCelsius.Name = "radFahrenheitCelsius";
            this.radFahrenheitCelsius.Size = new System.Drawing.Size(190, 17);
            this.radFahrenheitCelsius.TabIndex = 1;
            this.radFahrenheitCelsius.TabStop = true;
            this.radFahrenheitCelsius.Text = "Conversion Fahrenheit vers Celsius";
            this.radFahrenheitCelsius.UseVisualStyleBackColor = true;
            this.radFahrenheitCelsius.CheckedChanged += new System.EventHandler(this.radFahrenheitCelsius_CheckedChanged);
            // 
            // radCelsiusFahrenheit
            // 
            this.radCelsiusFahrenheit.AutoSize = true;
            this.radCelsiusFahrenheit.Location = new System.Drawing.Point(43, 45);
            this.radCelsiusFahrenheit.Name = "radCelsiusFahrenheit";
            this.radCelsiusFahrenheit.Size = new System.Drawing.Size(190, 17);
            this.radCelsiusFahrenheit.TabIndex = 0;
            this.radCelsiusFahrenheit.TabStop = true;
            this.radCelsiusFahrenheit.Text = "Conversion Celsius vers Fahrenheit";
            this.radCelsiusFahrenheit.UseVisualStyleBackColor = true;
            this.radCelsiusFahrenheit.CheckedChanged += new System.EventHandler(this.radCelsiusFahrenheit_CheckedChanged);
            // 
            // btnRAZ
            // 
            this.btnRAZ.Location = new System.Drawing.Point(452, 270);
            this.btnRAZ.Name = "btnRAZ";
            this.btnRAZ.Size = new System.Drawing.Size(75, 23);
            this.btnRAZ.TabIndex = 5;
            this.btnRAZ.Text = "RAZ";
            this.btnRAZ.UseVisualStyleBackColor = true;
            this.btnRAZ.Click += new System.EventHandler(this.btnRAZ_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(533, 270);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmCelsiusFahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 302);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRAZ);
            this.Controls.Add(this.grpSensConversion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Name = "frmCelsiusFahrenheit";
            this.Text = "Conversion Celsius Fahrenheit";
            this.grpSensConversion.ResumeLayout(false);
            this.grpSensConversion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSensConversion;
        private System.Windows.Forms.RadioButton radFahrenheitCelsius;
        private System.Windows.Forms.RadioButton radCelsiusFahrenheit;
        private System.Windows.Forms.Button btnRAZ;
        private System.Windows.Forms.Button btnQuitter;
    }
}

