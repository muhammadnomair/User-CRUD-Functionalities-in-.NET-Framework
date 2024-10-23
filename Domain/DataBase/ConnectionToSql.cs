using System;
using System.Data.SQLite;

namespace UserCRUD.Domain.DataBase
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionstring;
        public ConnectionToSql()
        {
            // you can get your DB connection string from the DB settings.
            connectionstring = "Your connection string here for SQLite Data!";
        }

        protected SQLiteConnection GetConnection()
        {
            SQLiteConnection conn = null;
            try
            {
                conn = new SQLiteConnection("Data Source=" + connectionstring + ";Version=3;");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return conn;
        }
    }
}
