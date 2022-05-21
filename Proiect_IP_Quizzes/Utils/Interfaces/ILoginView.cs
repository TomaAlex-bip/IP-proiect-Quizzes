namespace Utils.Interfaces
{
    public interface ILoginView
    {
        void LoginFailed(string username);

        void LoginSucceeded(string username);
    }
}
