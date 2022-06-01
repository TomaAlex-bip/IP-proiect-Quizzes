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
        public int CorrectAnswers => _correctAnswers;

        public Question FirstQuestion => _quizQuestions[0];

        private List<Question> _quizQuestions;

        private int _correctAnswers;

        

        public QuizModel()
        {
            _quizQuestions = new List<Question>();
            _correctAnswers = 0;
        }

        public void GenerateRandomQuiz(string type, int size)
        {
            TotalQuestions = size;
            FinishedQuestions = 0;
            _quizQuestions.Clear();

            List<Question> totalQuestions = DatabaseContext.Instance.GetQuestionsOfType(type);

            var random = new Random();

            for (int i = 0; i < size; i++)
            {
                var randomIndex = random.Next(0, totalQuestions.Count);
                var q = totalQuestions[randomIndex];
                _quizQuestions.Add(q);
            }
        }

        public Question GetNextQuestion()
        {
            if(FinishedQuestions < TotalQuestions-1)
            {
                FinishedQuestions++;
                return _quizQuestions[FinishedQuestions];
            }

            return null;
        }

        public void VerifyQuestionAnswer(int answer)
        {
            if (_quizQuestions[FinishedQuestions].CorrectAnswer == answer)
            {
                _correctAnswers++;
            }
        }

    }
}
