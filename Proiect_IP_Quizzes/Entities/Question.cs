using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Question
    {
        public int Id { get; private set; }
        public string Type { get; private set; }
        public string Text { get; private set; }
        public string Answer1 { get; private set; }
        public string Answer2 { get; private set; }
        public string Answer3 { get; private set; }
        public int CorrectAnswer { get; private set; }

        public Question(int id, string type, string text, string answer1, string answer2, string answer3, int correctAnswer)
        {
            Id = id;
            Type = type;
            Text = text;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            CorrectAnswer = correctAnswer;
        }

    }
}
