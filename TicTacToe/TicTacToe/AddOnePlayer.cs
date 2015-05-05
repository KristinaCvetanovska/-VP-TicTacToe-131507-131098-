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
    public partial class AddOnePlayer : Form
    {
        public string Player { get; set; }
        public int numGames { get; set; }

        public AddOnePlayer()
        {
            InitializeComponent();
        }

        private void tbPlayer_Validating(object sender, CancelEventArgs e)
        {
            if (tbPlayer.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPlayer, "Please enter a name!");
            }
            else
            {
                errorProvider1.SetError(tbPlayer, null);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbPlayer.Text == "")
            {
                
            }
            else
            {
                Player = tbPlayer.Text;
                numGames = (int)nudGames.Value;
                Game1p g1p = new Game1p(Player, numGames);
                Close();
                g1p.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are sure to want to cancel?", "Cancel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void tbPlayer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
