using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureSoftware.Forms.Dialogs
{
    public partial class PromptDeletion : Form
    {
        private readonly string _label;
        private readonly string _continueButtonLabel;
        private readonly string _cancelButtonLabel;

        public PromptDeletion(string label, string continueButtonLabel = "Yes, continue!", string cancelButtonLabel = "No, go back!")
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            
            this._label = label;
            this._continueButtonLabel = continueButtonLabel;
            this._cancelButtonLabel = cancelButtonLabel;

            EditableLabel.Text = this._label;
            ContinueButton.Text = this._continueButtonLabel;
            CancelButton.Text = this._cancelButtonLabel;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
