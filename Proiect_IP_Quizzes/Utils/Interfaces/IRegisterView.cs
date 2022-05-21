namespace Utils.Interfaces
{
    public interface IRegisterView
    {
        void RegisterFailed(string user);

        void RegisterSucceeded(string user);
    }
}
