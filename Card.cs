using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Card
    {
        private Suits suit;
        private FaceValues faceValue;
        private int cardValue;
        private Image image;


        public Suits Suit{
            get { return suit; }
        }

        public FaceValues FaceValue
        {
            get { return faceValue; }
        }

        public int CardValue
        {
            get { return cardValue; }
            set { cardValue = value; }
        }

        public Card(Suits suit, FaceValues faceValue, int cardValue)
        {
            suit = Suit;
            faceValue = FaceValue;
            cardValue = CardValue;
        }
    }
}
