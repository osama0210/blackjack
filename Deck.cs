using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace blackjack
{
    class Deck
    {
        private List<Card> cards = new List<Card>();


        public Deck()
        {
            foreach(Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (FaceValues faceValue in Enum.GetValues(typeof(FaceValues)))
                {
                    cards.Add(new Card(suit, faceValue));
                }                               
            }
        }

        public void shuffleCards()
        {
            Random random = new Random();
            for(int i = cards.Count -1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                Card cardA = cards[i]; // Een kopie opslaan van elke iteratie
                // Om de gekopieerde waarden (cardA en cardB) echt om te wisselen in de lijst,
                // moeten we ze terugplaatsen op hun originele posities in de kaartenlijst (cards).
                cards[i] = cards[j]; // Zet ver
                cards[j] = cardA; // Zet cardA op de random plek die al gekozen is in de varaible randomIndex


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

        public void dealCards()
        {

        }

        public void PrintDeck()
        {
            foreach(Card card in cards)
            {
                Debug.WriteLine(card);
            }
        }
    }
}
