using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Player
    {
        private List<Card> playerHand = new List<Card>();
        private string name;

        public List<Card> PlayerHand
        {
            get { return playerHand; }
            set { playerHand = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void addCard(Card card)
        {
            playerHand.Add(card);
        }
    }
}
