using Entities;

namespace Utils.Interfaces
{
    public interface IQuizView
    {
        void LoadQuestion(Question question);

        void UpdateQuestionIndex(int currentIndex, int totalQuestions);

        void ShowQuizResults(int correntAnswers, int totalQuestions);

    }
}
