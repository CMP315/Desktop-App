using MongoDB.Bson.Serialization;
using System.Windows.Media.Animation;

namespace SecureSoftware.Classes
{
    public class Note
    {
        public string _id { get; set; }
        public string user_id { get; set; }
        public string? name { get; set; }
        public string? note { get; set; }
        public string? created_at { get; set; }
        public string? last_edited_at { get; set; }

        #region Constructors
        public Note(
            string _id,
            string user_id
)
        {
            this._id = _id;
            this.user_id = user_id;
        }
        public Note(
            string _id,
            string user_id,
            string name
)
        {
            this._id = _id;
            this.user_id = user_id;
            this.name = name;
        }
        public Note(
            string _id,
            string user_id,
            string name,
            string note
        )
        {
            this._id = _id;
            this.user_id = user_id;
            this.name = name;
            this.note = note;
        }
        public Note(
            string _id,
            string user_id,
            string name,
            string note,
            string created_at
        )
        {
            this._id = _id;
            this.user_id = user_id;
            this.name = name;
            this.note = note;
            this.created_at = created_at;
        }
        public Note(
            string _id,
            string user_id,
            string name,
            string note,
            string created_at,
            string last_edited_at
        )
        {
            this._id = _id;
            this.user_id = user_id;
            this.name = name;
            this.note = note;
            this.created_at = created_at;
            this.last_edited_at = last_edited_at;
        }
        #endregion

        async public Task<Note>? Get(string key)
        {
            string apiUrl = $"{Globals.API_BASE_URL}/notes/{this.user_id}/{this._id}";
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
                        Note? note = BsonSerializer.Deserialize<Note>(jsonString);
                        if (note is not null)
                        {
                            return note;
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
            string apiUrl = $"{Globals.API_BASE_URL}/notes/{this.user_id}/{_id}";

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
