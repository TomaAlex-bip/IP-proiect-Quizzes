namespace Utils.Interfaces
{
    public interface IMainView
    {
        void OpenRegisterForm();

        void OpenLoginForm();

        void OpenUserForm();

        void NotifyLogoutUser();
        void NotifyCantLogoutUser();

        bool NotifyAlreadyLoggedIn();
        //void NotifyLoggedIn();

    }
}
