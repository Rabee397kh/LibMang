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

        public void AddBook(string name , int categoryid,decimal price,string author,
            DateTime publishdate , string rating , string img)
        {
            SqlParameter[] pars = new SqlParameter[7];
            pars[0] = new SqlParameter("name",name);
            pars[1] = new SqlParameter("categoryid", categoryid);
            pars[2] = new SqlParameter("price", price);
            pars[3] = new SqlParameter("author", author);
            pars[4] = new SqlParameter("publishDate", publishdate);
            pars[5] = new SqlParameter("rating", rating);
            pars[6] = new SqlParameter("cover", img);

            clsdal.open();
            clsdal.Excute("addBook", pars);
            clsdal.close();
        }
    }
}
