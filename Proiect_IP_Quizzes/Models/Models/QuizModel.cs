using Entities;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class QuizModel
    {
        public int TotalQuestions { get; private set; }
        public int FinishedQuestions { get; private set; }

        private List<Question> _quizQuestions;


        public QuizModel(string type, int size)
        {
            TotalQuestions = size;
            FinishedQuestions = 0;

            _quizQuestions = new List<Question>();

            List<Question> totalQuestions = DatabaseContext.GetInstance.GetQuestionsOfType(type);

            var random = new Random();

            for (int i = 0; i < size; i++)
            {
                var randomIndex = random.Next(0, totalQuestions.Count);
                _quizQuestions.Add(totalQuestions[randomIndex]);
            }
        }

        public Question GetNextQuestion()
        {
            if(FinishedQuestions < TotalQuestions)
            {
                FinishedQuestions++;
                return _quizQuestions[FinishedQuestions];
            }

            return null;
        }

        public bool VerifyQuestionAnswer(Question question, int answer)
        {
            if (question.CorrectAnswer == answer)
                return true;
            
            return false;
        }

    }
}
