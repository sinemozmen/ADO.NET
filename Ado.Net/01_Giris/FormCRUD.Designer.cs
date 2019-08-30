namespace _01_Giris
{
    partial class FormCRUD
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
            this.grpInsert = new System.Windows.Forms.GroupBox();
            this.txtEtkilenenSatirSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.cmbKategoriUpdate = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateTanim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateKategoriAdi = new System.Windows.Forms.TextBox();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.cmbKategoriDelete = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstSilUrun = new System.Windows.Forms.ListBox();
            this.grpSelect1 = new System.Windows.Forms.GroupBox();
            this.btnCiroHesapla = new System.Windows.Forms.Button();
            this.lblCiro = new System.Windows.Forms.Label();
            this.txtCiro = new System.Windows.Forms.TextBox();
            this.grpSelect2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecilen = new System.Windows.Forms.TextBox();
            this.btnDataYukle = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpInsert.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.grpSelect1.SuspendLayout();
            this.grpSelect2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInsert
            // 
            this.grpInsert.BackColor = System.Drawing.Color.Aquamarine;
            this.grpInsert.Controls.Add(this.label6);
            this.grpInsert.Controls.Add(this.label1);
            this.grpInsert.Controls.Add(this.txtEtkilenenSatirSayisi);
            this.grpInsert.Controls.Add(this.label2);
            this.grpInsert.Controls.Add(this.txtDescription);
            this.grpInsert.Controls.Add(this.btnInsert);
            this.grpInsert.Controls.Add(this.txtCategoryName);
            this.grpInsert.Location = new System.Drawing.Point(20, 24);
            this.grpInsert.Margin = new System.Windows.Forms.Padding(2);
            this.grpInsert.Name = "grpInsert";
            this.grpInsert.Padding = new System.Windows.Forms.Padding(2);
            this.grpInsert.Size = new System.Drawing.Size(150, 317);
            this.grpInsert.TabIndex = 0;
            this.grpInsert.TabStop = false;
            this.grpInsert.Text = "Insert";
            // 
            // txtEtkilenenSatirSayisi
            // 
            this.txtEtkilenenSatirSayisi.Location = new System.Drawing.Point(58, 184);
            this.txtEtkilenenSatirSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.txtEtkilenenSatirSayisi.Name = "txtEtkilenenSatirSayisi";
            this.txtEtkilenenSatirSayisi.Size = new System.Drawing.Size(76, 20);
            this.txtEtkilenenSatirSayisi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Etkilenen\r\nSatir\r\nSayisi\r\n";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(65, 67);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(76, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(36, 117);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(81, 38);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(65, 36);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(76, 20);
            this.txtCategoryName.TabIndex = 1;
            // 
            // grpUpdate
            // 
            this.grpUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.grpUpdate.Controls.Add(this.cmbKategoriUpdate);
            this.grpUpdate.Controls.Add(this.label9);
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.txtUpdateTanim);
            this.grpUpdate.Controls.Add(this.label7);
            this.grpUpdate.Controls.Add(this.txtUpdateKategoriAdi);
            this.grpUpdate.Controls.Add(this.label5);
            this.grpUpdate.Location = new System.Drawing.Point(182, 24);
            this.grpUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Padding = new System.Windows.Forms.Padding(2);
            this.grpUpdate.Size = new System.Drawing.Size(199, 317);
            this.grpUpdate.TabIndex = 1;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update";
            // 
            // cmbKategoriUpdate
            // 
            this.cmbKategoriUpdate.FormattingEnabled = true;
            this.cmbKategoriUpdate.Location = new System.Drawing.Point(75, 36);
            this.cmbKategoriUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKategoriUpdate.Name = "cmbKategoriUpdate";
            this.cmbKategoriUpdate.Size = new System.Drawing.Size(112, 21);
            this.cmbKategoriUpdate.TabIndex = 8;
            this.cmbKategoriUpdate.SelectedIndexChanged += new System.EventHandler(this.UpdateTextboxDoldur);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(54, 182);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 43);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateTanim
            // 
            this.txtUpdateTanim.Location = new System.Drawing.Point(75, 128);
            this.txtUpdateTanim.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateTanim.Name = "txtUpdateTanim";
            this.txtUpdateTanim.Size = new System.Drawing.Size(112, 20);
            this.txtUpdateTanim.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tanım";
            // 
            // txtUpdateKategoriAdi
            // 
            this.txtUpdateKategoriAdi.Location = new System.Drawing.Point(75, 83);
            this.txtUpdateKategoriAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateKategoriAdi.Name = "txtUpdateKategoriAdi";
            this.txtUpdateKategoriAdi.Size = new System.Drawing.Size(112, 20);
            this.txtUpdateKategoriAdi.TabIndex = 3;
            // 
            // grpDelete
            // 
            this.grpDelete.BackColor = System.Drawing.Color.Bisque;
            this.grpDelete.Controls.Add(this.label8);
            this.grpDelete.Controls.Add(this.cmbKategoriDelete);
            this.grpDelete.Controls.Add(this.btnSil);
            this.grpDelete.Controls.Add(this.lstSilUrun);
            this.grpDelete.Location = new System.Drawing.Point(386, 24);
            this.grpDelete.Margin = new System.Windows.Forms.Padding(2);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Padding = new System.Windows.Forms.Padding(2);
            this.grpDelete.Size = new System.Drawing.Size(150, 317);
            this.grpDelete.TabIndex = 2;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete";
            this.grpDelete.Enter += new System.EventHandler(this.GrpDelete_Enter);
            // 
            // cmbKategoriDelete
            // 
            this.cmbKategoriDelete.FormattingEnabled = true;
            this.cmbKategoriDelete.Location = new System.Drawing.Point(58, 36);
            this.cmbKategoriDelete.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKategoriDelete.Name = "cmbKategoriDelete";
            this.cmbKategoriDelete.Size = new System.Drawing.Size(89, 21);
            this.cmbKategoriDelete.TabIndex = 9;
            this.cmbKategoriDelete.SelectedIndexChanged += new System.EventHandler(this.DeleteUrunYukle);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(35, 180);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 39);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Delete";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // lstSilUrun
            // 
            this.lstSilUrun.FormattingEnabled = true;
            this.lstSilUrun.Location = new System.Drawing.Point(14, 69);
            this.lstSilUrun.Margin = new System.Windows.Forms.Padding(2);
            this.lstSilUrun.Name = "lstSilUrun";
            this.lstSilUrun.Size = new System.Drawing.Size(132, 82);
            this.lstSilUrun.TabIndex = 8;
            // 
            // grpSelect1
            // 
            this.grpSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grpSelect1.Controls.Add(this.btnCiroHesapla);
            this.grpSelect1.Controls.Add(this.lblCiro);
            this.grpSelect1.Controls.Add(this.txtCiro);
            this.grpSelect1.Location = new System.Drawing.Point(540, 24);
            this.grpSelect1.Margin = new System.Windows.Forms.Padding(2);
            this.grpSelect1.Name = "grpSelect1";
            this.grpSelect1.Padding = new System.Windows.Forms.Padding(2);
            this.grpSelect1.Size = new System.Drawing.Size(139, 317);
            this.grpSelect1.TabIndex = 2;
            this.grpSelect1.TabStop = false;
            this.grpSelect1.Text = "Select1";
            // 
            // btnCiroHesapla
            // 
            this.btnCiroHesapla.Location = new System.Drawing.Point(32, 73);
            this.btnCiroHesapla.Margin = new System.Windows.Forms.Padding(2);
            this.btnCiroHesapla.Name = "btnCiroHesapla";
            this.btnCiroHesapla.Size = new System.Drawing.Size(68, 51);
            this.btnCiroHesapla.TabIndex = 9;
            this.btnCiroHesapla.Text = "Ciro Hesapla";
            this.btnCiroHesapla.UseVisualStyleBackColor = true;
            this.btnCiroHesapla.Click += new System.EventHandler(this.btnCiroHesapla_Click);
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(10, 36);
            this.lblCiro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(25, 13);
            this.lblCiro.TabIndex = 7;
            this.lblCiro.Text = "Ciro";
            // 
            // txtCiro
            // 
            this.txtCiro.Location = new System.Drawing.Point(44, 36);
            this.txtCiro.Margin = new System.Windows.Forms.Padding(2);
            this.txtCiro.Name = "txtCiro";
            this.txtCiro.Size = new System.Drawing.Size(76, 20);
            this.txtCiro.TabIndex = 8;
            // 
            // grpSelect2
            // 
            this.grpSelect2.BackColor = System.Drawing.Color.PaleGreen;
            this.grpSelect2.Controls.Add(this.label3);
            this.grpSelect2.Controls.Add(this.label4);
            this.grpSelect2.Controls.Add(this.txtSecilen);
            this.grpSelect2.Controls.Add(this.btnDataYukle);
            this.grpSelect2.Controls.Add(this.lstUrunler);
            this.grpSelect2.Controls.Add(this.cmbKategoriler);
            this.grpSelect2.Location = new System.Drawing.Point(686, 24);
            this.grpSelect2.Margin = new System.Windows.Forms.Padding(2);
            this.grpSelect2.Name = "grpSelect2";
            this.grpSelect2.Padding = new System.Windows.Forms.Padding(2);
            this.grpSelect2.Size = new System.Drawing.Size(240, 321);
            this.grpSelect2.TabIndex = 3;
            this.grpSelect2.TabStop = false;
            this.grpSelect2.Text = "Select2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Secilen : ";
            // 
            // txtSecilen
            // 
            this.txtSecilen.Location = new System.Drawing.Point(8, 221);
            this.txtSecilen.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecilen.Name = "txtSecilen";
            this.txtSecilen.Size = new System.Drawing.Size(209, 20);
            this.txtSecilen.TabIndex = 4;
            // 
            // btnDataYukle
            // 
            this.btnDataYukle.Location = new System.Drawing.Point(39, 265);
            this.btnDataYukle.Margin = new System.Windows.Forms.Padding(2);
            this.btnDataYukle.Name = "btnDataYukle";
            this.btnDataYukle.Size = new System.Drawing.Size(153, 34);
            this.btnDataYukle.TabIndex = 3;
            this.btnDataYukle.Text = "Data Yukle ";
            this.btnDataYukle.UseVisualStyleBackColor = true;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(8, 67);
            this.lstUrunler.Margin = new System.Windows.Forms.Padding(2);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(209, 108);
            this.lstUrunler.TabIndex = 2;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.SecilenYukle);
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(55, 36);
            this.cmbKategoriler.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(162, 21);
            this.cmbKategoriler.TabIndex = 1;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.Alafortanfoni);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Kategori Adi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kategoriler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kategori Adi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tanım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kategoriler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-3, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Kategoriler";
            // 
            // FormCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 366);
            this.Controls.Add(this.grpSelect2);
            this.Controls.Add(this.grpSelect1);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grpInsert);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCRUD";
            this.Text = "ADO.NET Uygulamaları";
            this.Load += new System.EventHandler(this.SelectKategorileriYukle);
            this.grpInsert.ResumeLayout(false);
            this.grpInsert.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpSelect1.ResumeLayout(false);
            this.grpSelect1.PerformLayout();
            this.grpSelect2.ResumeLayout(false);
            this.grpSelect2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInsert;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.GroupBox grpSelect1;
        private System.Windows.Forms.GroupBox grpSelect2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtEtkilenenSatirSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCiroHesapla;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.TextBox txtCiro;
        private System.Windows.Forms.Button btnDataYukle;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecilen;
        private System.Windows.Forms.ComboBox cmbKategoriUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateTanim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateKategoriAdi;
        private System.Windows.Forms.ComboBox cmbKategoriDelete;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstSilUrun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}

