namespace hnk_bilisim
{
    partial class YeniEkle
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbEngel = new System.Windows.Forms.CheckBox();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.cmbCins = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "isim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "yaşı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "cins";
            // 
            // cbEngel
            // 
            this.cbEngel.AutoSize = true;
            this.cbEngel.Location = new System.Drawing.Point(73, 213);
            this.cbEngel.Name = "cbEngel";
            this.cbEngel.Size = new System.Drawing.Size(90, 17);
            this.cbEngel.TabIndex = 3;
            this.cbEngel.Text = "engel durumu";
            this.cbEngel.UseVisualStyleBackColor = true;
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(320, 31);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(133, 199);
            this.pbResim.TabIndex = 4;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(508, 82);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(213, 122);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(127, 31);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(100, 20);
            this.txtİsim.TabIndex = 6;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(127, 98);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 20);
            this.txtYas.TabIndex = 7;
            // 
            // cmbCins
            // 
            this.cmbCins.FormattingEnabled = true;
            this.cmbCins.Location = new System.Drawing.Point(127, 158);
            this.cmbCins.Name = "cmbCins";
            this.cmbCins.Size = new System.Drawing.Size(121, 21);
            this.cmbCins.TabIndex = 8;
            // 
            // YeniEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.cmbCins);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.cbEngel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniEkle";
            this.Text = "YeniEkle";
            this.Load += new System.EventHandler(this.YeniEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbEngel;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.ComboBox cmbCins;
    }
}