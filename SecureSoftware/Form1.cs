namespace SecureSoftware
{
    public partial class Email1 : Form
    {
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
                    ListItem panel = new ListItem();
                    panel.AccountEmailProp = "Poop";
                    panel.AccountNameProp = "peepee";

                    TextBox textBox = new TextBox();
                    textBox.Size = new Size(panelSizeX, panelSizeY);
                    textBox.TextAlign = HorizontalAlignment.Center;
                    textBox.Text = $"{i * gridSize + j}"; // Set the text to the index

                    panel.Controls.Add(textBox);

                    flowLayoutPanel1.Controls.Add(panel);
                }
            }
        }
    }
}
