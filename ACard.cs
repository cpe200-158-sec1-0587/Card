using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class ACard : Form1
    {
        private int rank;
        private int suit;

        public int getRank()
        {
            return rank;
        }
        public int getSuit()
        {
            return suit;
        }
        public ACard(int rankin,int suitin)
        {
            rank = rankin;
            suit = suitin;
        }

    }
}
