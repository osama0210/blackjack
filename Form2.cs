using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    public partial class Form2 : Form
    {
        private Deck deck;
        private Dealer dealer;
        private List<Player> players;
        private int numberOfPlayers;
        public Form2(int numberOfPlayers)
        {
            InitializeComponent();
            this.numberOfPlayers = numberOfPlayers;

            deck = new Deck();
            dealer = new Dealer();
            players = new List<Player>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Player player = new Player();
                player.Name = $"Player {i + 1}";
                players.Add(player);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dealer.dealCards(deck, players);

            listBoxDealer.Items.Clear();
            listBoxPlayer1.Items.Clear();
            listBoxPlayer2.Items.Clear();
            listBoxPlayer3.Items.Clear();
            listBoxPlayer4.Items.Clear();

            foreach (Card card in dealer.DealerHand)
            {
                listBoxDealer.Items.Add("Dealer: " + card.ToString());
            }

            if (players.Count > 0)
            {
                foreach (Card card in players[0].PlayerHand)
                {
                    listBoxPlayer1.Items.Add(card);
                }
            }

            if (players.Count > 1)
            {
                foreach (Card card in players[1].PlayerHand)
                {
                    listBoxPlayer2.Items.Add(card);
                }
            }

            if (players.Count > 2)
            {
                foreach (Card card in players[2].PlayerHand)
                {
                    listBoxPlayer3.Items.Add(card);
                }
            }

            if (players.Count > 3)
            {
                foreach (Card card in players[3].PlayerHand)
                {
                    listBoxPlayer4.Items.Add(card);
                }
            }

            dealBtn.Enabled = false;
        }


    }
}
