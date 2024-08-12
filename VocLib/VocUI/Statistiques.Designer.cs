namespace VocUI
{
    partial class Statistiques
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEssais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMoy = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Série :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voir les statistiques";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickVoirStat);
            // 
            // textBoxEssais
            // 
            this.textBoxEssais.Location = new System.Drawing.Point(667, 92);
            this.textBoxEssais.Name = "textBoxEssais";
            this.textBoxEssais.ReadOnly = true;
            this.textBoxEssais.Size = new System.Drawing.Size(180, 35);
            this.textBoxEssais.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre d\'essais :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pourcentage de mots réussis";
            // 
            // textBoxMoy
            // 
            this.textBoxMoy.Location = new System.Drawing.Point(667, 144);
            this.textBoxMoy.MaxLength = 5;
            this.textBoxMoy.Name = "textBoxMoy";
            this.textBoxMoy.ReadOnly = true;
            this.textBoxMoy.Size = new System.Drawing.Size(180, 35);
            this.textBoxMoy.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(107, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 244);
            this.listBox1.TabIndex = 7;
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 418);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMoy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEssais);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Statistiques";
            this.Text = "Statistiques";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxEssais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMoy;
        private System.Windows.Forms.ListBox listBox1;
    }
}