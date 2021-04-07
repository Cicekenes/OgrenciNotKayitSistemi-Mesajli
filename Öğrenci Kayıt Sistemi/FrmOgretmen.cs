using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Öğrenci_Kayıt_Sistemi
{
    
    public partial class FrmOgretmen : Form
    {
        public string numara;
        SqlBaglantisi bgl = new SqlBaglantisi();
        public FrmOgretmen()
        {
            
            InitializeComponent();
        }
        void OgrenciListesi()
        {
            SqlCommand komut = new SqlCommand("Select * From TblOgrenci",bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        void NotListesi()
        {
            SqlCommand komut = new SqlCommand("Execute Ogrenciler",bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            //Öğrenci Listesini form yüklendiği anda gelir.
            OgrenciListesi();

            //Not Listesi getirir.
            NotListesi();

            //Numarayı label'a yazma
            LblNumara.Text = numara;

            //Numaraya göre isim bilgisi getirmek.
            SqlCommand komut = new SqlCommand("Select * From TblOgretmen where Numara=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
            }
            bgl.baglanti().Close();
        }
        string Fotograf;
        private void BtnFotografSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Fotograf = openFileDialog1.FileName;
            pictureBox1.ImageLocation = Fotograf;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TblOgrenci (ad,soyad,numara,sıfre,fotograf) values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskNumara.Text);
            komut.Parameters.AddWithValue("@p4",txtSifre.Text);
            komut.Parameters.AddWithValue("@p5",Fotograf);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.baglanti().Close();
            OgrenciListesi();
            NotListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskNumara.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            SqlCommand komut = new SqlCommand("select * from tblnotlar where Ogrıd=(SELECT ID from TblOgrenci Where Numara=@p1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                TxtSınav1.Text = dr[1].ToString();
                TxtSınav2.Text = dr[2].ToString();
                TxtSınav3.Text = dr[3].ToString();
                TxtProje.Text = dr[4].ToString();
                TxtOrtalama.Text = dr[5].ToString();
                TxtDurum.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update tblogrenci set ad=@p1,soyad=@p2,sıfre=@p3,fotograf=@p4 where numara=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",txtSifre.Text);
            komut.Parameters.AddWithValue("@p4",pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p5",mskNumara.Text);
            komut.ExecuteNonQuery();
           

            SqlCommand komut2 = new SqlCommand("update TblNotlar set Sınav1=@p1,Sınav2=@p2,Sınav3=@p3,Proje=@p4,Ortalama=@p5,Durum=@p6 where OGRID=(Select ID from TblOgrenci Where Numara=@p7)",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",TxtSınav1.Text);
            komut2.Parameters.AddWithValue("@p2",TxtSınav2.Text);
            komut2.Parameters.AddWithValue("@p3",TxtSınav3.Text);
            komut2.Parameters.AddWithValue("@p4",TxtProje.Text);
            komut2.Parameters.AddWithValue("@p5",Convert.ToDecimal(TxtOrtalama.Text));
            komut2.Parameters.AddWithValue("@p6",TxtDurum.Text);
            komut2.Parameters.AddWithValue("@p7",mskNumara.Text);
            komut2.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
            OgrenciListesi();
            NotListesi();

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, proje, ortalama;
            sinav1 = Convert.ToDouble(TxtSınav1.Text);
            sinav2 = Convert.ToDouble(TxtSınav2.Text);
            sinav3 = Convert.ToDouble(TxtSınav3.Text);
            proje = Convert.ToDouble(TxtProje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            TxtOrtalama.Text = ortalama.ToString();
            if (ortalama>=50)
            {
                TxtDurum.Text = "True";
            }
            else
            {
                TxtDurum.Text = "False";
            }
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            FrmDuyuruOlustur frm = new FrmDuyuruOlustur();
            frm.Show();
        }

        private void BtnDuyuruListesi_Click(object sender, EventArgs e)
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show();
        }
        
        private void BtnMesajlar_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.numara = LblNumara.Text;
            frm.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
