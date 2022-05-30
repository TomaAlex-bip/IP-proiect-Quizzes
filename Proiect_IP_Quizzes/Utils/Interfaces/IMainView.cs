namespace Utils.Interfaces
{
    public interface IMainView
    {
        void OpenRegisterForm();

        void OpenLoginForm();

        void OpenUserForm();

        void OpenAdminForm();

        void NotifyLogoutUser();

        void NotifyNotLoggedIn();

        void NotifyAlreadyLoggedIn();

        void NotifyRestrictedPermission();

        void OpenQuizForm(string type, int size);

    }
}
