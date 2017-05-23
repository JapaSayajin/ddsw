using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DDSW
{
    class Connection
    {
        private MySqlConnection conn = new MySqlConnection();
        private MySqlCommand Query = new MySqlCommand();
        private MySqlDataReader Reader;
        public Connection(){
                conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=ddsw;Convert Zero Datetime=true";
                conn.Open();
                Query.Connection = conn;
        }

        public void setQuery(String q)
        {
            this.Query.CommandText = q;
        }

        public void executeNonQuery()
        {
            Query.ExecuteNonQuery();
        }

        public void executeReader()
        {
            Reader = Query.ExecuteReader();
        }

        public MySqlDataReader getReader()
        {
            return Reader;
        }

        public void close()
        {
            if(conn != null)
                conn.Close();
        }


    }
}
