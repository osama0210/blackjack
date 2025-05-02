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
        private bool isFaceUp = true;
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

        public bool IsFaceUp
        {
            get { return isFaceUp; }
            set { isFaceUp = value; }
        }

        public Card(Suits suit, FaceValues faceValue, bool isFaceUp)
        {
            this.suit = suit;
            this.faceValue = faceValue;
            this.isFaceUp = true;
        }
        public override string ToString()
        {
            if (!isFaceUp)
                return "[Hidden Card]";
            else
                return $"{faceValue} of {suit}";
        }
    }
}
