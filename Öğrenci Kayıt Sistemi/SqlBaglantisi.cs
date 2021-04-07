using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Öğrenci_Kayıt_Sistemi
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-VBLQGME\SQLEXPRESS;
            Initial Catalog=StudentManagementSystemDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
