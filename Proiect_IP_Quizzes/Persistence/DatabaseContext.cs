using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Entities;


namespace Persistence
{
    public class DatabaseContext
    {
        private static DatabaseContext _instance = null;

        //am facut asta sa fie pe toata clasa ca sa pot sa o accesez si in connect si in disconnect
        private SQLiteConnection _sqlConn;

        public static DatabaseContext GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseContext();
                }
                return _instance;
            }
        }

        public bool ConnectToDatabase()
        {
            try
            {
                _sqlConn = new SQLiteConnection("Data Source=quizzes.db;New=False");
                _sqlConn.Open();
            }

            catch (SQLiteException)
            {
                return false;
            }
            return true;
        }

        public bool DisconnectFromDatabase()
        {
            try
            {
                _sqlConn.Close();
            }

            catch (SQLiteException)
            {
                return false;
            }

            return true;
        }

        public int LoginUser(string username, string hash)
        {
            int clientID = 0;
            ConnectToDatabase();
            try
            {
                SQLiteCommand comm;
                SQLiteDataReader dataReader;
                String sql;

                sql = "SELECT user_id FROM Users WHERE username='" + username + "'AND hashed_password='" + hash + "'";


                comm = _sqlConn.CreateCommand();
                comm.CommandText = sql;
                dataReader = comm.ExecuteReader();

                while (dataReader.Read())
                {
                    clientID = dataReader.GetInt32(0);
                }

                dataReader.Close();
                comm.Dispose();
                DisconnectFromDatabase();

            }

            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return clientID;
        }


        public bool RegisterUser(string username, string hash)
        {
            ConnectToDatabase();
            try
            {
                SQLiteCommand cmd;
                cmd = _sqlConn.CreateCommand();
                String sql;


                //aici nu prea stiu cum sa facem cu is_admin ala, gen cum o sa putem noi modifica daca sa fie admin sau nu??? si deocamdata am lasat fara is_admin query-ul.

                sql = "INSERT INTO Users(username,hashed_password,is_admin) VALUES ('" + username + "','" + hash + "',1)";

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();


                cmd.Dispose();
                DisconnectFromDatabase();
            }

            catch (SQLiteException e)
            {
                Console.WriteLine(e);
            }
            return true;
        }

        public Statistic GetUserStatistics(int userID) //
        {
            try
            {
                SQLiteCommand cmd;
                SQLiteDataReader dataReader;
                String sql;
                string output;

                sql = "SELECT u.username, s.tests_passed, s.tests_failed, SUM(s.tests_passed,s.tests_failed) FROM Users u, Statistics s WHERE u.user_id = s.user_id AND u.username = '" + "

                cmd = _sqlConn.CreateCommand();
                cmd.CommandText = sql;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    output = dataReader.GetString(0);
                }

                dataReader.Close();
                cmd.Dispose();

                DisconnectFromDatabase();
            }

            catch (SQLiteException e)
            {
                Console.WriteLine(e);
            }
            return new Statistic();

        }
    }
}
