using LibMang.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMang.Business
{
    public class ClsBook
    {
        Clsdal clsdal = new Clsdal();
        public DataTable load()
        {
            SqlParameter[] par = null;
            DataTable dt = clsdal.read("loadBooks", par);
            return dt;
        }
    }
}
