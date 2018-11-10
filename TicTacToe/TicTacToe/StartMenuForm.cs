using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class StartMenuForm : Form
    {
        public StartMenuForm()
        {
            InitializeComponent();
        }

        private void playerOneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // When 'Enter' key is pressed
            if (e.KeyChar.ToString() == "\r")
            {
                playerTwoTextBox.Focus();
            }
        }

        private void playerTwoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // When 'Enter' key is pressed
            if (e.KeyChar.ToString() == "\r")
            {
                playButton.PerformClick();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            GameForm.setPlayerNames(playerOneTextBox.Text, playerTwoTextBox.Text);
            this.Close();
        }
    }
}
