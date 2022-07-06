using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonHGSSMoveEditor
{
    public partial class userTextInputForm : Form
    {
        public string inputText;

        public userTextInputForm(string formName)
        {
            InitializeComponent();

            this.Text = formName;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            inputText = "";
            this.Visible = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            inputText = userInputTxtBx.Text.Trim();
            this.Visible = false;
        }
    }
}
