using Entities;
using System.Collections.Generic;

namespace Utils.Interfaces
{
    public interface IAdminView
    {
        void LoadData(List<Question> questions);

        void NotifyError(string message);

        void NotifySuccess(string message);
    }
}
