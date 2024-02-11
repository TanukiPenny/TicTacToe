using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe;

public partial class MainForm : Form
{
    // 2d Array that acts as the internal ver of the game board
    private readonly char[,] _board = { { '_', '_', '_' }, { '_', '_', '_' }, { '_', '_', '_' } };
    private char _currentTurn = 'X';
    private string _xWins, _oWins;

    public MainForm(string xWins, string oWins)
    {
        // Take wins from constructor and cache for OnLoad
        _xWins = xWins;
        _oWins = oWins;
        InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
        // Set win count text labels
        xWins.Text = $"X Wins: {_xWins}";
        oWins.Text = $"O Wins: {_oWins}";
    }

    private void GameLoop(Vector2 pos)
    {
        // update internal board
        _board[(int)pos.X, (int)pos.Y] = _currentTurn;
        
        var (someoneWon, winner) = CheckWin();

        if (someoneWon) //What to do with the outcome of the game.
        {
            if (winner == 'D')
            {
                MessageBox.Show($"No one wins, its a draw...", "Draw...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Player {winner} has won!!!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                switch (winner) // update win text for each player
                {
                    case 'X':
                        xWins.Text = $"X Wins: {(int.Parse(xWins.Text.Split(" ").Last()) + 1).ToString()}";
                        break;
                    case 'O':
                        oWins.Text = $"X Wins: {(int.Parse(oWins.Text.Split(" ").Last()) + 1).ToString()}";
                        break;
                }
            }

            DialogResult result = MessageBox.Show($"Would you like to reset and play again? (No will cause the program to close)", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result) //Presents option to replay/end the game.
            {
                case DialogResult.Yes:
                    Restart();
                    return;
                case DialogResult.No:
                    Environment.Exit(0);
                    return;
            }
        }


        switch (_currentTurn) //Switches the turn from player X to player O
        {
            case 'X':
                _currentTurn = 'O';
                TurnLabel.Text = "Turn: O";
                break;
            case 'O':
                _currentTurn = 'X';
                TurnLabel.Text = "Turn: X";
                break;
        }
    }

    private void Restart()
    {
        ProcessStartInfo currentStartInfo = new ProcessStartInfo();
        currentStartInfo.FileName = Application.ExecutablePath;
        // start new app with wins as cmd arguments
        currentStartInfo.Arguments = $"{xWins.Text.Split(" ").Last()} {oWins.Text.Split(" ").Last()}";
        Process.Start(currentStartInfo);
        Environment.Exit(0);
    }

    private (bool, char) CheckWin()
    {
        // check rows
        if (_board[0, 0] == _board[0, 1] && _board[0, 1] == _board[0, 2])
        {
            char winner = _board[0, 0];
            if (winner != '_')
            {
                return (true, winner);
            }
        }

        if (_board[1, 0] == _board[1, 1] && _board[1, 1] == _board[1, 2])
        {
            char winner = _board[1, 0];
            if (winner != '_')
            {
                return (true, winner);
            }
        }

        if (_board[2, 0] == _board[2, 1] && _board[2, 1] == _board[2, 2])
        {
            char winner = _board[2, 0];
            if (winner != '_')
            {
                return (true, winner);
            }
        }

        // check columns
        if (_board[0, 0] == _board[1, 0] && _board[1, 0] == _board[2, 0])
        {
            char winner = _board[0, 0];
            if (winner != '_')
            {
                return (true, winner);
            }
        }

        if (_board[0, 1] == _board[1, 1] && _board[1, 1] == _board[2, 1])
        {
            char winner = _board[0, 1];
            if (winner != '_')
            {
                return (true, winner);
            }
        }

        if (_board[0, 2] == _board[1, 2] && _board[1, 2] == _board[2, 2])
        {
            char winner = _board[0, 2];
            if (winner != '_')
            {
                return (true, winner);
            }
        }

        // check diags
        if (_board[0, 0] == _board[1, 1] && _board[1, 1] == _board[2, 2])
        {
            char winner = _board[0, 0];
            if (winner != '_')
            {
                return (true, winner);
            }
        }

        if (_board[0, 2] == _board[1, 1] && _board[1, 1] == _board[2, 0])
        {
            char winner = _board[0, 2];
            if (winner != '_')
            {
                return (true, winner);
            }
        }

        // check for draw
        bool isDraw = true;
        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (_board[x, y] == '_')
                {
                    isDraw = false;
                }
            }
        }

        return isDraw ? (true, 'D') : (false, '*');
    }
    
    // Methods used to have the player choose a position on the board for their turn.

    private void button_0_0_Click(object sender, EventArgs e)
    {
        if (button_0_0.Text != "_") return;
        button_0_0.Text = _currentTurn.ToString();
        GameLoop(new Vector2(0, 0));
    }

    private void button_1_0_Click(object sender, EventArgs e)
    {
        if (button_1_0.Text != "_") return;
        button_1_0.Text = _currentTurn.ToString();
        GameLoop(new Vector2(1, 0));
    }

    private void button_2_0_Click(object sender, EventArgs e)
    {
        if (button_2_0.Text != "_") return;
        button_2_0.Text = _currentTurn.ToString();
        GameLoop(new Vector2(2, 0));
    }

    private void button_2_1_Click(object sender, EventArgs e)
    {
        if (button_2_1.Text != "_") return;
        button_2_1.Text = _currentTurn.ToString();
        GameLoop(new Vector2(2, 1));
    }

    private void button_0_1_Click(object sender, EventArgs e)
    {
        if (button_0_1.Text != "_") return;
        button_0_1.Text = _currentTurn.ToString();
        GameLoop(new Vector2(0, 1));
    }

    private void button_1_1_Click(object sender, EventArgs e)
    {
        if (button_1_1.Text != "_") return;
        button_1_1.Text = _currentTurn.ToString();
        GameLoop(new Vector2(1, 1));
    }

    private void button_0_2_Click(object sender, EventArgs e)
    {
        if (button_0_2.Text != "_") return;
        button_0_2.Text = _currentTurn.ToString();
        GameLoop(new Vector2(0, 2));
    }

    private void button_1_2_Click(object sender, EventArgs e)
    {
        if (button_1_2.Text != "_") return;
        button_1_2.Text = _currentTurn.ToString();
        GameLoop(new Vector2(1, 2));
    }

    private void button_2_2_Click(object sender, EventArgs e)
    {
        if (button_2_2.Text != "_") return;
        button_2_2.Text = _currentTurn.ToString();
        GameLoop(new Vector2(2, 2));
    }
}