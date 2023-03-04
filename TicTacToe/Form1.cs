using System.ComponentModel;
using System.Data.SqlTypes;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = X , false = O
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void abuotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac toe rules: ", "Rules");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            checkWinner();
        }

        private void checkWinner()
        {
            bool winner = false;
            // horizontal check
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && !A1.Enabled) winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && !B1.Enabled) winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && !C1.Enabled) winner = true;

            // vertical check
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && !A1.Enabled) winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && !A2.Enabled) winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && !A3.Enabled) winner = true;

            // diagonol check
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && !A1.Enabled) winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && !A3.Enabled) winner = true;

            if (winner)
            {
                disableButtons();
                String whoWon = "";
                if (turn) whoWon = "O";
                else whoWon = "X";
                MessageBox.Show("Winner is : " + whoWon, "Winner!");
            }
            else
            {
                if (turnCount == 9)
                    MessageBox.Show("Draw", "Draw");
            }

        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }
    }
}