using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Entities;


namespace Persistence
{
    /// <summary>
    /// Clasa pentru citirea/scrierea/stergerea din baza de date
    /// </summary>
    public class DatabaseContext
    {
        private static DatabaseContext _instance = null;

 
        private SQLiteConnection _sqlConn;

        /// <summary>
        /// Clasa pentru a crea un singleton design pattern
        /// </summary>
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

        /// <summary>
        /// Clasa pentru conectarea la baza de date
        /// </summary>
        /// <returns>False daca nu s-a reusit conectarea, true daca s-a reusit</returns>
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

        /// <summary>
        /// Clasa pentru deconectarea de la baza de date
        /// </summary>
        /// <returns>False daca nu s-a reusit deconectarea, true daca s-a reusit</returns>
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

        /// <summary>
        /// Clasa pentru logarea la baza de date cu un anumit user stocat in baza de date
        /// </summary>
        /// <param name="username">Username-ul utilizatorului</param>
        /// <param name="hash">Parola criptata</param>
        /// <returns>User-ul din baza de date</returns>
        public User LoginUser(string username, string hash)
        {
            int clientID = -1;
            int isAdmin = 0;
            ConnectToDatabase();
            try
            {
                SQLiteCommand comm;
                SQLiteDataReader dataReader;
                String sql;

                sql = "SELECT user_id, is_admin FROM Users WHERE username='" + username + "' AND hashed_password='" + hash + "'";
                //sql = "SELECT user_id FROM Users WHERE username='user' AND hashed_password='userpassword'";


                comm = _sqlConn.CreateCommand();
                comm.CommandText = sql;
                dataReader = comm.ExecuteReader();

                if (dataReader.Read())
                {
                    clientID = dataReader.GetInt32(0);
                    isAdmin = dataReader.GetInt32(1);
                }

                dataReader.Close();
                comm.Dispose();
                DisconnectFromDatabase();

                if(clientID == -1)
                    return null;

                return new User(clientID, username, hash, isAdmin);
            }

            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        /// <summary>
        /// Clasa pentru a inregistra un nou user
        /// </summary>
        /// <param name="username">Username-ul utilizatorului cu care se inregistreaza</param>
        /// <param name="hash">Parola criptata</param>
        /// <returns>True daca s-a reusit inregistrarea</returns>
        public bool RegisterUser(string username, string hash)
        {
            ConnectToDatabase();
            try
            {
                SQLiteCommand cmd;
                cmd = _sqlConn.CreateCommand();
                String sql;


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

        /// <summary>
        /// Clasa pentru preluarea statisticilor unui user conectat
        /// </summary>
        /// <param name="userID">ID-ul utilizatorului conectat</param>
        /// <returns>Statisticile utilizatorului</returns>
        public Statistic GetUserStatistics(int userID) //
        {
            ConnectToDatabase();

            try
            {
                SQLiteCommand cmd;
                SQLiteDataReader dataReader;
                String sql;

                sql = $"SELECT tests_passed, tests_failed FROM Statistics WHERE user_id = {userID}";

                cmd = _sqlConn.CreateCommand();
                cmd.CommandText = sql;
                dataReader = cmd.ExecuteReader();

                int pass = 0;
                int fail = 0;


                if (dataReader.Read())
                {
                    pass = dataReader.GetInt32(0);
                    fail = dataReader.GetInt32(1);
                }

                dataReader.Close();
                cmd.Dispose();

                DisconnectFromDatabase();

                return new Statistic(userID, pass+fail, pass, fail);
            }

            catch (SQLiteException e)
            {
                Console.WriteLine(e);
            }

            return new Statistic(userID, 0, 0, 0);

        }

        /// <summary>
        /// Clasa pentru a afla numarul de incercari de rezolvare cat si raspunsurile corecte/incorecte
        /// </summary>
        /// <param name="userID">ID-ul utilizatorului conectat</param>
        /// <returns>Lista corespunzatoare incercarilor</returns>
        public List<Attempt> GetUserAttempts(int userID)
        {
            ConnectToDatabase();

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

                    Attempt a = new Attempt(atid, userID, attd, ca, wa, name);

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

        /// <summary>
        /// Clasa pentru preluarea intrebarilor de un anumit tip
        /// </summary>
        /// <param name="type">Tipul intrebarii</param>
        /// <returns>Lista cu intrebari de un anumit tip</returns>
        public List<Question> GetQuestionsOfType(string type)
        {
            ConnectToDatabase();

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
                    //Console.WriteLine(qt + " " + qa1 + " " + qa2 + " " + qa3 + " " + qca);

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

        /// <summary>
        /// Clasa pentru a prelua tipul intrebarilor
        /// </summary>
        /// <returns>Lista cu tipul intrebarilor</returns>
        public List<string> GetQuestionsType()
        {
            ConnectToDatabase();

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

        /// <summary>
        /// Clasa pentru a prelua toate intrebarile
        /// </summary>
        /// <returns>Lista cu toate intrebarile</returns>
        public List<Question> GetAllQuestions()
        {
            ConnectToDatabase();

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

        /// <summary>
        /// Clasa pentru a adauga o intrebare noua
        /// </summary>
        /// <param name="question">Clasa pentru a stoca o intrebare</param>
        /// <returns>True daca s-a reusit inserarea, false daca nu s-a reusit</returns>
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

        /// <summary>
        /// Clasa pentru a actualiza o intrebare
        /// </summary>
        /// <param name="id">ID-ul intrebarii</param>
        /// <param name="question">Clasa cu intrebarea stocata</param>
        /// <returns>True daca s-a reusit actualizarea, false daca nu s-a reusit</returns>
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

        /// <summary>
        /// Clasa pentru a sterge o intrebare
        /// </summary>
        /// <param name="id">ID-ul intrebarii</param>
        /// <returns>True daca s-a reusit stergerea, false daca nu s-a reusit</returns>
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

        public bool RegisterAttempt(int userId, string quizType, int correct, int wrong)
        {
            ConnectToDatabase();
            try
            {
                SQLiteCommand cmd;
                cmd = _sqlConn.CreateCommand();
                String sql;

                sql = $"INSERT INTO Attempts(user_id,quiz_type,attempt_date, correct_answers, wrong_answers) VALUES ({userId},'{quizType}', '{DateTime.Now.ToString("g")}', {correct}, {wrong})";

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

    }
}
