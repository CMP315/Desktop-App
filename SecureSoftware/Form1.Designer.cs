namespace SecureSoftware
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1322, 80);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrchid;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(0, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 770);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Location = new Point(1018, 128);
            button1.Name = "button1";
            button1.Size = new Size(122, 52);
            button1.TabIndex = 2;
            button1.Text = "View Password";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LawnGreen;
            button2.Location = new Point(1178, 128);
            button2.Name = "button2";
            button2.Size = new Size(122, 52);
            button2.TabIndex = 3;
            button2.Text = "Edit Password";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(314, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 63);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(86, 19);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 5;
            label1.Text = "Logged in as ......";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 29);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 5;
            label2.Text = "Password Vault";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(421, 106);
            label3.Name = "label3";
            label3.Size = new Size(84, 30);
            label3.TabIndex = 5;
            label3.Text = "GitHub";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 836);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
