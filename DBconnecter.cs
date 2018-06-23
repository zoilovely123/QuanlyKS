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
            //SqlConnection myConnect = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QuanlyKS; Integrated Security=True");
            SqlConnection myConnect = new SqlConnection(@"Server=.\SQLExpress;AttachDbFilename=|DataDirectory|QuanlyKS.mdf; Database=dbname;Trusted_Connection=Yes;");
            return myConnect;
        }
    }
}
