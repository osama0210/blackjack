using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Deck
    {
        private List<Card> cards = new List<Card>();


        public Deck()
        {
            foreach(Suits suit in Enum.GetValues(typeof(Suits)))
            {
                Debug.WriteLine(suit);
                foreach (FaceValues faceValue in Enum.GetValues(typeof(FaceValues)))
                {
                    Debug.WriteLine(faceValue);
                    cards.Add(new Card(suit, faceValue));
                }                               
            }
            foreach(Card kaarten in cards)
            {
                Debug.WriteLine(kaarten);
            }
        }
    }
}
