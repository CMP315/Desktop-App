using MongoDB.Bson.Serialization;

namespace SecureSoftware.Classes
{
    public class MasterAccount
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string image {  get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string salt { get; set; }
        public DateTime created_at { get; set; }



        public MasterAccount(string _id, string name, string image, string email, string password, string salt, DateTime created_at)
        {
            if (string.IsNullOrEmpty(_id))
            {
                throw new ArgumentException($"'{nameof(_id)}' cannot be null or empty.", nameof(_id));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
            }

            if (string.IsNullOrEmpty(image)) {
                throw new ArgumentException($"'{nameof(image)}' cannot be null or empty.", nameof(image));
            }

            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException($"'{nameof(email)}' cannot be null or empty.", nameof(email));
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException($"'{nameof(password)}' cannot be null or empty.", nameof(password));
            }

            this._id = _id;
            this.name = name;
            this.image = image;
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
                        UserAccount[]? jsonObject = BsonSerializer.Deserialize<UserAccount[]>(jsonString);
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

        public async Task<bool> DeleteAccountsAsync()
        {
            string apiUrl = $"{Globals.API_BASE_URL}/passwords/{_id}";

            using var httpClient = new HttpClient();
            try
            {
                var response = await httpClient.DeleteAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    return true;
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

            return false;
        }

        public async Task<Note[]?> GetNotesAsync()
        {
            string apiUrl = $"{Globals.API_BASE_URL}/notes/{_id}";

            using var httpClient = new HttpClient();
            try
            {
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    try
                    {
                        Note[]? jsonObject = BsonSerializer.Deserialize<Note[]>(jsonString);
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

        public async Task<bool> DeleteNotesAsync()
        {
            string apiUrl = $"{Globals.API_BASE_URL}/notes/{_id}";

            using var httpClient = new HttpClient();
            try
            {
                var response = await httpClient.DeleteAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    return true;
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

            return false;
        }
    }
}
