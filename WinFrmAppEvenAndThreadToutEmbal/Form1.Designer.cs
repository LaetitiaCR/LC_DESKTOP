namespace WinFrmAppEvenAndThreadToutEmbal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageA = new System.Windows.Forms.TabPage();
            this.lblTxDefDem = new System.Windows.Forms.Label();
            this.lblTxDefHeure = new System.Windows.Forms.Label();
            this.txtBoxTxDefDem = new System.Windows.Forms.TextBox();
            this.txtBoxTxDefHeure = new System.Windows.Forms.TextBox();
            this.txtBoxNbCaissesDem = new System.Windows.Forms.TextBox();
            this.lblNbCaissesDem = new System.Windows.Forms.Label();
            this.tabPageB = new System.Windows.Forms.TabPage();
            this.tabPageC = new System.Windows.Forms.TabPage();
            this.lblProdA = new System.Windows.Forms.Label();
            this.lblProdB = new System.Windows.Forms.Label();
            this.lblProdC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxQuitter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemProd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDemarrer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDemA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDemB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemArreter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemArretA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemArretB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemArretC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemContinuer = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPageA.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageA);
            this.tabControl1.Controls.Add(this.tabPageB);
            this.tabControl1.Controls.Add(this.tabPageC);
            this.tabControl1.Location = new System.Drawing.Point(260, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 242);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageA
            // 
            this.tabPageA.Controls.Add(this.lblTxDefDem);
            this.tabPageA.Controls.Add(this.lblTxDefHeure);
            this.tabPageA.Controls.Add(this.txtBoxTxDefDem);
            this.tabPageA.Controls.Add(this.txtBoxTxDefHeure);
            this.tabPageA.Controls.Add(this.txtBoxNbCaissesDem);
            this.tabPageA.Controls.Add(this.lblNbCaissesDem);
            this.tabPageA.Location = new System.Drawing.Point(4, 22);
            this.tabPageA.Name = "tabPageA";
            this.tabPageA.Size = new System.Drawing.Size(479, 216);
            this.tabPageA.TabIndex = 0;
            this.tabPageA.Text = "TypeA";
            this.tabPageA.UseVisualStyleBackColor = true;
            // 
            // lblTxDefDem
            // 
            this.lblTxDefDem.AutoSize = true;
            this.lblTxDefDem.Location = new System.Drawing.Point(54, 171);
            this.lblTxDefDem.Name = "lblTxDefDem";
            this.lblTxDefDem.Size = new System.Drawing.Size(151, 13);
            this.lblTxDefDem.TabIndex = 5;
            this.lblTxDefDem.Text = "Taux défaut depuis démarrage";
            // 
            // lblTxDefHeure
            // 
            this.lblTxDefHeure.AutoSize = true;
            this.lblTxDefHeure.Location = new System.Drawing.Point(54, 116);
            this.lblTxDefHeure.Name = "lblTxDefHeure";
            this.lblTxDefHeure.Size = new System.Drawing.Size(94, 13);
            this.lblTxDefHeure.TabIndex = 4;
            this.lblTxDefHeure.Text = "Taux défaut heure";
            // 
            // txtBoxTxDefDem
            // 
            this.txtBoxTxDefDem.Location = new System.Drawing.Point(292, 168);
            this.txtBoxTxDefDem.Name = "txtBoxTxDefDem";
            this.txtBoxTxDefDem.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTxDefDem.TabIndex = 3;
            this.txtBoxTxDefDem.Text = "0,5780";
            // 
            // txtBoxTxDefHeure
            // 
            this.txtBoxTxDefHeure.Location = new System.Drawing.Point(292, 109);
            this.txtBoxTxDefHeure.Name = "txtBoxTxDefHeure";
            this.txtBoxTxDefHeure.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTxDefHeure.TabIndex = 2;
            this.txtBoxTxDefHeure.Text = "0,9960";
            // 
            // txtBoxNbCaissesDem
            // 
            this.txtBoxNbCaissesDem.Location = new System.Drawing.Point(292, 57);
            this.txtBoxNbCaissesDem.Name = "txtBoxNbCaissesDem";
            this.txtBoxNbCaissesDem.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNbCaissesDem.TabIndex = 1;
            this.txtBoxNbCaissesDem.Text = "3000";
            // 
            // lblNbCaissesDem
            // 
            this.lblNbCaissesDem.AutoSize = true;
            this.lblNbCaissesDem.Location = new System.Drawing.Point(54, 64);
            this.lblNbCaissesDem.Name = "lblNbCaissesDem";
            this.lblNbCaissesDem.Size = new System.Drawing.Size(195, 13);
            this.lblNbCaissesDem.TabIndex = 0;
            this.lblNbCaissesDem.Text = "Nombre de caisses depuis le démarrage";
            // 
            // tabPageB
            // 
            this.tabPageB.Location = new System.Drawing.Point(4, 22);
            this.tabPageB.Name = "tabPageB";
            this.tabPageB.Size = new System.Drawing.Size(479, 216);
            this.tabPageB.TabIndex = 0;
            this.tabPageB.Text = "TypeB";
            this.tabPageB.UseVisualStyleBackColor = true;
            // 
            // tabPageC
            // 
            this.tabPageC.Location = new System.Drawing.Point(4, 22);
            this.tabPageC.Name = "tabPageC";
            this.tabPageC.Size = new System.Drawing.Size(479, 216);
            this.tabPageC.TabIndex = 0;
            this.tabPageC.Text = "TypeC";
            this.tabPageC.UseVisualStyleBackColor = true;
            // 
            // lblProdA
            // 
            this.lblProdA.AutoSize = true;
            this.lblProdA.Location = new System.Drawing.Point(44, 340);
            this.lblProdA.Name = "lblProdA";
            this.lblProdA.Size = new System.Drawing.Size(68, 13);
            this.lblProdA.TabIndex = 1;
            this.lblProdA.Text = "Production A";
            // 
            // lblProdB
            // 
            this.lblProdB.AutoSize = true;
            this.lblProdB.Location = new System.Drawing.Point(44, 379);
            this.lblProdB.Name = "lblProdB";
            this.lblProdB.Size = new System.Drawing.Size(68, 13);
            this.lblProdB.TabIndex = 2;
            this.lblProdB.Text = "Production B";
            // 
            // lblProdC
            // 
            this.lblProdC.AutoSize = true;
            this.lblProdC.Location = new System.Drawing.Point(44, 424);
            this.lblProdC.Name = "lblProdC";
            this.lblProdC.Size = new System.Drawing.Size(68, 13);
            this.lblProdC.TabIndex = 3;
            this.lblProdC.Text = "Production C";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(260, 376);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(479, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(260, 424);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(479, 20);
            this.textBox3.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFichier,
            this.toolStripMenuItemProd});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItemFichier
            // 
            this.toolStripMenuItemFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxQuitter});
            this.toolStripMenuItemFichier.Name = "toolStripMenuItemFichier";
            this.toolStripMenuItemFichier.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemFichier.Text = "Fichier";
            // 
            // toolStripTextBoxQuitter
            // 
            this.toolStripTextBoxQuitter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxQuitter.Name = "toolStripTextBoxQuitter";
            this.toolStripTextBoxQuitter.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxQuitter.Text = "Quitter";
            // 
            // toolStripMenuItemProd
            // 
            this.toolStripMenuItemProd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDemarrer,
            this.toolStripMenuItemArreter,
            this.toolStripMenuItemContinuer});
            this.toolStripMenuItemProd.Name = "toolStripMenuItemProd";
            this.toolStripMenuItemProd.Size = new System.Drawing.Size(78, 20);
            this.toolStripMenuItemProd.Text = "Production";
            // 
            // toolStripMenuItemDemarrer
            // 
            this.toolStripMenuItemDemarrer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDemA,
            this.toolStripMenuItemDemB,
            this.toolStripMenuItemC});
            this.toolStripMenuItemDemarrer.Name = "toolStripMenuItemDemarrer";
            this.toolStripMenuItemDemarrer.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemDemarrer.Text = "Demarrer";
            // 
            // toolStripMenuItemDemA
            // 
            this.toolStripMenuItemDemA.Name = "toolStripMenuItemDemA";
            this.toolStripMenuItemDemA.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemDemA.Text = "A";
            this.toolStripMenuItemDemA.Click += new System.EventHandler(this.toolStripMenuItemDemA_Click);
            // 
            // toolStripMenuItemDemB
            // 
            this.toolStripMenuItemDemB.Name = "toolStripMenuItemDemB";
            this.toolStripMenuItemDemB.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemDemB.Text = "B";
            // 
            // toolStripMenuItemC
            // 
            this.toolStripMenuItemC.Name = "toolStripMenuItemC";
            this.toolStripMenuItemC.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemC.Text = "C";
            // 
            // toolStripMenuItemArreter
            // 
            this.toolStripMenuItemArreter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemArretA,
            this.toolStripMenuItemArretB,
            this.toolStripMenuItemArretC});
            this.toolStripMenuItemArreter.Name = "toolStripMenuItemArreter";
            this.toolStripMenuItemArreter.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemArreter.Text = "Arrêter";
            // 
            // toolStripMenuItemArretA
            // 
            this.toolStripMenuItemArretA.Name = "toolStripMenuItemArretA";
            this.toolStripMenuItemArretA.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemArretA.Text = "A";
            // 
            // toolStripMenuItemArretB
            // 
            this.toolStripMenuItemArretB.Name = "toolStripMenuItemArretB";
            this.toolStripMenuItemArretB.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemArretB.Text = "B";
            // 
            // toolStripMenuItemArretC
            // 
            this.toolStripMenuItemArretC.Name = "toolStripMenuItemArretC";
            this.toolStripMenuItemArretC.Size = new System.Drawing.Size(82, 22);
            this.toolStripMenuItemArretC.Text = "C";
            // 
            // toolStripMenuItemContinuer
            // 
            this.toolStripMenuItemContinuer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem2,
            this.bToolStripMenuItem2,
            this.cToolStripMenuItem2});
            this.toolStripMenuItemContinuer.Name = "toolStripMenuItemContinuer";
            this.toolStripMenuItemContinuer.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemContinuer.Text = "Continuer";
            // 
            // aToolStripMenuItem2
            // 
            this.aToolStripMenuItem2.Name = "aToolStripMenuItem2";
            this.aToolStripMenuItem2.Size = new System.Drawing.Size(82, 22);
            this.aToolStripMenuItem2.Text = "A";
            // 
            // bToolStripMenuItem2
            // 
            this.bToolStripMenuItem2.Name = "bToolStripMenuItem2";
            this.bToolStripMenuItem2.Size = new System.Drawing.Size(82, 22);
            this.bToolStripMenuItem2.Text = "B";
            // 
            // cToolStripMenuItem2
            // 
            this.cToolStripMenuItem2.Name = "cToolStripMenuItem2";
            this.cToolStripMenuItem2.Size = new System.Drawing.Size(82, 22);
            this.cToolStripMenuItem2.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblProdC);
            this.Controls.Add(this.lblProdB);
            this.Controls.Add(this.lblProdA);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageA.ResumeLayout(false);
            this.tabPageA.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageA;
        private System.Windows.Forms.TabPage tabPageB;
        private System.Windows.Forms.TabPage tabPageC;
        private System.Windows.Forms.Label lblTxDefDem;
        private System.Windows.Forms.Label lblTxDefHeure;
        private System.Windows.Forms.TextBox txtBoxTxDefDem;
        private System.Windows.Forms.TextBox txtBoxTxDefHeure;
        private System.Windows.Forms.TextBox txtBoxNbCaissesDem;
        private System.Windows.Forms.Label lblNbCaissesDem;
        private System.Windows.Forms.Label lblProdA;
        private System.Windows.Forms.Label lblProdB;
        private System.Windows.Forms.Label lblProdC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFichier;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxQuitter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDemarrer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDemA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDemB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemC;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemArreter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemArretA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemArretB;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemArretC;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemContinuer;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem2;
    }
}

