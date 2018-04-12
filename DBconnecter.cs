using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyKS
{
    class DBconnecter
    {
        public static SqlConnection sqlConnector()
        {
            SqlConnection myConnect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanlyKS; Integrated Security=True");
            return myConnect;
        }
    }
}
