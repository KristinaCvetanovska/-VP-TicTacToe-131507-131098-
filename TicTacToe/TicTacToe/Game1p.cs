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
    public partial class Game1p : Form
    {
        public string player { get; set; }
        public bool turn { get; set; }
        public int[,] matrix { get; set; }
        public bool done { get; set; }
        public bool once { get; set; }
        public int numGames { get; set; }
        public int played { get; set; }
        public bool ultimateTurn { get; set; }

        public Game1p(string player, int numGames)
        {
            InitializeComponent();
            lPlayer.Text = player;
            lplayerscore.Text = 0.ToString();
            lcomputerscore.Text = 0.ToString();
            ldraws.Text = 0.ToString();
            this.player = player;
            this.numGames = numGames;
            this.turn = true;
            this.matrix = new int[3, 3];
            this.played = 0;
            this.ultimateTurn = false;
            this.done = false;
            this.once = false;
            lTotal.Text = String.Format("{0} games left", numGames - played);
            Turn();
        }

        public void Turn()
        {
            if (turn)
            {
                pbTurn.Image = Resources.Xmini;
                lbTurn.Text = String.Format("{0}'s turn!", player);
            }
            else
            {
                done = false;
                pbTurn.Image = Resources.Zeromini;
                lbTurn.Text = "Computer's turn!";
                ////////////
                if (matrix[0, 0] == 2 && matrix[0, 1] == 2 && matrix[0, 2] == 0)
                {
                    matrix[0, 2] = 2;
                    pb02.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 0] == 2 && matrix[0, 2] == 2 && matrix[0, 1] == 0)
                {
                    matrix[0, 1] = 2;
                    pb01.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 2] == 2 && matrix[0, 1] == 2 && matrix[0, 0] == 0)
                {
                    matrix[0, 0] = 2;
                    pb00.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[1, 0] == 2 && matrix[1, 1] == 2 && matrix[1, 2] == 0)
                {
                    matrix[1, 2] = 2;
                    pb12.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[1, 0] == 2 && matrix[1, 2] == 2 && matrix[1, 1] == 0)
                {
                    matrix[1, 1] = 2;
                    pb11.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[1, 1] == 2 && matrix[1, 2] == 2 && matrix[1, 0] == 0)
                {
                    matrix[1, 0] = 2;
                    pb10.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 0] == 2 && matrix[2, 1] == 2 && matrix[2, 2] == 0)
                {
                    matrix[2, 2] = 2;
                    pb22.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 0] == 2 && matrix[2, 2] == 2 && matrix[2, 1] == 0)
                {
                    matrix[2, 1] = 2;
                    pb21.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 1] == 2 && matrix[2, 2] == 2 && matrix[2, 0] == 0)
                {
                    matrix[2, 0] = 2;
                    pb20.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 0] == 2 && matrix[1, 0] == 2 && matrix[2, 0] == 0)
                {
                    matrix[2, 0] = 2;
                    pb20.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 0] == 2 && matrix[2, 0] == 2 && matrix[1, 0] == 0)
                {
                    matrix[1, 0] = 2;
                    pb10.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 0] == 2 && matrix[1, 0] == 2 && matrix[0, 0] == 0)
                {
                    matrix[0, 0] = 2;
                    pb00.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 1] == 2 && matrix[1, 1] == 2 && matrix[2, 1] == 0)
                {
                    matrix[2, 1] = 2;
                    pb21.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 1] == 2 && matrix[1, 1] == 2 && matrix[0, 1] == 0)
                {
                    matrix[0, 1] = 2;
                    pb01.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 1] == 2 && matrix[2, 1] == 2 && matrix[1, 1] == 0)
                {
                    matrix[1, 1] = 2;
                    pb11.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 2] == 2 && matrix[1, 2] == 2 && matrix[2, 2] == 0)
                {
                    matrix[2, 2] = 2;
                    pb22.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 2] == 2 && matrix[1, 2] == 2 && matrix[0, 2] == 0)
                {
                    matrix[0, 2] = 2;
                    pb02.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 2] == 2 && matrix[2, 2] == 2 && matrix[1, 2] == 0)
                {
                    matrix[1, 2] = 2;
                    pb12.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 2] == 2 && matrix[1, 1] == 2 && matrix[2, 0] == 0)
                {
                    matrix[2, 0] = 2;
                    pb20.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 0] == 2 && matrix[1, 1] == 2 && matrix[0, 2] == 0)
                {
                    matrix[0, 2] = 2;
                    pb02.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 2] == 2 && matrix[2, 0] == 2 && matrix[1, 1] == 0)
                {
                    matrix[1, 1] = 2;
                    pb11.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 0] == 2 && matrix[1, 1] == 2 && matrix[2, 2] == 0)
                {
                    matrix[2, 2] = 2;
                    pb22.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 2] == 2 && matrix[1, 1] == 2 && matrix[0, 0] == 0)
                {
                    matrix[0, 0] = 2;
                    pb00.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 0] == 2 && matrix[2, 2] == 2 && matrix[1, 1] == 0)
                {
                    matrix[1, 1] = 2;
                    pb11.Image = Resources.Zeromaxi;
                    done = true;
                }
                ////
                else if (matrix[0, 0] == 1 && matrix[0, 1] == 1 && matrix[0, 2] == 0)
                {
                    matrix[0, 2] = 2;
                    pb02.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 0] == 1 && matrix[0, 2] == 1 && matrix[0, 1] == 0)
                {
                    matrix[0, 1] = 2;
                    pb01.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 2] == 1 && matrix[0, 1] == 1 && matrix[0, 0] == 0)
                {
                    matrix[0, 0] = 2;
                    pb00.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[1, 0] == 1 && matrix[1, 1] == 1 && matrix[1, 2] == 0)
                {
                    matrix[1, 2] = 2;
                    pb12.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[1, 0] == 1 && matrix[1, 2] == 1 && matrix[1, 1] == 0)
                {
                    matrix[1, 1] = 2;
                    pb11.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[1, 1] == 1 && matrix[1, 2] == 1 && matrix[1, 0] == 0)
                {
                    matrix[1, 0] = 2;
                    pb10.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 0] == 1 && matrix[2, 1] == 1 && matrix[2, 2] == 0)
                {
                    matrix[2, 2] = 2;
                    pb22.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 0] == 1 && matrix[2, 2] == 1 && matrix[2, 1] == 0)
                {
                    matrix[2, 1] = 2;
                    pb21.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 1] == 1 && matrix[2, 2] == 1 && matrix[2, 0] == 0)
                {
                    matrix[2, 0] = 2;
                    pb20.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 0] == 1 && matrix[1, 0] == 1 && matrix[2, 0] == 0)
                {
                    matrix[2, 0] = 2;
                    pb20.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 0] == 1 && matrix[2, 0] == 1 && matrix[1, 0] == 0)
                {
                    matrix[1, 0] = 2;
                    pb10.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 0] == 1 && matrix[1, 0] == 1 && matrix[0, 0] == 0)
                {
                    matrix[0, 0] = 2;
                    pb00.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 1] == 1 && matrix[1, 1] == 1 && matrix[2, 1] == 0)
                {
                    matrix[2, 1] = 2;
                    pb21.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 1] == 1 && matrix[1, 1] == 1 && matrix[0, 1] == 0)
                {
                    matrix[0, 1] = 2;
                    pb01.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 1] == 1 && matrix[2, 1] == 1 && matrix[1, 1] == 0)
                {
                    matrix[1, 1] = 2;
                    pb11.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 2] == 1 && matrix[1, 2] == 1 && matrix[2, 2] == 0)
                {
                    matrix[2, 2] = 2;
                    pb22.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 2] == 1 && matrix[1, 2] == 1 && matrix[0, 2] == 0)
                {
                    matrix[0, 2] = 2;
                    pb02.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 2] == 1 && matrix[2, 2] == 1 && matrix[1, 2] == 0)
                {
                    matrix[1, 2] = 2;
                    pb12.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 2] == 1 && matrix[1, 1] == 1 && matrix[2, 0] == 0)
                {
                    matrix[2, 0] = 2;
                    pb20.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 0] == 1 && matrix[1, 1] == 1 && matrix[0, 2] == 0)
                {
                    matrix[0, 2] = 2;
                    pb02.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 2] == 1 && matrix[2, 0] == 1 && matrix[1, 1] == 0)
                {
                    matrix[1, 1] = 2;
                    pb11.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 0] == 1 && matrix[1, 1] == 1 && matrix[2, 2] == 0)
                {
                    matrix[2, 2] = 2;
                    pb22.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[2, 2] == 1 && matrix[1, 1] == 1 && matrix[0, 0] == 0)
                {
                    matrix[0, 0] = 2;
                    pb00.Image = Resources.Zeromaxi;
                    done = true;
                }
                else if (matrix[0, 0] == 1 && matrix[2, 2] == 1 && matrix[1, 1] == 0)
                {
                    matrix[1, 1] = 2;
                    pb11.Image = Resources.Zeromaxi;
                    done = true;
                }
                /////

                if (!done)
                {
                    while (true)
                    {
                        Random r = new Random();
                        int ran = r.Next(1, 5);
                        if (ran == 1 && matrix[0, 0] == 0)
                        {
                            matrix[0, 0] = 2;
                            pb00.Image = Resources.Zeromaxi;
                            done = true;
                            break;
                        }
                        else if (ran == 2 && matrix[0, 2] == 0)
                        {
                            matrix[0, 2] = 2;
                            pb02.Image = Resources.Zeromaxi;
                            done = true;
                            break;
                        }
                        else if (ran == 3 && matrix[2, 0] == 0)
                        {
                            matrix[2, 0] = 2;
                            pb20.Image = Resources.Zeromaxi;
                            done = true;
                            break;
                        }
                        else if (ran == 4 && matrix[2, 2] == 0)
                        {
                            matrix[2, 2] = 2;
                            pb22.Image = Resources.Zeromaxi;
                            done = true;
                            break;
                        }
                        else if (matrix[0, 0] != 0 && matrix[0, 2] != 0 && matrix[2, 0] != 0 && matrix[2, 2] != 0)
                            break;
                    }

                    if (!done)
                    {
                        if (matrix[1, 1] == 0)
                        {
                            matrix[1, 1] = 2;
                            pb11.Image = Resources.Zeromaxi;
                            done = true;
                        }
                    }

                    if (!done)
                    {
                        while (true)
                        {
                            Random r = new Random();
                            int ran = r.Next(1, 5);
                            if (ran == 1 && matrix[1, 0] == 0)
                            {
                                matrix[1, 0] = 2;
                                pb10.Image = Resources.Zeromaxi;
                                done = true;
                                break;
                            }
                            else if (ran == 2 && matrix[0, 1] == 0)
                            {
                                matrix[0, 1] = 2;
                                pb01.Image = Resources.Zeromaxi;
                                done = true;
                                break;
                            }
                            else if (ran == 3 && matrix[1, 2] == 0)
                            {
                                matrix[1, 2] = 2;
                                pb12.Image = Resources.Zeromaxi;
                                done = true;
                                break;
                            }
                            else if (ran == 4 && matrix[2, 1] == 0)
                            {
                                matrix[2, 1] = 2;
                                pb21.Image = Resources.Zeromaxi;
                                done = true;
                                break;
                            }
                        }
                    }
                    ///////////
                }
                Check();
                turn = !turn;
                Turn();
            }
           
        }
        public void Check()
        {
            bool win1 = false;
            bool win2 = false;

            if (matrix[0, 0] == 1 && matrix[0, 1] == 1 && matrix[0, 2] == 1)
                win1 = true;
            else if (matrix[1, 0] == 1 && matrix[1, 1] == 1 && matrix[1, 2] == 1)
                win1 = true;
            else if (matrix[2, 0] == 1 && matrix[2, 1] == 1 && matrix[2, 2] == 1)
                win1 = true;
            else if (matrix[0, 0] == 1 && matrix[1, 0] == 1 && matrix[2, 0] == 1)
                win1 = true;
            else if (matrix[0, 1] == 1 && matrix[1, 1] == 1 && matrix[2, 1] == 1)
                win1 = true;
            else if (matrix[0, 2] == 1 && matrix[1, 2] == 1 && matrix[2, 2] == 1)
                win1 = true;
            else if (matrix[0, 0] == 1 && matrix[1, 1] == 1 && matrix[2, 2] == 1)
                win1 = true;
            else if (matrix[0, 2] == 1 && matrix[1, 1] == 1 && matrix[2, 0] == 1)
                win1 = true;

            else if (matrix[0, 0] == 2 && matrix[0, 1] == 2 && matrix[0, 2] == 2)
                win2 = true;
            else if (matrix[1, 0] == 2 && matrix[1, 1] == 2 && matrix[1, 2] == 2)
                win2 = true;
            else if (matrix[2, 0] == 2 && matrix[2, 1] == 2 && matrix[2, 2] == 2)
                win2 = true;
            else if (matrix[0, 0] == 2 && matrix[1, 0] == 2 && matrix[2, 0] == 2)
                win2 = true;
            else if (matrix[0, 1] == 2 && matrix[1, 1] == 2 && matrix[2, 1] == 2)
                win2 = true;
            else if (matrix[0, 2] == 2 && matrix[1, 2] == 2 && matrix[2, 2] == 2)
                win2 = true;
            else if (matrix[0, 0] == 2 && matrix[1, 1] == 2 && matrix[2, 2] == 2)
                win2 = true;
            else if (matrix[0, 2] == 2 && matrix[1, 1] == 2 && matrix[2, 0] == 2)
                win2 = true;

            if (win1 == true && once == false)
            {
                int p1s = int.Parse(lplayerscore.Text);
                p1s++;
                lplayerscore.Text = p1s.ToString();
                DialogResult result = MessageBox.Show(String.Format("{0} wins!!!", player),
                    "Congratulations!", MessageBoxButtons.OK);
                once = true;
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
                    once = false;
                    if (played == numGames)
                    {
                        int p1w = int.Parse(lplayerscore.Text);
                        int p2w = int.Parse(lcomputerscore.Text);
                        if (p1w > p2w)
                        MessageBox.Show(String.Format("{0} is the ultimate winner", player),
                   "Congratulations!", MessageBoxButtons.OK);
                        else if (p1w < p2w)
                            MessageBox.Show("Computer is the ultimate winner",
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
                int p2s = int.Parse(lcomputerscore.Text);
                p2s++;
                lcomputerscore.Text = p2s.ToString();
                DialogResult result = MessageBox.Show("Computer wins!!!",
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
                    once = false;
                    if (played == numGames)
                    {
                        int p1w = int.Parse(lplayerscore.Text);
                        int p2w = int.Parse(lcomputerscore.Text);
                        if (p1w > p2w)
                            MessageBox.Show(String.Format("{0} is the ultimate winner", player),
                       "Congratulations!", MessageBoxButtons.OK);
                        else if (p1w < p2w)
                            MessageBox.Show("Computer is the ultimate winner",
                       "Congratulations!", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("It's a draw!",
                   "Draw!", MessageBoxButtons.OK);
                        Close();
                    }
                }
            }

            if (win1 == false && win2 == false)
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
                        once = false;
                        if (played == numGames)
                        {
                            int p1w = int.Parse(lplayerscore.Text);
                            int p2w = int.Parse(lcomputerscore.Text);
                            if (p1w > p2w)
                                MessageBox.Show(String.Format("{0} is the ultimate winner", player),
                           "Congratulations!", MessageBoxButtons.OK);
                            else if (p1w < p2w)
                                MessageBox.Show("Computer is the ultimate winner",
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
               
                Check();
                turn = !turn;
                Turn();
            }
        }
    }
}
