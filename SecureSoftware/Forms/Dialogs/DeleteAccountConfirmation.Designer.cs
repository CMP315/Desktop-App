namespace SecureSoftware.Forms
{
    partial class DeleteAccountConfirmation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAccountConfirmation));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            ConfirmDelete = new Button();
            Cancel = new Button();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(100, 48, 122);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(100, 48, 122);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(200, 100);
            label1.TabIndex = 5;
            label1.Text = "PASSMAN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 56);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(100, 48, 122);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(800, 56);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(100, 48, 122);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(800, 56);
            label2.TabIndex = 5;
            label2.Text = "PASSMAN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(ConfirmDelete, 0, 0);
            tableLayoutPanel3.Controls.Add(Cancel, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 279);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(5);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(800, 100);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // ConfirmDelete
            // 
            ConfirmDelete.BackColor = Color.FromArgb(192, 57, 43);
            ConfirmDelete.Dock = DockStyle.Fill;
            ConfirmDelete.FlatAppearance.BorderSize = 0;
            ConfirmDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            ConfirmDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            ConfirmDelete.FlatStyle = FlatStyle.Flat;
            ConfirmDelete.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmDelete.ForeColor = Color.White;
            ConfirmDelete.Location = new Point(5, 5);
            ConfirmDelete.Margin = new Padding(0);
            ConfirmDelete.Name = "ConfirmDelete";
            ConfirmDelete.Size = new Size(395, 90);
            ConfirmDelete.TabIndex = 0;
            ConfirmDelete.Text = "Yes, delete my account!";
            ConfirmDelete.UseVisualStyleBackColor = false;
            ConfirmDelete.Click += ConfirmDelete_Click;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.FromArgb(39, 174, 96);
            Cancel.Dock = DockStyle.Fill;
            Cancel.FlatAppearance.BorderSize = 0;
            Cancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 174, 96);
            Cancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cancel.ForeColor = Color.White;
            Cancel.Location = new Point(400, 5);
            Cancel.Margin = new Padding(0);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(395, 90);
            Cancel.TabIndex = 1;
            Cancel.Text = "No, keep my account!";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(46, 56);
            label3.Name = "label3";
            label3.Size = new Size(730, 37);
            label3.TabIndex = 2;
            label3.Text = "Are you sure you want to delete your account?";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(155, 89, 182);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(12, 91);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 185);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // DeleteAccountConfirmation
            // 
            AcceptButton = ConfirmDelete;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 89, 182);
            CancelButton = Cancel;
            ClientSize = new Size(800, 379);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel1);
            Name = "DeleteAccountConfirmation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteAccountConfirmation";
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ConfirmDelete;
        private Button Cancel;
        private Label label3;
        private RichTextBox richTextBox1;
    }
}