using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureSoftware
{
    public partial class PasswordGenerator : Form
    {
        private RNGCryptoServiceProvider rng;
        private Random random;
        public PasswordGenerator()
        {
            InitializeComponent();
            rng = new RNGCryptoServiceProvider();
            random = new Random();


        }


        private void PasswordGenerator_Load(object sender, EventArgs e)
        {

        }

        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable the Generate button during the operation
                GenerateButton.Enabled = false;

                int numberOfWords = 4; // Adjust the number of words in the passphrase
                string[] wordList = await GenerateWordList();
                int minCharLength = int.Parse(MinLengthBox.Text); 
                int maxCharLength = int.Parse(MaxLengthBox.Text); 
                string generatedPassphrase = GeneratePassphrase(wordList, numberOfWords, minCharLength, maxCharLength);

                PassOutBox.Text = generatedPassphrase;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Enable the Generate button after the operation
                GenerateButton.Enabled = true;
            }
        }

        private async Task<string[]> GenerateWordList()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "https://random-word-api.herokuapp.com/all"; // Adjust the max parameter as needed
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return ParseWordList(responseBody);
                }
                else
                {
                    throw new HttpRequestException($"Failed to retrieve word list. Status code: {response.StatusCode}");
                }
            }
        }

        private string[] ParseWordList(string responseBody)
        {
            string[] words = responseBody.Trim('[', ']').Split(',');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim('"');
            }
            return words;
        }

        private string GeneratePassphrase(string[] wordList, int numberOfWords, int minCharLength, int maxCharLength)
        {
            // Parse values from text boxes
            if (!int.TryParse(MinLengthBox.Text, out int minPassphraseLength) || !int.TryParse(MaxLengthBox.Text, out int maxPassphraseLength))
            {
                // Handle parsing errors, e.g., show a message to the user
                MessageBox.Show("Invalid minimum or maximum length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            StringBuilder passphrase = new StringBuilder();

            // Validate minimum and maximum lengths
            if (minPassphraseLength < 0 || maxPassphraseLength <= 0 || minPassphraseLength > maxPassphraseLength)
            {
                // Handle invalid length range, e.g., show a message to the user
                MessageBox.Show("Invalid minimum or maximum length range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            if (wordList.Length == 0)
            {
                MessageBox.Show("Word list is empty. Unable to generate passphrase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }

            for (int i = 0; i < numberOfWords; i++)
            {
                byte[] indexBytes = new byte[1];
                rng.GetBytes(indexBytes);
                int index = Math.Abs(indexBytes[0]) % wordList.Length; // Use Math.Abs to handle negative values
                string word = wordList[index];

                // Ensure the word length is within the specified range
                word = AdjustWordLength(word, minCharLength, maxCharLength);

                // Add special characters and replace with numbers as needed
                word = AddSpecialCharacters(word);
                word = ReplaceWithNumbers(word);

                // Check if adding the current word exceeds the maximum passphrase length
                if (passphrase.Length + word.Length > maxPassphraseLength)
                {
                    // Trim the word to fit within the remaining space
                    int remainingSpace = maxPassphraseLength - passphrase.Length;
                    word = word.Substring(0, remainingSpace);
                }

                if (i > 0)
                {
                    passphrase.Append(" "); // Add space between words
                }

                passphrase.Append(word);
            }

            return passphrase.ToString();
        }

        private string AdjustWordLength(string word, int minCharLength, int maxCharLength)
        {
            int lengthDifference = minCharLength - word.Length;

            if (lengthDifference > 0)
            {
                // Append random characters to meet the minimum length
                word += new string(Enumerable.Repeat('a', lengthDifference)
                                            .Select(_ => (char)random.Next('a', 'z' + 1))
                                            .ToArray());
            }

            // Trim the word if it exceeds the maximum length
            if (word.Length > maxCharLength)
            {
                word = word.Substring(0, maxCharLength);
            }

            return word;
        }

        private string AddSpecialCharacters(string word)
        {
            const string specialChars = "!@#$%^&*()-_=+";

            // Insert special character at the end of the word
            int position = word.Length;
            char specialChar = specialChars[random.Next(specialChars.Length)];

            return word.Insert(position, specialChar.ToString());
        }

        private string ReplaceWithNumbers(string word)
        {
            const double substitutionProbability = 0.3; // Adjust the probability as needed

            Dictionary<char, char> numberToLetterMapping = new Dictionary<char, char>
    {
        { '3', 'e' },
        { '4', 'a' },
        { '5', 's' },
        { '1', 'i' },
        { '0', 'o' }
        // Add more mappings as needed
    };

            StringBuilder modifiedWord = new StringBuilder(word);

            for (int i = 0; i < modifiedWord.Length; i++)
            {
                char currentChar = modifiedWord[i];

                if (char.IsDigit(currentChar) && random.NextDouble() < substitutionProbability)
                {
                    if (numberToLetterMapping.TryGetValue(currentChar, out char replacement))
                    {
                        // Ensure the index is within the valid range before replacing
                        if (i < modifiedWord.Length)
                        {
                            // Use Substring to replace the character
                            modifiedWord.Remove(i, 1).Insert(i, replacement);
                        }
                    }
                }
            }

            return modifiedWord.ToString();
        }
    }
}

