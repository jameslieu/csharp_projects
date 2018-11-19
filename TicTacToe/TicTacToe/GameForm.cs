using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameForm : Form
    {
        bool turn = true; // true = X's turn, false = Y's turn
        int turnCount = 0;

        public GameForm()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startNewGame();
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerOneWinCount.Text = "0";
            DrawCount.Text = "0";
            PlayerTwoWinCount.Text = "0";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By James Lieu", "About");
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (turn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }

            turn = !turn;

            button.Enabled = false;
            turnCount++;
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool winner = false;

            if (
                // Horizontal checks
                isWinningCombination(A1, A2, A3) ||
                isWinningCombination(B1, B2, B3) ||
                isWinningCombination(C1, C2, C3) ||

                // Vertical checks
                isWinningCombination(A1, B1, C1) ||
                isWinningCombination(A2, B2, C2) ||
                isWinningCombination(A3, B3, C3) ||

                // Diagonal checks
                isWinningCombination(A1, B2, C3) ||
                isWinningCombination(A3, B2, C1)
            )
            {
                winner = true;
            }

            // Check for winner
            if (winner)
            {
                announceWinner();
                startNewGame();
            }
            else
            {
                if (turnCount == 9)
                {
                    announceDraw();
                    startNewGame();
                }
            }
        }

        private bool isWinningCombination(Button button1, Button button2, Button button3)
        {
            return (button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled);
        }


        private void announceWinner()
        {
            disableButtons();

            String winningPlayer = "";
            if (turn)
            {
                winningPlayer = p2.Text;
                PlayerTwoWinCount.Text = (Int32.Parse(PlayerTwoWinCount.Text) + 1).ToString();
            }
            else
            {
                winningPlayer = p1.Text;
                PlayerOneWinCount.Text = (Int32.Parse(PlayerOneWinCount.Text) + 1).ToString();
            }

            MessageBox.Show(winningPlayer + " wins!", "Game over");
        }

        private void announceDraw()
        {
            DrawCount.Text = (Int32.Parse(DrawCount.Text) + 1).ToString();
            MessageBox.Show("Draw!", "Game over");
        }

        private void startNewGame()
        {
            turn = true;
            turnCount = 0;
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button button = (Button)control;
                    button.Enabled = true;
                    button.Text = "";
                }
            }
        }

        private void disableButtons()
        {
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button button = (Button)control;
                    button.Enabled = false;

                }
            }
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                if (turn)
                {
                    button.Text = "X";
                }
                else
                {
                    button.Text = "O";
                }
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.Text = "";
            }
        }
    }
}
