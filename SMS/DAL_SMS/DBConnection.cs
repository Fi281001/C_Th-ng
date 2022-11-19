using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL_SMS
{
    public class DBConnection
    {
        public static SqlConnection con = new SqlConnection("server=DESKTOP-KVD6FF6\\MYSQL;uid=sa;pwd=123; database=SMD");
    }
}
