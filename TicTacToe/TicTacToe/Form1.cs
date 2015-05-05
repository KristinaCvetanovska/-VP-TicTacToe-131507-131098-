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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPvsP_Click(object sender, EventArgs e)
        {
            AddTwoPlayers atp = new AddTwoPlayers();
            atp.Show();
        }

        private void btnPvsPC_Click(object sender, EventArgs e)
        {
            AddOnePlayer aop = new AddOnePlayer();
            aop.Show();
        }
    }
}
