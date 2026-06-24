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


        public void addCategory(string categoryName)
        {
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("categoryname", categoryName);

            dal.open();
            dal.Excute("addcategory",par);
            dal.close();
        }


        public void editCategory(string categoryName , int categoryId)
        {
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("categoryname", categoryName);
            pars[1] = new SqlParameter("categoryid", categoryId);

            dal.open();
            dal.Excute("editCategory", pars);
            dal.close();
        }

        public void deleteCategory(int id)
        {
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("id", id);

            dal.open();
            dal.Excute("deleteCategory",par);
            dal.close();
                
        }

        public DataTable getResult(string userinput) {
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("categoryname", userinput);

            DataTable dt = dal.read("searchCategory", par);
            return dt;
        }
    }
}
