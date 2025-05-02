using System.Diagnostics;

namespace blackjack
{
    class Deck
    {
        private List<Card> cards = new List<Card>();

        public List<Card> Cards
        {
            get { return cards; }
            set { cards = value; }
        }


        public Deck()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (FaceValues faceValue in Enum.GetValues(typeof(FaceValues)))
                {
                    cards.Add(new Card(suit, faceValue, true));
                }
            }
        }

        public void shuffleCards()
        {
            Random random = new Random();
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1); // Kies een willekeurige index tussen 0 en i

                Card cardA = cards[i]; // Sla de kaart op positie i tijdelijk op

                // Wissel de kaarten op positie i en j
                cards[i] = cards[j]; // Zet de kaart van positie j op positie i
                cards[j] = cardA;    // Zet de oorspronkelijke kaart (van i) op positie j


                /* 
                 * Waarom is dit fout? 
                 * cardA = cardB;
                 * cardB = cardA;
                 * Hier overschrijf ik de waarden:
                 * Eerst doe ik: cardA is cardB         cardA krijgt de waarde van cardB
                 * Dan doe ik: cardB is cardA           CardB krijgt de nieuwe waarde van cardA
                 * Hierdoor hebben beide variabelen dezelfde waarde
                 * Bovendien pas ik niks in de echte lijst (cards).
                 */
            }
        }

        public Card giveOneCard()
        {
            Card pickOneCard = cards[0];
            cards.RemoveAt(0);
            return pickOneCard;
        }

        public void PrintDeck()
        {
            foreach (Card card in cards)
            {
                Debug.WriteLine(card);
            }
        }
    }
}
