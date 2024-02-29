using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SecureSoftware
{
    public class MasterAccount
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public string CreatedAt { get; set; }



        public MasterAccount(string name, string password, string email, string salt, string createdat)
        {
            Name = name;
            Password = password;
            Email = email;
            Salt = salt;
            CreatedAt = createdat;
        }
        

        private async void GetAccountsAsync()
        {
            string apiUrl = "http://localhost:80/api/get-account";

            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                        Console.WriteLine(await response.Content.ReadAsStringAsync());
                    else
                        Console.WriteLine($"Error: {response.StatusCode}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }
    }
}
