﻿namespace WinFrmAppObjetsGraphiques
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
            this.butAffFrmChackRadioObjets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAffFrmChackRadioObjets
            // 
            this.butAffFrmChackRadioObjets.Location = new System.Drawing.Point(323, 107);
            this.butAffFrmChackRadioObjets.Name = "butAffFrmChackRadioObjets";
            this.butAffFrmChackRadioObjets.Size = new System.Drawing.Size(200, 23);
            this.butAffFrmChackRadioObjets.TabIndex = 0;
            this.butAffFrmChackRadioObjets.Text = "Afficher feuile Check Radio";
            this.butAffFrmChackRadioObjets.UseVisualStyleBackColor = true;
            this.butAffFrmChackRadioObjets.Click += new System.EventHandler(this.butAffFrmChackRadioObjets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butAffFrmChackRadioObjets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAffFrmChackRadioObjets;
    }
}

