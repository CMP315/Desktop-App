using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureSoftware.Forms.Password_Generator
{
    public partial class SelectType : Form
    {
        public SelectType()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StandardGeneratorButton_Click(object sender, EventArgs e)
        {
            if (!DefaultGenerator.IsDisposed)
            {
                DefaultGenerator.Dispose();
            }

            StandardGenerator _ = new()
            {
                Parent = MainPanel,
                Dock = DockStyle.Fill
            };
        }
    }
}
