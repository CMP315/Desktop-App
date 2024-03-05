using SecureSoftware.Classes;
using SecureSoftware.Forms;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace SecureSoftware
{
    internal class Program
    {
        private static LoginOrRegister? loginOrRegister;
        private static Login? loginReturn;
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
                    loginReturn = new Login();
                    loginReturn.ShowDialog();
                    User = loginReturn.user;
                    loginReturn.Dispose();
                }
                else if (loginOrRegister.Selected == "Register")
                {

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