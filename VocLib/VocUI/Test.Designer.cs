namespace VocUI
{
    partial class Test
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
            this.ButtonVerifierTrad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMotATrad = new System.Windows.Forms.TextBox();
            this.textBoxTradEssai = new System.Windows.Forms.TextBox();
            this.textBoxCorrection = new System.Windows.Forms.TextBox();
            this.labelFaux = new System.Windows.Forms.Label();
            this.buttonNextWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonVerifierTrad
            // 
            this.ButtonVerifierTrad.Location = new System.Drawing.Point(304, 174);
            this.ButtonVerifierTrad.Name = "ButtonVerifierTrad";
            this.ButtonVerifierTrad.Size = new System.Drawing.Size(328, 68);
            this.ButtonVerifierTrad.TabIndex = 0;
            this.ButtonVerifierTrad.Text = "Vérifier ";
            this.ButtonVerifierTrad.UseVisualStyleBackColor = true;
            this.ButtonVerifierTrad.Click += new System.EventHandler(this.ButtonVerifierTrad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mot à traduire : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Traduction proposée :";
            // 
            // textBoxMotATrad
            // 
            this.textBoxMotATrad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxMotATrad.Location = new System.Drawing.Point(304, 45);
            this.textBoxMotATrad.Name = "textBoxMotATrad";
            this.textBoxMotATrad.ReadOnly = true;
            this.textBoxMotATrad.Size = new System.Drawing.Size(328, 35);
            this.textBoxMotATrad.TabIndex = 3;
            // 
            // textBoxTradEssai
            // 
            this.textBoxTradEssai.Location = new System.Drawing.Point(304, 110);
            this.textBoxTradEssai.Name = "textBoxTradEssai";
            this.textBoxTradEssai.Size = new System.Drawing.Size(328, 35);
            this.textBoxTradEssai.TabIndex = 4;
            // 
            // textBoxCorrection
            // 
            this.textBoxCorrection.Location = new System.Drawing.Point(304, 270);
            this.textBoxCorrection.Name = "textBoxCorrection";
            this.textBoxCorrection.ReadOnly = true;
            this.textBoxCorrection.Size = new System.Drawing.Size(328, 35);
            this.textBoxCorrection.TabIndex = 5;
            this.textBoxCorrection.Visible = false;
            // 
            // labelFaux
            // 
            this.labelFaux.AutoSize = true;
            this.labelFaux.Location = new System.Drawing.Point(70, 273);
            this.labelFaux.Name = "labelFaux";
            this.labelFaux.Size = new System.Drawing.Size(163, 30);
            this.labelFaux.TabIndex = 6;
            this.labelFaux.Text = "Bonne réponse :";
            this.labelFaux.Visible = false;
            // 
            // buttonNextWord
            // 
            this.buttonNextWord.Location = new System.Drawing.Point(304, 330);
            this.buttonNextWord.Name = "buttonNextWord";
            this.buttonNextWord.Size = new System.Drawing.Size(328, 68);
            this.buttonNextWord.TabIndex = 7;
            this.buttonNextWord.Text = "Passer au mot suivant ";
            this.buttonNextWord.UseVisualStyleBackColor = true;
            this.buttonNextWord.Visible = false;
            this.buttonNextWord.Click += new System.EventHandler(this.buttonNextWord_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 504);
            this.Controls.Add(this.buttonNextWord);
            this.Controls.Add(this.labelFaux);
            this.Controls.Add(this.textBoxCorrection);
            this.Controls.Add(this.textBoxTradEssai);
            this.Controls.Add(this.textBoxMotATrad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonVerifierTrad);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonVerifierTrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMotATrad;
        private System.Windows.Forms.TextBox textBoxTradEssai;
        private System.Windows.Forms.TextBox textBoxCorrection;
        private System.Windows.Forms.Label labelFaux;
        private System.Windows.Forms.Button buttonNextWord;
    }
}