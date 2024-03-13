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
        UserControl control;
        public SelectType()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.control = DefaultGenerator;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StandardGeneratorButton_Click(object sender, EventArgs e)
        { 
            if(!this.control.IsDisposed)
            {
                this.control.Dispose();
            }

            StandardGenerator generator = new()
            {
                Parent = MainPanel,
                Dock = DockStyle.Fill
            };
            this.control = generator;
        }

        private void PassphraseGeneratorButton_Click(object sender, EventArgs e)
        {
            if (!this.control.IsDisposed)
            {
                this.control.Dispose();
            }

            PassphraseGenerator generator = new()
            {
                Parent = MainPanel,
                Dock = DockStyle.Fill
            };
            this.control = generator;
        }
    }
}
