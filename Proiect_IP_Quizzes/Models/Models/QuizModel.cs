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

        private int _correctAnswers;
        private int _wrongAnswers;

        public QuizModel()
        {
            _quizQuestions = new List<Question>();
            _correctAnswers = 0;
            _wrongAnswers = 0;
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

        public void VerifyQuestionAnswer(int answer)
        {
            if (_quizQuestions[FinishedQuestions].CorrectAnswer == answer)
            {
                _correctAnswers++;
            }
            else
            {
                _wrongAnswers++;
            }
        }

    }
}
