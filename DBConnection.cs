using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace note_taking
{
    internal class DBConnection
    {
        private MySqlConnection conn;

        private void ConnectToDB()
        {
            conn = new MySqlConnection("persist security info=false;" +
                "server=localhost;" +
                "database=notes;" +
                "uid=root;pwd=;SslMode=none");
            conn.Open();
        }

        private void Close() {
            conn.Close();
        }

        public void CreateNote(String title, String description)
        {
            this.ConnectToDB();
            MySqlCommand query = new MySqlCommand($"insert into note values(null, '{title}', '{description}', CURRENT_TIMESTAMP, null)", conn);
            query.ExecuteNonQuery();
            this.Close();
        }
        public DataTable ListNote()
        {
            this.ConnectToDB();
            MySqlDataAdapter query = new MySqlDataAdapter("select * from note", conn);
            DataTable result = new DataTable();
            query.Fill(result);
            this.Close();
            return result;
        }
    }
}
