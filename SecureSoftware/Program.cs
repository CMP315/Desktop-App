using SecureSoftware.Classes;
using SecureSoftware.Forms;

namespace SecureSoftware
{
    internal class Program
    {
        private static LoginOrRegister? loginOrRegister;
        private static Login? login;
        private static Register? register;
        private static MasterAccount? User;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        while(User is null)
            {
                loginOrRegister = new LoginOrRegister();
                loginOrRegister.ShowDialog();
                loginOrRegister.Dispose();
                if (loginOrRegister.Selected == "Login")
                {
                    login = new Login();
                    login.ShowDialog();
                    User = login.user;
                    login.Dispose();
                }
                else if (loginOrRegister.Selected == "Register")
                {
                    register = new Register();
                    register.ShowDialog();
                    User = register.user;
                    register.Dispose();
                }

                if (User is not null)
                {
                    PasswordVault vault = new(User);
                    vault.ShowDialog();
                    vault.Dispose();
                    User = null;
                }
            }
        }

    }
}