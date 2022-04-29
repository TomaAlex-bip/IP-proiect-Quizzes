using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Persistence
{
    public class DatabaseContext
    {
        private static DatabaseContext instance = null;

        public static DatabaseContext GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DatabaseContext();
                }
                return instance;
            }
        }

        public static SQLiteConnection ConnectToDatabase()
        { 
            try 
            { 
                SQLiteConnection sqlite_conn;
                sqlite_conn = new SQLiteConnection("Data Source=quizzes.db;Version=3;");
                sqlite_conn.Open();
            }

            catch(SQLiteException)
            {
                return null;
            }

            return null;
    }
   

}
