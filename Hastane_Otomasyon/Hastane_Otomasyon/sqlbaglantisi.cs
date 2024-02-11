using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Otomasyon
{
     class sqlbaglantisi
    {
        public SqlConnection conn()
        {
            SqlConnection conn = new SqlConnection("Data Source=DOGU;Initial Catalog=HastaneProje;Integrated Security=True;Connect Timeout=30;Encrypt=False");
            conn.Open();
            return conn;
        }
    }
}
