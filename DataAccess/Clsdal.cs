using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMang.DataAccess
{
    public class Clsdal
    {
        SqlConnection connection;

        public Clsdal()
        {
            connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\projects\LibMang\LibMangDB.mdf; Integrated Security = True");
        }

        public void open()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            
        }

        public void close()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable read(string store, SqlParameter[] par)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = store;

            if(par != null)
            {
                command.Parameters.AddRange(par);
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dt= new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public void Excute(string store , SqlParameter[] par)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = store;

            if(par != null) {
                command.Parameters.AddRange(par);
            }
            
            command.ExecuteNonQuery();
        }
    }
}
