namespace WinFrmAppObjetsGraphiques
{
    partial class CheckRadioObjets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxEntrerTexte = new System.Windows.Forms.TextBox();
            this.grpBoxFond = new System.Windows.Forms.GroupBox();
            this.radButRouge1 = new System.Windows.Forms.RadioButton();
            this.radButVert = new System.Windows.Forms.RadioButton();
            this.radButBleu = new System.Windows.Forms.RadioButton();
            this.grpBoxCara = new System.Windows.Forms.GroupBox();
            this.radButRouge2 = new System.Windows.Forms.RadioButton();
            this.radButNoir = new System.Windows.Forms.RadioButton();
            this.radButBlanc = new System.Windows.Forms.RadioButton();
            this.grpBoxCasse = new System.Windows.Forms.GroupBox();
            this.radButMin = new System.Windows.Forms.RadioButton();
            this.radButMaj = new System.Windows.Forms.RadioButton();
            this.grpBoxChoix = new System.Windows.Forms.GroupBox();
            this.checkBoxCoulFond = new System.Windows.Forms.CheckBox();
            this.checkBoxCoulCara = new System.Windows.Forms.CheckBox();
            this.checkBoxCasse = new System.Windows.Forms.CheckBox();
            this.lblTexteAff = new System.Windows.Forms.Label();
            this.grpBoxFond.SuspendLayout();
            this.grpBoxCara.SuspendLayout();
            this.grpBoxCasse.SuspendLayout();
            this.grpBoxChoix.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taper votre texte";
            // 
            // txtBoxEntrerTexte
            // 
            this.txtBoxEntrerTexte.Location = new System.Drawing.Point(188, 73);
            this.txtBoxEntrerTexte.MaxLength = 500;
            this.txtBoxEntrerTexte.Name = "txtBoxEntrerTexte";
            this.txtBoxEntrerTexte.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEntrerTexte.TabIndex = 1;
            // 
            // grpBoxFond
            // 
            this.grpBoxFond.Controls.Add(this.radButBleu);
            this.grpBoxFond.Controls.Add(this.radButVert);
            this.grpBoxFond.Controls.Add(this.radButRouge1);
            this.grpBoxFond.Location = new System.Drawing.Point(93, 205);
            this.grpBoxFond.Name = "grpBoxFond";
            this.grpBoxFond.Size = new System.Drawing.Size(174, 100);
            this.grpBoxFond.TabIndex = 2;
            this.grpBoxFond.TabStop = false;
            this.grpBoxFond.Text = "Fond";
            this.grpBoxFond.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radButRouge1
            // 
            this.radButRouge1.AutoSize = true;
            this.radButRouge1.Location = new System.Drawing.Point(6, 26);
            this.radButRouge1.Name = "radButRouge1";
            this.radButRouge1.Size = new System.Drawing.Size(57, 17);
            this.radButRouge1.TabIndex = 0;
            this.radButRouge1.TabStop = true;
            this.radButRouge1.Text = "Rouge";
            this.radButRouge1.UseVisualStyleBackColor = true;
            this.radButRouge1.CheckedChanged += new System.EventHandler(this.radButRouge1_CheckedChanged);
            // 
            // radButVert
            // 
            this.radButVert.AutoSize = true;
            this.radButVert.Location = new System.Drawing.Point(6, 49);
            this.radButVert.Name = "radButVert";
            this.radButVert.Size = new System.Drawing.Size(44, 17);
            this.radButVert.TabIndex = 1;
            this.radButVert.TabStop = true;
            this.radButVert.Text = "Vert";
            this.radButVert.UseVisualStyleBackColor = true;
            this.radButVert.CheckedChanged += new System.EventHandler(this.radButVert_CheckedChanged);
            // 
            // radButBleu
            // 
            this.radButBleu.AutoSize = true;
            this.radButBleu.Location = new System.Drawing.Point(6, 74);
            this.radButBleu.Name = "radButBleu";
            this.radButBleu.Size = new System.Drawing.Size(46, 17);
            this.radButBleu.TabIndex = 2;
            this.radButBleu.TabStop = true;
            this.radButBleu.Text = "Bleu";
            this.radButBleu.UseVisualStyleBackColor = true;
            this.radButBleu.CheckedChanged += new System.EventHandler(this.radButBleu_CheckedChanged);
            // 
            // grpBoxCara
            // 
            this.grpBoxCara.Controls.Add(this.radButRouge2);
            this.grpBoxCara.Controls.Add(this.radButNoir);
            this.grpBoxCara.Controls.Add(this.radButBlanc);
            this.grpBoxCara.Location = new System.Drawing.Point(313, 205);
            this.grpBoxCara.Name = "grpBoxCara";
            this.grpBoxCara.Size = new System.Drawing.Size(174, 100);
            this.grpBoxCara.TabIndex = 3;
            this.grpBoxCara.TabStop = false;
            this.grpBoxCara.Text = "Caractères";
            // 
            // radButRouge2
            // 
            this.radButRouge2.AutoSize = true;
            this.radButRouge2.Location = new System.Drawing.Point(6, 26);
            this.radButRouge2.Name = "radButRouge2";
            this.radButRouge2.Size = new System.Drawing.Size(57, 17);
            this.radButRouge2.TabIndex = 2;
            this.radButRouge2.TabStop = true;
            this.radButRouge2.Text = "Rouge";
            this.radButRouge2.UseVisualStyleBackColor = true;
            this.radButRouge2.CheckedChanged += new System.EventHandler(this.radButRouge2_CheckedChanged);
            // 
            // radButNoir
            // 
            this.radButNoir.AutoSize = true;
            this.radButNoir.Location = new System.Drawing.Point(6, 72);
            this.radButNoir.Name = "radButNoir";
            this.radButNoir.Size = new System.Drawing.Size(44, 17);
            this.radButNoir.TabIndex = 1;
            this.radButNoir.TabStop = true;
            this.radButNoir.Text = "Noir";
            this.radButNoir.UseVisualStyleBackColor = true;
            this.radButNoir.CheckedChanged += new System.EventHandler(this.radButNoir_CheckedChanged);
            // 
            // radButBlanc
            // 
            this.radButBlanc.AutoSize = true;
            this.radButBlanc.Location = new System.Drawing.Point(6, 49);
            this.radButBlanc.Name = "radButBlanc";
            this.radButBlanc.Size = new System.Drawing.Size(52, 17);
            this.radButBlanc.TabIndex = 0;
            this.radButBlanc.TabStop = true;
            this.radButBlanc.Text = "Blanc";
            this.radButBlanc.UseVisualStyleBackColor = true;
            this.radButBlanc.CheckedChanged += new System.EventHandler(this.radButBlanc_CheckedChanged);
            // 
            // grpBoxCasse
            // 
            this.grpBoxCasse.Controls.Add(this.radButMin);
            this.grpBoxCasse.Controls.Add(this.radButMaj);
            this.grpBoxCasse.Location = new System.Drawing.Point(530, 205);
            this.grpBoxCasse.Name = "grpBoxCasse";
            this.grpBoxCasse.Size = new System.Drawing.Size(174, 100);
            this.grpBoxCasse.TabIndex = 4;
            this.grpBoxCasse.TabStop = false;
            this.grpBoxCasse.Text = "Casse";
            // 
            // radButMin
            // 
            this.radButMin.AutoSize = true;
            this.radButMin.Location = new System.Drawing.Point(6, 49);
            this.radButMin.Name = "radButMin";
            this.radButMin.Size = new System.Drawing.Size(78, 17);
            this.radButMin.TabIndex = 1;
            this.radButMin.TabStop = true;
            this.radButMin.Text = "Minuscules";
            this.radButMin.UseVisualStyleBackColor = true;
            this.radButMin.CheckedChanged += new System.EventHandler(this.radButMin_CheckedChanged);
            // 
            // radButMaj
            // 
            this.radButMaj.AutoSize = true;
            this.radButMaj.Location = new System.Drawing.Point(6, 26);
            this.radButMaj.Name = "radButMaj";
            this.radButMaj.Size = new System.Drawing.Size(78, 17);
            this.radButMaj.TabIndex = 0;
            this.radButMaj.TabStop = true;
            this.radButMaj.Text = "Majuscules";
            this.radButMaj.UseVisualStyleBackColor = true;
            this.radButMaj.CheckedChanged += new System.EventHandler(this.radButMaj_CheckedChanged);
            // 
            // grpBoxChoix
            // 
            this.grpBoxChoix.Controls.Add(this.checkBoxCasse);
            this.grpBoxChoix.Controls.Add(this.checkBoxCoulCara);
            this.grpBoxChoix.Controls.Add(this.checkBoxCoulFond);
            this.grpBoxChoix.Location = new System.Drawing.Point(435, 34);
            this.grpBoxChoix.Name = "grpBoxChoix";
            this.grpBoxChoix.Size = new System.Drawing.Size(200, 100);
            this.grpBoxChoix.TabIndex = 5;
            this.grpBoxChoix.TabStop = false;
            this.grpBoxChoix.Text = "Choix";
            // 
            // checkBoxCoulFond
            // 
            this.checkBoxCoulFond.AutoSize = true;
            this.checkBoxCoulFond.Location = new System.Drawing.Point(21, 20);
            this.checkBoxCoulFond.Name = "checkBoxCoulFond";
            this.checkBoxCoulFond.Size = new System.Drawing.Size(101, 17);
            this.checkBoxCoulFond.TabIndex = 0;
            this.checkBoxCoulFond.Text = "Couleur du fond";
            this.checkBoxCoulFond.UseVisualStyleBackColor = true;
            // 
            // checkBoxCoulCara
            // 
            this.checkBoxCoulCara.AutoSize = true;
            this.checkBoxCoulCara.Location = new System.Drawing.Point(21, 44);
            this.checkBoxCoulCara.Name = "checkBoxCoulCara";
            this.checkBoxCoulCara.Size = new System.Drawing.Size(135, 17);
            this.checkBoxCoulCara.TabIndex = 1;
            this.checkBoxCoulCara.Text = "Couleur des caractères";
            this.checkBoxCoulCara.UseVisualStyleBackColor = true;
            // 
            // checkBoxCasse
            // 
            this.checkBoxCasse.AutoSize = true;
            this.checkBoxCasse.Location = new System.Drawing.Point(21, 68);
            this.checkBoxCasse.Name = "checkBoxCasse";
            this.checkBoxCasse.Size = new System.Drawing.Size(55, 17);
            this.checkBoxCasse.TabIndex = 2;
            this.checkBoxCasse.Text = "Casse";
            this.checkBoxCasse.UseVisualStyleBackColor = true;
            // 
            // lblTexteAff
            // 
            this.lblTexteAff.AutoSize = true;
            this.lblTexteAff.Location = new System.Drawing.Point(114, 146);
            this.lblTexteAff.MaximumSize = new System.Drawing.Size(20, 0);
            this.lblTexteAff.MinimumSize = new System.Drawing.Size(500, 0);
            this.lblTexteAff.Name = "lblTexteAff";
            this.lblTexteAff.Size = new System.Drawing.Size(500, 13);
            this.lblTexteAff.TabIndex = 6;
            // 
            // CheckRadioObjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 370);
            this.Controls.Add(this.lblTexteAff);
            this.Controls.Add(this.grpBoxChoix);
            this.Controls.Add(this.grpBoxCasse);
            this.Controls.Add(this.grpBoxCara);
            this.Controls.Add(this.grpBoxFond);
            this.Controls.Add(this.txtBoxEntrerTexte);
            this.Controls.Add(this.label1);
            this.Name = "CheckRadioObjets";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.CheckRadioObjets_Load);
            this.grpBoxFond.ResumeLayout(false);
            this.grpBoxFond.PerformLayout();
            this.grpBoxCara.ResumeLayout(false);
            this.grpBoxCara.PerformLayout();
            this.grpBoxCasse.ResumeLayout(false);
            this.grpBoxCasse.PerformLayout();
            this.grpBoxChoix.ResumeLayout(false);
            this.grpBoxChoix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxEntrerTexte;
        private System.Windows.Forms.GroupBox grpBoxFond;
        private System.Windows.Forms.RadioButton radButBleu;
        private System.Windows.Forms.RadioButton radButVert;
        private System.Windows.Forms.RadioButton radButRouge1;
        private System.Windows.Forms.GroupBox grpBoxCara;
        private System.Windows.Forms.RadioButton radButRouge2;
        private System.Windows.Forms.RadioButton radButNoir;
        private System.Windows.Forms.RadioButton radButBlanc;
        private System.Windows.Forms.GroupBox grpBoxCasse;
        private System.Windows.Forms.RadioButton radButMin;
        private System.Windows.Forms.RadioButton radButMaj;
        private System.Windows.Forms.GroupBox grpBoxChoix;
        private System.Windows.Forms.CheckBox checkBoxCasse;
        private System.Windows.Forms.CheckBox checkBoxCoulCara;
        private System.Windows.Forms.CheckBox checkBoxCoulFond;
        private System.Windows.Forms.Label lblTexteAff;
    }
}