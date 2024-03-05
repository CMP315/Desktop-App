using SecureSoftware.Classes;
using SecureSoftware.Forms;
using System.Runtime.CompilerServices;

namespace SecureSoftware
{
    internal static class Program
    {
        private static LoginOrRegister? loginOrRegister;
        private static Login? loginReturn;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            loginOrRegister = new LoginOrRegister();
            loginOrRegister.ShowDialog();
            if (loginOrRegister == null) return;
            if(loginOrRegister.Selected == "Login")
            {
                loginReturn = new Login();
                loginReturn.ShowDialog();
                if (loginReturn.user is not null)
                {
                    PasswordVault vault = new(loginReturn.user);
                    vault.ShowDialog();
                    vault.Close();
                }
                loginReturn.Close();
            }
            else if (loginOrRegister.Selected == "Register")
            {

            }
        }
    }
}