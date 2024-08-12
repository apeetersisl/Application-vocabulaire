namespace VocUI
{
    partial class ChoixTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLangDepart = new System.Windows.Forms.ComboBox();
            this.comboBoxLangFin = new System.Windows.Forms.ComboBox();
            this.ListSeries = new System.Windows.Forms.ListBox();
            this.buttonbegintest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Langue a traduire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Langue de traduction";
            // 
            // comboBoxLangDepart
            // 
            this.comboBoxLangDepart.FormattingEnabled = true;
            this.comboBoxLangDepart.Location = new System.Drawing.Point(310, 47);
            this.comboBoxLangDepart.Name = "comboBoxLangDepart";
            this.comboBoxLangDepart.Size = new System.Drawing.Size(277, 38);
            this.comboBoxLangDepart.TabIndex = 2;
            // 
            // comboBoxLangFin
            // 
            this.comboBoxLangFin.FormattingEnabled = true;
            this.comboBoxLangFin.Location = new System.Drawing.Point(310, 101);
            this.comboBoxLangFin.Name = "comboBoxLangFin";
            this.comboBoxLangFin.Size = new System.Drawing.Size(277, 38);
            this.comboBoxLangFin.TabIndex = 3;
            // 
            // ListSeries
            // 
            this.ListSeries.FormattingEnabled = true;
            this.ListSeries.ItemHeight = 30;
            this.ListSeries.Location = new System.Drawing.Point(76, 159);
            this.ListSeries.Name = "ListSeries";
            this.ListSeries.Size = new System.Drawing.Size(511, 244);
            this.ListSeries.TabIndex = 4;
            // 
            // buttonbegintest
            // 
            this.buttonbegintest.Location = new System.Drawing.Point(76, 425);
            this.buttonbegintest.Name = "buttonbegintest";
            this.buttonbegintest.Size = new System.Drawing.Size(511, 57);
            this.buttonbegintest.TabIndex = 5;
            this.buttonbegintest.Text = "Commencer le test !";
            this.buttonbegintest.UseVisualStyleBackColor = true;
            this.buttonbegintest.Click += new System.EventHandler(this.buttonbegintest_Click);
            // 
            // ChoixTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 580);
            this.Controls.Add(this.buttonbegintest);
            this.Controls.Add(this.ListSeries);
            this.Controls.Add(this.comboBoxLangFin);
            this.Controls.Add(this.comboBoxLangDepart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ChoixTest";
            this.Text = "Choix de la série";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLangDepart;
        private System.Windows.Forms.ComboBox comboBoxLangFin;
        private System.Windows.Forms.ListBox ListSeries;
        private System.Windows.Forms.Button buttonbegintest;
    }
}