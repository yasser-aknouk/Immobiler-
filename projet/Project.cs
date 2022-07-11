using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace projet
{
    class Project
    {
        public SqlConnection cnx = new SqlConnection("data source = .; initial catalog = immobilier ; integrated security=true");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        




    }
}
