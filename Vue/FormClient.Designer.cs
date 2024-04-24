namespace Banque
{
    partial class FormClient
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
            this.tbNum = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNum
            // 
            this.tbNum.Enabled = false;
            this.tbNum.Location = new System.Drawing.Point(72, 26);
            this.tbNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNum.Name = "tbNum";
            this.tbNum.ReadOnly = true;
            this.tbNum.Size = new System.Drawing.Size(76, 20);
            this.tbNum.TabIndex = 0;
            // 
            // tbNom
            // 
            this.tbNom.Enabled = false;
            this.tbNom.Location = new System.Drawing.Point(72, 73);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNom.Name = "tbNom";
            this.tbNom.ReadOnly = true;
            this.tbNom.Size = new System.Drawing.Size(76, 20);
            this.tbNom.TabIndex = 1;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Enabled = false;
            this.tbPrenom.Location = new System.Drawing.Point(72, 135);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.ReadOnly = true;
            this.tbPrenom.Size = new System.Drawing.Size(76, 20);
            this.tbPrenom.TabIndex = 2;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(72, 184);
            this.tbAdresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(76, 20);
            this.tbAdresse.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbNum);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}