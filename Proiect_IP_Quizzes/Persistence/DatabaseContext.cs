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

        public static DatabaseContext Instance
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

        private bool ConnectToDatabase()
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

        private bool DisconnectFromDatabase()
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

        public User LoginUser(string username, string hash)
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

                if (dataReader.Read())
                {
                    clientID = dataReader.GetInt32(0);
                }

                dataReader.Close();
                comm.Dispose();
                DisconnectFromDatabase();

                return new User(clientID, username, hash, 0);
            }

            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
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

                sql = $"INSERT INTO Users(username,hashed_password,is_admin) VALUES ('{username}','{hash}', 0)";

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

                sql = $"SELECT tests_passed, tests_failed, tests_failed+tests_passed AS tests FROM Statistics WHERE user_id = {userID}";

                cmd = _sqlConn.CreateCommand();
                cmd.CommandText = sql;
                dataReader = cmd.ExecuteReader();

                int pass = 0;
                int fail = 0;
                int total = 0;


                if (dataReader.Read())
                {
                    pass = dataReader.GetInt32(0);
                    fail = dataReader.GetInt32(1);
                    total = dataReader.GetInt32(2);
                }

                dataReader.Close();
                cmd.Dispose();

                DisconnectFromDatabase();

                return new Statistic(userID, total, pass, fail);
            }

            catch (SQLiteException e)
            {
                Console.WriteLine(e);
            }

            return new Statistic(userID, 0, 0, 0);

        }
        public List<Attempt> GetUserAttempts(int userID)
        {
            List<Attempt> attempts = new List<Attempt>();

            try
            {
                SQLiteCommand cmd;
                SQLiteDataReader dataReader;
                String sql;


                sql = "SELECT attempt_id,quiz_type,attempt_date,correct_answers,wrong_answers FROM Attempts WHERE user_id = '" + userID + "'";

                cmd = _sqlConn.CreateCommand();
                cmd.CommandText = sql;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    var atid = dataReader.GetInt32(0);
                    var name = dataReader.GetString(1);
                    var attd = dataReader.GetString(2);
                    var ca = dataReader.GetInt32(3);
                    var wa = dataReader.GetInt32(4);
                    Console.WriteLine(atid + " " + name + " " + attd + " " + ca + " " + wa);

                    Attempt a = new Attempt(atid, userID, attd, ca, wa);

                    attempts.Add(a);

                }

                dataReader.Close();
                cmd.Dispose();

                DisconnectFromDatabase();
            }

            catch (SQLiteException e)
            {
                Console.WriteLine(e);
            }
            return attempts;
        }

        public List<Question> GetQuestionsOfType(string type)
        {
            List<Question> questions = new List<Question>();
            
            try
            {
                SQLiteCommand cmd;
                SQLiteDataReader dataReader;
                String sql;


                sql = $"SELECT question_text, question_answer_1, question_answer_2, question_answer_3, question_correct_answer FROM Questions WHERE question_type = '{type}'";

                cmd = _sqlConn.CreateCommand();
                cmd.CommandText = sql;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    var qt = dataReader.GetString(0);
                    var qa1 = dataReader.GetString(1);
                    var qa2 = dataReader.GetString(2);
                    var qa3 = dataReader.GetString(3);
                    var qca = dataReader.GetInt32(4);
                    Console.WriteLine(qt + " " + qa1 + " " + qa2 + " " + qa3 + " " + qca);

                    Question question = new Question(0, type, qt, qa1, qa2, qa3, qca);

                    questions.Add(question);
                }

                dataReader.Close();
                cmd.Dispose();

                DisconnectFromDatabase();
            }

            catch (SQLiteException e)
            {
                Console.WriteLine(e);
            }
            return questions;
        }

        public List<string> GetQuestionsType()
        {
            List<string> qtype = new List<string>();
            
            try
            {
                SQLiteCommand cmd;
                SQLiteDataReader dataReader;
                String sql;


                sql = $"SELECT DISTINCT question_type FROM Questions";

                cmd = _sqlConn.CreateCommand();
                cmd.CommandText = sql;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    var qt = dataReader.GetString(0);
                    Console.WriteLine(qt);

                    qtype.Add(qt);

                }

                dataReader.Close();
                cmd.Dispose();

                DisconnectFromDatabase();
            }

            catch (SQLiteException e)
            {
                Console.WriteLine(e);
            }
            return qtype;
           
        }

        public List<Question> GetAllQuestions()
        {
            List<Question> allq = new List<Question>();

            try
            {
                SQLiteCommand cmd;
                SQLiteDataReader dataReader;
                String sql;


                sql = $"SELECT question_text, question_answer_1, question_answer_2, question_answer_3, question_correct_answer FROM Questions";

                cmd = _sqlConn.CreateCommand();
                cmd.CommandText = sql;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    var qt = dataReader.GetString(0);
                    var qa1 = dataReader.GetString(1);
                    var qa2 = dataReader.GetString(2);
                    var qa3 = dataReader.GetString(3);
                    var qca = dataReader.GetInt32(4);

                    Question qs = new Question(0, "", qt, qa1, qa2, qa3, qca);

                    allq.Add(qs);

                }

                dataReader.Close();
                cmd.Dispose();

                DisconnectFromDatabase();
            }

            catch (SQLiteException e)
            {
                Console.WriteLine(e);
            }
            return allq;

        }

        public bool AddQuestion(Question question)
        {
            ConnectToDatabase();
            try
            {
                SQLiteCommand cmd;
                cmd = _sqlConn.CreateCommand();
                String sql;


                sql = "INSERT INTO Questions(question_type,question_text,question_answer_1,question_answer_2,question_answer_3,question_correct_answer) " +
                    $"VALUES ('{question.Type}','{question.Text}','{question.Answer1}','{question.Answer2}','{question.Answer3}', {question.CorrectAnswer})";

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                
                cmd.Dispose();
                DisconnectFromDatabase();

                return true;

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e);
                return false;
            }

        }
        public bool UpdateQuestion(int id, Question question)
        {
            ConnectToDatabase();
            try
            {
                SQLiteCommand cmd;
                cmd = _sqlConn.CreateCommand();
                String sql;


                sql = "UPDATE Questions SET " +
                    $"question_type = '{question.Type}', " +
                    $"question_text = '{question.Text}', " +
                    $"question_answer_1 = '{question.Answer1}', " +
                    $"question_answer_2 = '{question.Answer2}', " +
                    $"question_answer_3 = '{question.Answer3}', " +
                    $"question_correct_answer = {question.CorrectAnswer}" +
                    $"WHERE question_id = {id}";

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();


                cmd.Dispose();
                DisconnectFromDatabase();

                return true;

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool DeleteQuestion(int id)
        {
            ConnectToDatabase();
            try
            {
                SQLiteCommand cmd;
                cmd = _sqlConn.CreateCommand();
                String sql;


                sql = "DELETE FROM Questions " +
                    $"WHERE question_id = {id}";

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();


                cmd.Dispose();
                DisconnectFromDatabase();

                return true;

            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e);
                return false;
            }

        }
    }
}
