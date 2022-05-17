using Entities;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AdminModel
    {
        public AdminModel()
        {

        }

        public List<Question> GetAllQuestions() => DatabaseContext.Instance.GetAllQuestions();

        public bool AddQuestion(Question question) => DatabaseContext.Instance.AddQuestion(question);

        public bool UpdateQuestion(int id, Question question) => DatabaseContext.Instance.UpdateQuestion(id, question);

        public bool DeleteQuestion(int id) => DatabaseContext.Instance.DeleteQuestion(id);


    }
}
