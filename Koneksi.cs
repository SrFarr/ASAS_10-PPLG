using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Daftar_Hadir
{
    internal class Koneksi
    {
        public SqlConnection getConn()
        {
            SqlConnection conn = null;
            conn = new SqlConnection("data source = UNISCIENT\\SQLEXPRESS; database = Student; integrated security=SSPI ");
            return conn;
        }
    }
}
