namespace Banque
{
    partial class Gestion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crediterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.découvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lab = new System.Windows.Forms.Label();
            this.bouton = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.lBox = new System.Windows.Forms.ListBox();
            this.lBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationToolStripMenuItem,
            this.modificationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crediterToolStripMenuItem,
            this.debiterToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // crediterToolStripMenuItem
            // 
            this.crediterToolStripMenuItem.Name = "crediterToolStripMenuItem";
            this.crediterToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.crediterToolStripMenuItem.Text = "&Crediter";
            this.crediterToolStripMenuItem.Click += new System.EventHandler(this.crediterToolStripMenuItem_Click);
            // 
            // debiterToolStripMenuItem
            // 
            this.debiterToolStripMenuItem.Name = "debiterToolStripMenuItem";
            this.debiterToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.debiterToolStripMenuItem.Text = "&Debiter";
            this.debiterToolStripMenuItem.Click += new System.EventHandler(this.debiterToolStripMenuItem_Click);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.découvertToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.modificationToolStripMenuItem.Text = "&Modification";
            // 
            // découvertToolStripMenuItem
            // 
            this.découvertToolStripMenuItem.Name = "découvertToolStripMenuItem";
            this.découvertToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.découvertToolStripMenuItem.Text = "&Découvert";
            this.découvertToolStripMenuItem.Click += new System.EventHandler(this.découvertToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientToolStripMenuItem.Text = "&Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(13, 220);
            this.lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(46, 13);
            this.lab.TabIndex = 1;
            this.lab.Text = "Montant";
            this.lab.Visible = false;
            // 
            // bouton
            // 
            this.bouton.Location = new System.Drawing.Point(103, 265);
            this.bouton.Margin = new System.Windows.Forms.Padding(2);
            this.bouton.Name = "bouton";
            this.bouton.Size = new System.Drawing.Size(130, 32);
            this.bouton.TabIndex = 2;
            this.bouton.Text = "Valider";
            this.bouton.UseVisualStyleBackColor = true;
            this.bouton.Visible = false;
            this.bouton.Click += new System.EventHandler(this.bouton_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(116, 241);
            this.tb.Margin = new System.Windows.Forms.Padding(2);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(98, 20);
            this.tb.TabIndex = 3;
            this.tb.Visible = false;
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.Location = new System.Drawing.Point(15, 32);
            this.lBox.Margin = new System.Windows.Forms.Padding(2);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(262, 160);
            this.lBox.TabIndex = 4;
            this.lBox.SelectedIndexChanged += new System.EventHandler(this.lBox_SelectedIndexChanged);
            // 
            // lBox1
            // 
            this.lBox1.FormattingEnabled = true;
            this.lBox1.Location = new System.Drawing.Point(282, 32);
            this.lBox1.Name = "lBox1";
            this.lBox1.Size = new System.Drawing.Size(472, 160);
            this.lBox1.TabIndex = 5;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 320);
            this.Controls.Add(this.lBox1);
            this.Controls.Add(this.lBox);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.bouton);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestion";
            this.Text = "Gestion de comptes";
      
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crediterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem découvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button bouton;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.ListBox lBox1;
    }
}

