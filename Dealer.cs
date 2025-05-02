using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace blackjack
{
    class Dealer
    {
             
        private List<Card> dealerHand = new List<Card>();

        public List<Card> DealerHand
        {
            get { return dealerHand; }
            set { dealerHand = value; }
        }


        public void dealCards(Deck deck, Player player)
        {
            deck.shuffleCards();
            for (int i = 0; i < 2; i++)
            {
                Card card1 = deck.giveOneCard();
                player.addCard(card1);

            }
            Card dealerCard1 = deck.giveOneCard();
            dealerHand.Add(dealerCard1);

            Card dealerCard2 = deck.giveOneCard();
            dealerCard2.IsFaceUp = false;
            dealerHand.Add(dealerCard2);
        }
    }
}
