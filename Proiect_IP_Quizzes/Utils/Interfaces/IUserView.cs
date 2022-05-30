using System.Collections.Generic;

namespace Utils.Interfaces
{
    public interface IUserView
    {
        void LoadData(int attempted, int passed, int failed, List<string> history, List<string> types);
    }
}
