using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace deneme
{
    internal class ProjeBaglanti
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=ADEMTRKS;Initial Catalog=AracKiralama;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
