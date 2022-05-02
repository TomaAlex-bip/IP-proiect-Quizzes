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
        public Statistic UserStatistic { get; private set; }
        public List<Attempt> UserAttempts { get; private set; }

        private bool quizAttempted;


        public UserModel()
        {
            UserAttempts = new List<Attempt>();
            quizAttempted = false;
        }

        public Statistic GetUserStatistics(int userId)
        {
            if(quizAttempted)
            {
                UserStatistic = DatabaseContext.GetInstance.GetUserStatistics(userId);
                quizAttempted = false;
            }
            
            return UserStatistic;
        }

        public List<Attempt> GetUserAttempts(int userId)
        {
            if(quizAttempted)
            {
                UserAttempts = DatabaseContext.GetInstance.GetUserAttempts(userId);
                quizAttempted = false;
            }

            return UserAttempts;
        }

        public List<string> GetQuestionTypes()
        {
            return DatabaseContext.GetInstance.GetQuestionTypes();
        }
    }
}
