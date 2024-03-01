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
        public string _id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string salt { get; set; }
        public string created_at { get; set; }



        public MasterAccount(string _id, string name, string email, string password = "", string salt = "", string created_at = "")
        {
            this._id = _id;
            this.name = name;
            this.password = password;
            this.email = email;
            this.salt = salt;
            this.created_at = created_at;
        }

        public async Task<UserAccount[]?> GetAccountsAsync()
        {
            string apiUrl = $"{Globals.API_BASE_URL}/passwords/{_id}";

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
