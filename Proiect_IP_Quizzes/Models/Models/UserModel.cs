using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Persistence;

namespace Models
{
    public class UserModel
    {
        private Statistic _userStatistic;
        private List<Attempt> _userAttempts;
        private bool quizAttempted;


        public UserModel()
        {
            _userAttempts = new List<Attempt>();
            quizAttempted = false;
        }

        public Statistic GetUserStatistics(int userId)
        {
            if(quizAttempted)
            {
                _userStatistic = DatabaseContext.Instance.GetUserStatistics(userId);
                quizAttempted = false;
            }
            
            return _userStatistic;
        }

        public List<Attempt> GetUserAttempts(int userId)
        {
            if(quizAttempted)
            {
                _userAttempts = DatabaseContext.Instance.GetUserAttempts(userId);
                quizAttempted = false;
            }

            return _userAttempts;
        }

        public List<string> GetQuestionTypes()
        {
            return DatabaseContext.Instance.GetQuestionsType();
        }
    }
}
