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
    public class ClsCategory
    {
        Clsdal dal = new Clsdal();

        public  DataTable load()
        {
            SqlParameter[] par = null;
            DataTable dt = new DataTable();
            dt = dal.read("loadCategory", par);
            return dt;
        }
    }
}
