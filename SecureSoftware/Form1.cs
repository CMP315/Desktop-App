using System.Drawing.Text;

namespace SecureSoftware
{
    public partial class Email1 : Form
    {

        MasterAccount User = new MasterAccount("TestUser123", "$2b$12$Hqutbzot.cElHf3MQdNiP.5a7naCEYAb5h8oPEBSP1ygU2pP28xeC", "abc@test.com", "b'$2b$12$Hqutbzot.cElHf3MQdNiP.'", "2024-02-28T20:47:22.918+00:00");
        public Email1()
        {
            InitializeComponent();
            CreatePanels();
            this.Width = 1400;
            this.Height = 900;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginDetail.Text = ("Logged in As : " + User.Name);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void CreatePanels()
        {
            const int panelSizeX = 1000;
            const int panelSizeY = 200;
            const int gridSize = 10; // 10x10 grid

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    string id = $"{(i * gridSize + j) + 1}";
                    ListItem panel = new ListItem();
                    panel.AccountEmailProp = "Poop";
                    panel.AccountNameProp = "peepee";
                    panel.IDProp = id;


                    TextBox textBox = new TextBox();
                    textBox.Size = new Size(panelSizeX, panelSizeY);
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.Text = id; // Set the text to the index

                    panel.Controls.Add(textBox);

                    flowLayoutPanel1.Controls.Add(panel);
                }
            }
        }
    }
}
