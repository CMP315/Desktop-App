using SecureSoftware.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureSoftware.Components
{
    public partial class UserAccountListItem : UserControl
    {
        private readonly string _user_id;
        public UserAccountListItem(FlowLayoutPanel MainPanel, string user_id)
        {
            InitializeComponent();
            this.Width = MainPanel.Width - 10;
            this._user_id = user_id;
        }

        #region Properties 
        private string _id;
        private FontAwesome.Sharp.IconChar _icon;
        private string _site_name;
        private string _username;

        [Category("Custom Props")]
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public FontAwesome.Sharp.IconChar IconProp
        {
            get { return _icon; }
            set { _icon = value; Icon.IconChar = value; }
        }

        [Category("Custom Props")]
        public string SiteNameProp
        {
            get { return _site_name; }
            set { _site_name = value; SiteName.Text = value; }
        }

        [Category("Custom Props")]
        public string UsernameProp
        {
            get { return _username; }
            set { _username= value; Username.Text = value; }
        }
        #endregion

        private async void ViewButton_Click(object sender, EventArgs e)
        {
            string apiUrl = $"{Globals.API_BASE_URL}/passwords/{_user_id}/{_id}";

            using var httpClient = new HttpClient();
            try
            {
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    try
                    {
                        UserAccount? jsonObject = JsonSerializer.Deserialize<UserAccount>(jsonString);
                        MessageBox.Show(jsonObject.password, $"[{jsonObject.site_name.ToUpper()}] {jsonObject.username}'s password.");

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

            return;
        }
    }
 }
