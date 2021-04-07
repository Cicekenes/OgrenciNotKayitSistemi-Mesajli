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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void btnOgretmenGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TblOgretmen where Numara=@p1 and Sıfre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskOgretmenNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtOgretmenSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgretmen fr = new FrmOgretmen();
                fr.numara = mskOgretmenNumara.Text;
                fr.Show();
                MessageBox.Show("Sisteme Hoşgeldiniz ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();
        }

        private void btnOgrGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TblOgrenci where Numara=@p1 and Sıfre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskOgrenciNumara.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrenciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgrenci fr = new FrmOgrenci();
                fr.numara = mskOgrenciNumara.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Numara ya da Şifre", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            bgl.baglanti().Close();
        }
    }
}
