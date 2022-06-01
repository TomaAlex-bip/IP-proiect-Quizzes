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


        public UserModel()
        {
            _userAttempts = new List<Attempt>();
        }

        public Statistic GetUserStatistics(int userId)
        {
            _userStatistic = DatabaseContext.Instance.GetUserStatistics(userId);
            return _userStatistic;
        }

        public List<Attempt> GetUserAttempts(int userId)
        {
            _userAttempts = DatabaseContext.Instance.GetUserAttempts(userId);
            return _userAttempts;
        }

        public List<string> GetQuestionTypes()
        {
            return DatabaseContext.Instance.GetQuestionsType();
        }
    }
}
