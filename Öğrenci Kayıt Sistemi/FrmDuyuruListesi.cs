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
    public partial class FrmDuyuruListesi : Form
    {
        public FrmDuyuruListesi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDuyuruListesi_Load(object sender, EventArgs e)
        {
            
            this.Controls.Add(lst);

            //Duyuruları Listeleme Kodları
            SqlCommand komut = new SqlCommand("Select * From TblDuyurular",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lst.Items.Add(dr[0]+ " " + dr[1] );
            }
            bgl.baglanti().Close();
        }
    }
}
