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
    public class PasswordGenerator : Form
    {
        private readonly RandomNumberGenerator RandomGenerator;
        private readonly HashSet<string> CharacterList;

        private readonly string UPPERCASE = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
        private readonly string LOWERCASE = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
        private readonly string DIGITS = "0,1,2,3,4,5,6,7,8,9,0";
        private readonly string SYMBOLS = "!,\\,\",£,$,%,^,&,*,(,),_,+,=,-,[,],',#,<,>,/,?,¬,`,{,}";
        private readonly string RANDOM_UNICODE_CHARACTERS = "";


        public PasswordGenerator()
        {
            InitializeComponent();
            RandomGenerator = RandomNumberGenerator.Create();
            CharacterList = new HashSet<string>();
        }

        private void UpdatePasswordBox(object sender, EventArgs e)
        {
            if (CharacterList.Count == 0)
            {
                GeneratedPasswordTextBox.Text = "";
                return;
            }
            GeneratedPasswordTextBox.Text = CreatePassword(PasswordLengthTrackBar.Value);
        }

        private void PasswordLengthTrackBar_Scroll(object sender, EventArgs e)
        {
            if (PasswordLengthTrackBar.Value > 0)
            {
                label3.Text = $"{PasswordLengthTrackBar.Value} characters";
            }
            else
            {
                label3.Text = $"{PasswordLengthTrackBar.Value} character";
            }
            this.UpdatePasswordBox(sender, e);
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            CharacterList.Add(this.UPPERCASE);
            CharacterList.Add(this.LOWERCASE);
            CharacterList.Add(this.DIGITS);
            CharacterList.Add(this.SYMBOLS);
            this.UpdatePasswordBox(sender, e);
        }

        //private static string GetEmojiSet(int lowerEmojiRange, int upperEmojiRange)
        //{
        //    int range = upperEmojiRange - lowerEmojiRange;
        //    string[] Characters = new string[(upperEmojiRange + 1) + (range - 1)];
        //    for (int i = lowerEmojiRange; i <= upperEmojiRange; i++)
        //    {
        //        string emoji = char.ConvertFromUtf32(i);
        //        Characters[i] = emoji;
        //    }
        //    return string.Join(",", Characters);
        //}

        private string CreatePassword(int length)
        {
            Random random = new();
            StringBuilder password = new();
            for (int i = 0; i < length; i++)
            {
                string charSet = CharacterList.ElementAt(RandomNumberGenerator.GetInt32(CharacterList.Count));
                string[] characters = charSet.Split(',');
                password.Append(characters[random.Next(characters.Length - 1)]);
            }

            return password.ToString();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.UpdatePasswordBox(sender, e);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GeneratedPasswordTextBox.Text);
        }

        private void UppercaseCheckbox_Click(object sender, EventArgs e)
        {
            if (UppercaseCheckbox.Checked)
            {
                CharacterList.Add(this.UPPERCASE);
            }
            else
            {
                CharacterList.Remove(this.UPPERCASE);
            }
            this.UpdatePasswordBox(sender, e);
        }

        private void LowercaseCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (LowercaseCheckbox.Checked)
            {
                CharacterList.Add(this.LOWERCASE);
            }
            else
            {
                CharacterList.Remove(this.LOWERCASE);
            }
            this.UpdatePasswordBox(sender, e);
        }

        private void DigitsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (DigitsCheckbox.Checked)
            {
                CharacterList.Add(this.DIGITS);
            }
            else
            {
                CharacterList.Remove(this.DIGITS);
            }
            this.UpdatePasswordBox(sender, e);
        }

        private void SymbolsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (SymbolsCheckbox.Checked)
            {
                CharacterList.Add(this.SYMBOLS);
            }
            else
            {
                CharacterList.Remove(this.SYMBOLS);
            }
            this.UpdatePasswordBox(sender, e);
        }

        private void PasswordVisibilityButton_Click(object sender, EventArgs e)
        {
            if(this.PasswordVisibilityButton.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                PasswordVisibilityButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                GeneratedPasswordTextBox.UseSystemPasswordChar = false;
            } else
            {
                PasswordVisibilityButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
                GeneratedPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}

