using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Quiz
    {
        public int QuestionsNumber { get; private set; }
        public List<Question> Questions { get; private set; }
        public Attempt QuizAttempt { get; private set; }

        public Quiz(int questionsNumber)
        {
            QuestionsNumber = questionsNumber;
        }
    }
}
