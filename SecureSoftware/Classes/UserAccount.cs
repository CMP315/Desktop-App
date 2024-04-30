using MongoDB.Bson.Serialization;
using System.Windows.Media.Animation;

namespace SecureSoftware.Classes
{
    public class UserAccount
    {
        public string _id { get; set; }
        public string user_id { get; set; }
        public string username { get; set; }
        public string? created_at { get; set; }
        public string? password { get; set; }
        public string? last_edited_at { get; set; }
        public string? site_name { get; set; }
        public string? notes { get; set; }

        #region Constructors
        public UserAccount(
            string _id,
            string user_id,
            string username
        )
        {
            this._id = _id;
            this.user_id = user_id;
            this.username = username;
        }
        public UserAccount(
            string _id,
            string user_id,
            string username,
            string created_at
        )
        {
            this._id = _id;
            this.user_id = user_id;
            this.username = username;
            this.created_at = created_at;
        }
        public UserAccount(
            string _id,
            string user_id,
            string username,
            string created_at,
            string password,
            string last_edited_at
        )
        {
            this._id = _id;
            this.user_id = user_id;
            this.username = username;
            this.created_at = created_at;
            this.password = password;
            this.last_edited_at = last_edited_at;
        }
        public UserAccount(
            string _id,
            string user_id,
            string username,
            string created_at,
            string password,
            string last_edited_at,
            string site_name
        )
        {
            this._id = _id;
            this.user_id = user_id;
            this.username = username;
            this.created_at = created_at;
            this.password = password;
            this.last_edited_at = last_edited_at;
            this.site_name = site_name;
        }
        public UserAccount(
            string _id,
            string user_id,
            string username,
            string created_at,
            string password,
            string last_edited_at,
            string site_name,
            string notes
        )
        {
            this._id = _id;
            this.user_id = user_id;
            this.username = username;
            this.created_at = created_at;
            this.password = password;
            this.last_edited_at = last_edited_at;
            this.site_name = site_name;
            this.notes = notes;
        }
        #endregion

        async public Task<UserAccount>? Get(string key)
        {
            string apiUrl = $"{Globals.API_BASE_URL}/passwords/{this.user_id}/{this._id}";
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", key);

            try
            {
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    try
                    {
                        UserAccount? account = BsonSerializer.Deserialize<UserAccount>(jsonString);
                        if (account is not null)
                        {
                            return account;
                        }                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
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
            return null!;
        }

        async public Task<bool> Delete(string key)
        {
            string apiUrl = $"{Globals.API_BASE_URL}/passwords/{this.user_id}/{_id}";

            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", key);

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
