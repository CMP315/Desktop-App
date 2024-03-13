using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace SecureSoftware.Forms.Password_Generator
{
    public partial class PassphraseGenerator : UserControl
    {
        public PassphraseGenerator()
        {
            InitializeComponent();
            this.UpdatePasswordBox();
        }

        private void UpdatePasswordBox()
        {
            GeneratedPasswordTextBox.Text = GeneratePassphrase(PassphraseLengthTrackBar.Value);
            return;
        }
        private void UpdatePasswordBox(object sender, EventArgs e)
        {
            this.UpdatePasswordBox();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.UpdatePasswordBox(sender, e);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GeneratedPasswordTextBox.Text);
        }

        private void PassphraseLengthTrackBar_Scroll(object sender, EventArgs e)
        {
            if (PassphraseLengthTrackBar.Value > 1)
            {
                label3.Text = $"{PassphraseLengthTrackBar.Value} words";
            }
            else
            {
                label3.Text = $"{PassphraseLengthTrackBar.Value} word";
            }
            this.UpdatePasswordBox(sender, e);
        }

        static string GeneratePassphrase(int length)
        {
            string[] wordList = File.ReadAllLines("wordlist.txt");
            Random rand = new();
            return string.Join(" ", Enumerable.Range(0, length)
                .Select(_ => wordList[rand.Next(wordList.Length)]));
        }
    }
}
