
namespace Öğrenci_Kayıt_Sistemi
{
    partial class FrmDuyuruOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDuyuruOlustur));
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnDuyuruEkle = new System.Windows.Forms.Button();
            this.BtnDuyuruSil = new System.Windows.Forms.Button();
            this.BtnDuyuruGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.BackColor = System.Drawing.Color.AntiqueWhite;
            this.RchDuyuru.Location = new System.Drawing.Point(0, 0);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(446, 146);
            this.RchDuyuru.TabIndex = 0;
            this.RchDuyuru.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(446, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnDuyuruEkle
            // 
            this.BtnDuyuruEkle.Location = new System.Drawing.Point(25, 152);
            this.BtnDuyuruEkle.Name = "BtnDuyuruEkle";
            this.BtnDuyuruEkle.Size = new System.Drawing.Size(114, 31);
            this.BtnDuyuruEkle.TabIndex = 2;
            this.BtnDuyuruEkle.Text = "Ekle";
            this.BtnDuyuruEkle.UseVisualStyleBackColor = true;
            this.BtnDuyuruEkle.Click += new System.EventHandler(this.BtnDuyuruEkle_Click);
            // 
            // BtnDuyuruSil
            // 
            this.BtnDuyuruSil.Location = new System.Drawing.Point(186, 151);
            this.BtnDuyuruSil.Name = "BtnDuyuruSil";
            this.BtnDuyuruSil.Size = new System.Drawing.Size(114, 31);
            this.BtnDuyuruSil.TabIndex = 3;
            this.BtnDuyuruSil.Text = "Sil";
            this.BtnDuyuruSil.UseVisualStyleBackColor = true;
            this.BtnDuyuruSil.Click += new System.EventHandler(this.BtnDuyuruSil_Click);
            // 
            // BtnDuyuruGuncelle
            // 
            this.BtnDuyuruGuncelle.Location = new System.Drawing.Point(326, 151);
            this.BtnDuyuruGuncelle.Name = "BtnDuyuruGuncelle";
            this.BtnDuyuruGuncelle.Size = new System.Drawing.Size(114, 32);
            this.BtnDuyuruGuncelle.TabIndex = 4;
            this.BtnDuyuruGuncelle.Text = "Güncelle";
            this.BtnDuyuruGuncelle.UseVisualStyleBackColor = true;
            this.BtnDuyuruGuncelle.Click += new System.EventHandler(this.BtnDuyuruGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 186);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmDuyuruOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDuyuruGuncelle);
            this.Controls.Add(this.BtnDuyuruSil);
            this.Controls.Add(this.BtnDuyuruEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RchDuyuru);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmDuyuruOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmDuyuruOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RchDuyuru;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnDuyuruEkle;
        private System.Windows.Forms.Button BtnDuyuruSil;
        private System.Windows.Forms.Button BtnDuyuruGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}