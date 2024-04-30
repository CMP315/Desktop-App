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

        #region Constructors
        public PromptDeletion(string label)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            this._label = label;
            this._continueButtonLabel = "Yes, continue!";
            this._cancelButtonLabel = "No, go back!";

            EditableLabel.Text = this._label;
            ContinueButton.Text = this._continueButtonLabel;
            CancelButton.Text = this._cancelButtonLabel;
        }
        public PromptDeletion(string label, string continueButtonLabel)
        {
            (new Core.DropShadow()).ApplyShadows(this);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            this._label = label;
            this._continueButtonLabel = continueButtonLabel;
            this._cancelButtonLabel = "No, go back!";

            EditableLabel.Text = this._label;
            ContinueButton.Text = this._continueButtonLabel;
            CancelButton.Text = this._cancelButtonLabel;
        }
        public PromptDeletion(string label, string continueButtonLabel, string cancelButtonLabel)
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
        #endregion

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
