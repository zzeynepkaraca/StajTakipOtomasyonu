using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace staj_takip_sistemi
{
    internal class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source = LAPTOP-DME220JL;Initial Catalog=staj takip sistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
