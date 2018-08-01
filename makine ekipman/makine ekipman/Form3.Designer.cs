namespace makine_ekipman
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbFirma3 = new System.Windows.Forms.ComboBox();
            this.lblFirma3 = new System.Windows.Forms.Label();
            this.btnGoster3 = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Seçiniz";
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Items.AddRange(new object[] {
            "Biçme Makinesi",
            "Çapa Makinesi",
            "Dip Kazan",
            "Ekim Makinesi",
            "Goble",
            "Gübre Serpme Makinesi",
            "İlaçlama Makinesi",
            "Kultuvator",
            "Merdane",
            "Pulluk",
            "Römork",
            "Rotovatör",
            "Tesviye Küreği",
            "Tırmık",
            "Yükleme Kepçesi"});
            this.cmbUrun.Location = new System.Drawing.Point(154, 16);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(121, 21);
            this.cmbUrun.TabIndex = 1;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // cmbFirma3
            // 
            this.cmbFirma3.FormattingEnabled = true;
            this.cmbFirma3.Location = new System.Drawing.Point(474, 16);
            this.cmbFirma3.Name = "cmbFirma3";
            this.cmbFirma3.Size = new System.Drawing.Size(121, 21);
            this.cmbFirma3.TabIndex = 2;
            this.cmbFirma3.SelectedIndexChanged += new System.EventHandler(this.cmbFirma3_SelectedIndexChanged);
            // 
            // lblFirma3
            // 
            this.lblFirma3.AutoSize = true;
            this.lblFirma3.BackColor = System.Drawing.Color.Transparent;
            this.lblFirma3.Location = new System.Drawing.Point(374, 24);
            this.lblFirma3.Name = "lblFirma3";
            this.lblFirma3.Size = new System.Drawing.Size(41, 13);
            this.lblFirma3.TabIndex = 3;
            this.lblFirma3.Text = "Firma 1";
            // 
            // btnGoster3
            // 
            this.btnGoster3.Location = new System.Drawing.Point(655, 15);
            this.btnGoster3.Name = "btnGoster3";
            this.btnGoster3.Size = new System.Drawing.Size(75, 23);
            this.btnGoster3.TabIndex = 4;
            this.btnGoster3.Text = "GÖSTER";
            this.btnGoster3.UseVisualStyleBackColor = true;
            this.btnGoster3.Click += new System.EventHandler(this.btnGoster3_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(321, 376);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 40);
            this.btnEkle.TabIndex = 152;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 521);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGoster3);
            this.Controls.Add(this.lblFirma3);
            this.Controls.Add(this.cmbFirma3);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "ÜRÜN SECİMİ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.ComboBox cmbFirma3;
        private System.Windows.Forms.Label lblFirma3;
        private System.Windows.Forms.Button btnGoster3;
        private System.Windows.Forms.Button btnEkle;
    }
}