using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Game2p : Form
    {
        public string player1 { get; set; }
        public string player2 { get; set; }
        public bool turn { get; set; }
        public int [,] matrix { get; set; }
        public int numGames { get; set; }
        public int played { get; set; }
        public bool ultimateTurn { get; set; }

        public Game2p(string player1, string player2, int numGames)
        {
            InitializeComponent();
            lplayer1.Text = player1;
            lplayer2.Text = player2;
            lplayer1score.Text = 0.ToString();
            lplayer2score.Text = 0.ToString();
            ldraws.Text = 0.ToString();
            this.player1 = player1;
            this.player2 = player2;
            this.numGames = numGames;
            this.turn = true;
            this.matrix = new int[3, 3];
            this.played = 0;
            this.ultimateTurn = false;
            lTotal.Text = String.Format("{0} games left", numGames - played);
            Turn();
        }
        public void Turn()
        {
            
            if (turn)
            {
                pbTurn.Image = Resources.Xmini;
                label1.Text = String.Format("{0}'s turn!", player1);
            }
            else
            {
                pbTurn.Image = Resources.Zeromini;
                label1.Text = String.Format("{0}'s turn!", player2);
            }

        }
        public void Check()
        {
            bool win1 = false;
            bool win2 = false;

            if (matrix[0, 0] == 1 && matrix[0, 1] == 1 && matrix[0, 2] == 1)
                win1 = true;
            if (matrix[1, 0] == 1 && matrix[1, 1] == 1 && matrix[1, 2] == 1)
                win1 = true;
            if (matrix[2, 0] == 1 && matrix[2, 1] == 1 && matrix[2, 2] == 1)
                win1 = true;
            if (matrix[0, 0] == 1 && matrix[1, 0] == 1 && matrix[2, 0] == 1)
                win1 = true;
            if (matrix[0, 1] == 1 && matrix[1, 1] == 1 && matrix[2, 1] == 1)
                win1 = true;
            if (matrix[0, 2] == 1 && matrix[1, 2] == 1 && matrix[2, 2] == 1)
                win1 = true;
            if (matrix[0, 0] == 1 && matrix[1, 1] == 1 && matrix[2, 2] == 1)
                win1 = true;
            if (matrix[0, 2] == 1 && matrix[1, 1] == 1 && matrix[2, 0] == 1)
                win1 = true;

            if (matrix[0, 0] == 2 && matrix[0, 1] == 2 && matrix[0, 2] == 2)
                win2 = true;
            if (matrix[1, 0] == 2 && matrix[1, 1] == 2 && matrix[1, 2] == 2)
                win2 = true;
            if (matrix[2, 0] == 2 && matrix[2, 1] == 2 && matrix[2, 2] == 2)
                win2 = true;
            if (matrix[0, 0] == 2 && matrix[1, 0] == 2 && matrix[2, 0] == 2)
                win2 = true;
            if (matrix[0, 1] == 2 && matrix[1, 1] == 2 && matrix[2, 1] == 2)
                win2 = true;
            if (matrix[0, 2] == 2 && matrix[1, 2] == 2 && matrix[2, 2] == 2)
                win2 = true;
            if (matrix[0, 0] == 2 && matrix[1, 1] == 2 && matrix[2, 2] == 2)
                win2 = true;
            if (matrix[0, 2] == 2 && matrix[1, 1] == 2 && matrix[2, 0] == 2)
                win2 = true;

            if (win1 == true)
            {
                int p1s = int.Parse(lplayer1score.Text);
                p1s++;
                lplayer1score.Text = p1s.ToString();
                DialogResult result = MessageBox.Show(String.Format("{0} wins!!!", player1),
                    "Congratulations!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    pb00.Image = null;
                    pb01.Image = null;
                    pb02.Image = null;
                    pb10.Image = null;
                    pb11.Image = null;
                    pb12.Image = null;
                    pb20.Image = null;
                    pb21.Image = null;
                    pb22.Image = null;
                    played++;

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                    turn = !ultimateTurn;
                    ultimateTurn = !ultimateTurn;
                    lTotal.Text = String.Format("{0} games left", numGames - played);
                    if (played == numGames)
                    {
                        int p1w = int.Parse(lplayer1score.Text);
                        int p2w = int.Parse(lplayer2score.Text);
                        if (p1w > p2w)
                        MessageBox.Show(String.Format("{0} is the ultimate winner", player1),
                   "Congratulations!", MessageBoxButtons.OK);
                        else if (p1w < p2w)
                            MessageBox.Show(String.Format("{0} is the ultimate winner", player2),
                       "Congratulations!", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("It's a draw!",
                   "Draw!", MessageBoxButtons.OK);
                        Close();
                    }
                }
            }
            if (win2 == true)
            {
                int p2s = int.Parse(lplayer2score.Text);
                p2s++;
                lplayer2score.Text = p2s.ToString();
                DialogResult result = MessageBox.Show(String.Format("{0} wins!!!", player2),
                    "Congratulations!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    pb00.Image = null;
                    pb01.Image = null;
                    pb02.Image = null;
                    pb10.Image = null;
                    pb11.Image = null;
                    pb12.Image = null;
                    pb20.Image = null;
                    pb21.Image = null;
                    pb22.Image = null;
                    played++;

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                             matrix[i, j] = 0;   
                        }
                    }
                    turn = !ultimateTurn;
                    ultimateTurn = !ultimateTurn;
                    lTotal.Text = String.Format("{0} games left", numGames - played);
                    if (played == numGames)
                    {
                        int p1w = int.Parse(lplayer1score.Text);
                        int p2w = int.Parse(lplayer2score.Text);
                        if (p1w > p2w)
                            MessageBox.Show(String.Format("{0} is the ultimate winner", player1),
                       "Congratulations!", MessageBoxButtons.OK);
                        else if (p1w < p2w)
                            MessageBox.Show(String.Format("{0} is the ultimate winner", player2),
                       "Congratulations!", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("It's a draw!",
                   "Draw!", MessageBoxButtons.OK);
                        Close();
                    }
                }
            }

            if (!win1 && !win2)
            {
                int c = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (matrix[i, j] == 0)
                            c++;

                    }
                }
                if (c == 0)
                {
                    int ds = int.Parse(ldraws.Text);
                    ds++;
                    ldraws.Text = ds.ToString();
                    DialogResult result = MessageBox.Show("It's a draw!",
                        "Draw!", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        pb00.Image = null;
                        pb01.Image = null;
                        pb02.Image = null;
                        pb10.Image = null;
                        pb11.Image = null;
                        pb12.Image = null;
                        pb20.Image = null;
                        pb21.Image = null;
                        pb22.Image = null;
                        played++;

                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                matrix[i, j] = 0;
                            }
                        }
                        turn = !ultimateTurn;
                        ultimateTurn = !ultimateTurn;
                        lTotal.Text = String.Format("{0} games left", numGames - played);
                        if (played == numGames)
                        {
                            int p1w = int.Parse(lplayer1score.Text);
                            int p2w = int.Parse(lplayer2score.Text);
                            if (p1w > p2w)
                                MessageBox.Show(String.Format("{0} is the ultimate winner", player1),
                           "Congratulations!", MessageBoxButtons.OK);
                            else if (p1w < p2w)
                                MessageBox.Show(String.Format("{0} is the ultimate winner", player2),
                           "Congratulations!", MessageBoxButtons.OK);
                            else
                                MessageBox.Show("It's a draw!",
                       "Draw!", MessageBoxButtons.OK);
                            Close();
                        }
                    }
                }
            }
        }

        private void pb00_Click(object sender, EventArgs e)
        {
            if (matrix[0, 0] == 0)
            {
                if (turn == true)
                {
                    matrix[0, 0] = 1;
                    pb00.Image = Resources.Xmaxi;
                }
                else
                {
                    matrix[0, 0] = 2;
                    pb00.Image = Resources.Zeromaxi;
                }
                Check();
                turn = !turn;
                Turn();
            }
        }

        private void pb01_Click(object sender, EventArgs e)
        {
            if (matrix[0, 1] == 0)
            {
                if (turn == true)
                {
                    matrix[0, 1] = 1;
                    pb01.Image = Resources.Xmaxi;
                }
                else
                {
                    matrix[0, 1] = 2;
                    pb01.Image = Resources.Zeromaxi;
                }
                Check();
                turn = !turn;
                Turn();
            }
        }

        private void pb02_Click(object sender, EventArgs e)
        {
            if (matrix[0, 2] == 0)
            {
                if (turn == true)
                {
                    matrix[0, 2] = 1;
                    pb02.Image = Resources.Xmaxi;
                }
                else
                {
                    matrix[0, 2] = 2;
                    pb02.Image = Resources.Zeromaxi;
                }
                Check();
                turn = !turn;
                Turn();
            }
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            if (matrix[1, 0] == 0)
            {
                if (turn == true)
                {
                    matrix[1, 0] = 1;
                    pb10.Image = Resources.Xmaxi;
                }
                else
                {
                    matrix[1, 0] = 2;
                    pb10.Image = Resources.Zeromaxi;
                }
                Check();
                turn = !turn;
                Turn();
            }
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            if (matrix[1, 1] == 0)
            {
                if (turn == true)
                {
                    matrix[1, 1] = 1;
                    pb11.Image = Resources.Xmaxi;
                }
                else
                {
                    matrix[1, 1] = 2;
                    pb11.Image = Resources.Zeromaxi;
                }
                Check();
                turn = !turn;
                Turn();
            }
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            if (matrix[1, 2] == 0)
            {
                if (turn == true)
                {
                    matrix[1, 2] = 1;
                    pb12.Image = Resources.Xmaxi;
                }
                else
                {
                    matrix[1, 2] = 2;
                    pb12.Image = Resources.Zeromaxi;
                }
                Check();
                turn = !turn;
                Turn();
            }
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            if (matrix[2, 0] == 0)
            {
                if (turn == true)
                {
                    matrix[2, 0] = 1;
                    pb20.Image = Resources.Xmaxi;
                }
                else
                {
                    matrix[2, 0] = 2;
                    pb20.Image = Resources.Zeromaxi;
                }
                Check();
                turn = !turn;
                Turn();
            }
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            if (matrix[2, 1] == 0)
            {
                if (turn == true)
                {
                    matrix[2, 1] = 1;
                    pb21.Image = Resources.Xmaxi;
                }
                else
                {
                    matrix[2, 1] = 2;
                    pb21.Image = Resources.Zeromaxi;
                }
                Check();
                turn = !turn;
                Turn();
            }
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            if (matrix[2, 2] == 0)
            {
                if (turn == true)
                {
                    matrix[2, 2] = 1;
                    pb22.Image = Resources.Xmaxi;
                }
                else
                {
                    matrix[2, 2] = 2;
                    pb22.Image = Resources.Zeromaxi;
                }
                Check();
                turn = !turn;
                Turn();
            }
        }
    }
}
