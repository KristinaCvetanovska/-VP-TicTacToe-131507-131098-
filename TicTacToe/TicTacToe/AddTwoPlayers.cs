using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class AddTwoPlayers : Form
    {
        public string player1 { get; set; }
        public string player2 { get; set; }
        public int numGames { get; set; }

        public AddTwoPlayers()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbPlayer1.Text != "" && tbPlayer2.Text != "")
            {
                player1 = tbPlayer1.Text;
                player2 = tbPlayer2.Text;
                numGames = (int) nudGames.Value;
                Game2p gtp = new Game2p(player1, player2, numGames);
                Close();
                gtp.Show();
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are sure to want to cancel?", "Cancel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void tbPlayer1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbPlayer2_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
