using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrenci_Sinav_Calısma_Projesi
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Ogrenci_Sinav_Projesi;Integrated Security=True; Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
