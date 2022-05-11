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

        public List<Question> GetAllQuestions() => DatabaseContext.GetInstance.GetAllQuestions();

        public bool AddQuestion(Question question) => DatabaseContext.GetInstance.AddQuestion(question);

        public bool UpdateQuestion(int id, Question question) => DatabaseContext.GetInstance.UpdateQuestion(id, question);

        public bool DeleteQuestion(int id) => DatabaseContext.GetInstance.DeleteQuestion(id);


    }
}
