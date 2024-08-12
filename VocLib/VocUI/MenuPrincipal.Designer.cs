namespace VocUI
{
    partial class MenuPrincipal
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
            this.ButtonAddMot = new System.Windows.Forms.Button();
            this.ButtonSeTester = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddMot
            // 
            this.ButtonAddMot.Location = new System.Drawing.Point(278, 164);
            this.ButtonAddMot.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonAddMot.Name = "ButtonAddMot";
            this.ButtonAddMot.Size = new System.Drawing.Size(372, 127);
            this.ButtonAddMot.TabIndex = 0;
            this.ButtonAddMot.Text = "Ajouter un mot";
            this.ButtonAddMot.UseVisualStyleBackColor = true;
            this.ButtonAddMot.Click += new System.EventHandler(this.ButtonAddMot_Click);
            // 
            // ButtonSeTester
            // 
            this.ButtonSeTester.Location = new System.Drawing.Point(278, 305);
            this.ButtonSeTester.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonSeTester.Name = "ButtonSeTester";
            this.ButtonSeTester.Size = new System.Drawing.Size(372, 127);
            this.ButtonSeTester.TabIndex = 1;
            this.ButtonSeTester.Text = "Se tester";
            this.ButtonSeTester.UseVisualStyleBackColor = true;
            this.ButtonSeTester.Click += new System.EventHandler(this.ButtonSeTester_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenue dans mon application !";
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(278, 446);
            this.buttonStats.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(372, 127);
            this.buttonStats.TabIndex = 3;
            this.buttonStats.Text = "Statistiques";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.ClicktoStats);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 765);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSeTester);
            this.Controls.Add(this.ButtonAddMot);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddMot;
        private System.Windows.Forms.Button ButtonSeTester;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStats;
    }
}

