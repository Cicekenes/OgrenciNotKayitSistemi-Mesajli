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
    public partial class FrmOgrenci : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string numara;
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;

            //Numaraya göre isim getirme bilgisi
            SqlCommand komut = new SqlCommand("Select * From TblOgrenci where numara=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[1] + " " + dr[2];
                pictureOgr.ImageLocation = dr[5].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select * From TblNotlar where ogrıd=(Select ID From TblOgrenci Where Numara=@p1)",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",LblNumara.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblSınav1.Text = dr2[1].ToString();
                LblSınav2.Text = dr2[2].ToString();
                LblSınav3.Text = dr2[3].ToString();
                LblProje.Text = dr2[4].ToString();
                LblOrtalama.Text = dr2[5].ToString();
            }
            bgl.baglanti().Close();

            if (Convert.ToDouble(LblOrtalama.Text)>=50)
            {
                LblDurum.Text = "Geçtiniz";
            }
            else
            {
                LblDurum.Text = "Kaldınız";
            }

        }

        private void BtnOgrMesajlar_Click(object sender, EventArgs e)
        {
            FrmMesajlar fr = new FrmMesajlar();
            fr.numara = LblNumara.Text;
            fr.Show();
        }

        private void BtnOgrDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyuruListesi frm = new FrmDuyuruListesi();
            frm.Show();
        }

        private void BtnCalcu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }
    }
}
