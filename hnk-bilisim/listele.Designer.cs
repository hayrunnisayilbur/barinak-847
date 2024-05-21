namespace hnk_bilisim
{
    partial class listele
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
            this.cmbCinsi = new System.Windows.Forms.ComboBox();
            this.txtYeniYas = new System.Windows.Forms.TextBox();
            this.txtYeniİsim = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.cbEngel = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwHayvanlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHayvanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCinsi
            // 
            this.cmbCinsi.FormattingEnabled = true;
            this.cmbCinsi.Location = new System.Drawing.Point(103, 170);
            this.cmbCinsi.Name = "cmbCinsi";
            this.cmbCinsi.Size = new System.Drawing.Size(121, 21);
            this.cmbCinsi.TabIndex = 17;
            // 
            // txtYeniYas
            // 
            this.txtYeniYas.Location = new System.Drawing.Point(103, 110);
            this.txtYeniYas.Name = "txtYeniYas";
            this.txtYeniYas.Size = new System.Drawing.Size(100, 20);
            this.txtYeniYas.TabIndex = 16;
            // 
            // txtYeniİsim
            // 
            this.txtYeniİsim.Location = new System.Drawing.Point(103, 43);
            this.txtYeniİsim.Name = "txtYeniİsim";
            this.txtYeniİsim.Size = new System.Drawing.Size(100, 20);
            this.txtYeniİsim.TabIndex = 15;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(496, 12);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(213, 83);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(296, 43);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(133, 199);
            this.pbResim.TabIndex = 13;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // cbEngel
            // 
            this.cbEngel.AutoSize = true;
            this.cbEngel.Location = new System.Drawing.Point(49, 225);
            this.cbEngel.Name = "cbEngel";
            this.cbEngel.Size = new System.Drawing.Size(90, 17);
            this.cbEngel.TabIndex = 12;
            this.cbEngel.Text = "engel durumu";
            this.cbEngel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "cinsi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "yaşı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "isim";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(496, 142);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(213, 83);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwHayvanlar
            // 
            this.dgwHayvanlar.AllowUserToAddRows = false;
            this.dgwHayvanlar.AllowUserToDeleteRows = false;
            this.dgwHayvanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHayvanlar.Location = new System.Drawing.Point(12, 255);
            this.dgwHayvanlar.Name = "dgwHayvanlar";
            this.dgwHayvanlar.ReadOnly = true;
            this.dgwHayvanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwHayvanlar.Size = new System.Drawing.Size(781, 183);
            this.dgwHayvanlar.TabIndex = 19;
            this.dgwHayvanlar.SelectionChanged += new System.EventHandler(this.dgwHayvanlar_SelectionChanged);
            // 
            // listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwHayvanlar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.cmbCinsi);
            this.Controls.Add(this.txtYeniYas);
            this.Controls.Add(this.txtYeniİsim);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.cbEngel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "listele";
            this.Text = "listele";
            this.Load += new System.EventHandler(this.listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHayvanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCinsi;
        private System.Windows.Forms.TextBox txtYeniYas;
        private System.Windows.Forms.TextBox txtYeniİsim;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.CheckBox cbEngel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwHayvanlar;
    }
}