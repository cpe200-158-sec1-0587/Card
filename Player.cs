using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    class Player : Form1
    {
        private string name;
        private List<ACard> deck = new List<ACard>();
        private List<ACard> pile = new List<ACard>();

        public int getNumdeck()
        {
            return deck.Count;
        }
        public int getNumpile()
        {
            return pile.Count;
        }
        public Player(string namein)
        {
            name = namein;
        }
        public ACard getCard()
        {
            ACard tmp = deck[0];
            deck.RemoveAt(0);
            return tmp;
        }
        public void addPile(ACard cardin)
        {
            pile.Add(cardin);
        }
        public void addDeck(ACard cardin)
        {
            deck.Add(cardin);
        }
    }
}
