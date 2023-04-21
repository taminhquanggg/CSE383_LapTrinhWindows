using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLTV
{
    class cConnection
    {
        private static string stringConnection = @"Data Source=MINHQUANG\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
