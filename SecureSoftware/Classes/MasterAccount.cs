using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SecureSoftware.Classes
{
    public class MasterAccount
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public string CreatedAt { get; set; }



        public MasterAccount(string id, string name, string password, string email, string salt, string createdat)
        {
            ID = id;
            Name = name;
            Password = password;
            Email = email;
            Salt = salt;
            CreatedAt = createdat;
        }

        public async Task<UserAccount[]?> GetAccountsAsync()
        {
            string apiUrl = $"{Globals.API_BASE_URL}/passwords/{ID}";

            using var httpClient = new HttpClient();
            try
            {
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    try
                    {
                        UserAccount[]? jsonObject = JsonSerializer.Deserialize<UserAccount[]>(jsonString);
                        if (jsonObject is not null)
                        {
                            return jsonObject;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    Console.WriteLine(await response.Content.ReadAsStringAsync());
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode}");
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            return null;
        }
    }
}
