using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BACKUPRESTORETEST
{
    class DbConnection
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private string con;
     
        public string MyConnection()
        {
            con = @"Data Source=DESKTOP-DPKSP8J;Initial Catalog=BACKRESTEST;Integrated Security=True";
            return con;
        }
    }
}
