using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Attempt
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public string Date { get; private set; }
        public int CorrectAnswers { get; private set; }
        public int WrongAnswers { get; private set; }
        public string QuizType { get; private set; }

        public Attempt(int id, int userId, string date, int correctAnswers, int wrongAnswers, string type)
        {
            Id = id;
            UserId = userId;
            Date = date;
            CorrectAnswers = correctAnswers;
            WrongAnswers = wrongAnswers;
            QuizType = type;
        }

        public override string ToString()
        {
            return $"{Date} - {QuizType} - {CorrectAnswers}/{CorrectAnswers + WrongAnswers}";
        }
    }
}
