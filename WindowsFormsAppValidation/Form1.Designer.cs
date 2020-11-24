namespace WindowsFormsAppValidation
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMont = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtMont = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.butValider = new System.Windows.Forms.Button();
            this.butEff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(110, 86);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(110, 142);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblMont
            // 
            this.lblMont.AutoSize = true;
            this.lblMont.Location = new System.Drawing.Point(110, 204);
            this.lblMont.Name = "lblMont";
            this.lblMont.Size = new System.Drawing.Size(46, 13);
            this.lblMont.TabIndex = 2;
            this.lblMont.Text = "Montant";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(110, 264);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(70, 13);
            this.lblCP.TabIndex = 3;
            this.lblCP.Text = "Code Postale";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(323, 79);
            this.txtNom.MaxLength = 30;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 4;
            this.txtNom.Text = "Dupont";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(323, 135);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 5;
            this.txtDate.Text = "20/04/2008";
            // 
            // txtMont
            // 
            this.txtMont.Location = new System.Drawing.Point(323, 197);
            this.txtMont.Name = "txtMont";
            this.txtMont.Size = new System.Drawing.Size(100, 20);
            this.txtMont.TabIndex = 6;
            this.txtMont.Text = "35,6768";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(323, 261);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 20);
            this.txtCP.TabIndex = 7;
            this.txtCP.Text = "13013";
            // 
            // butValider
            // 
            this.butValider.Location = new System.Drawing.Point(468, 352);
            this.butValider.Name = "butValider";
            this.butValider.Size = new System.Drawing.Size(75, 23);
            this.butValider.TabIndex = 8;
            this.butValider.Text = "Valider";
            this.butValider.UseVisualStyleBackColor = true;
            this.butValider.Click += new System.EventHandler(this.butValider_Click);
            // 
            // butEff
            // 
            this.butEff.Location = new System.Drawing.Point(607, 352);
            this.butEff.Name = "butEff";
            this.butEff.Size = new System.Drawing.Size(75, 23);
            this.butEff.TabIndex = 9;
            this.butEff.Text = "Effacer";
            this.butEff.UseVisualStyleBackColor = true;
            this.butEff.Click += new System.EventHandler(this.butEff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butEff);
            this.Controls.Add(this.butValider);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtMont);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblMont);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNom);
            this.Name = "Form1";
            this.Text = "Les Contrôles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMont;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtMont;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Button butValider;
        private System.Windows.Forms.Button butEff;
    }
}

