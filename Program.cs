using System.Diagnostics;

namespace blackjack
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            Deck deck = new Deck();
            Dealer dealer = new Dealer();
            List<Player> players = new List<Player>();


            int amount = 0;
            while (amount < 1 || amount > 4) // spelers aantal check moet tussen 1 en 4
            {
                Console.WriteLine("Choose amount of players 1 / 4: ");
                amount = Convert.ToInt32(Console.ReadLine());

                if (amount < 1 || amount > 4)
                {
                    Console.WriteLine("Invalid input. Please choose a number between 1 and 4.");
                }
            }

            for (int i = 0; i < amount; i++) // Aantal spelers wordt toegevoegd aan de players List.
            {
                Player player = new Player();
                player.Name = $"Player {i + 1}";
                players.Add(player);
            }

            Debug.WriteLine("Press ENTER to shuffle the deck and start dealing...");
            Console.ReadLine();
            deck.shuffleCards();

            dealer.dealCards(deck, players);

            foreach (Card card in dealer.DealerHand)
            {
                Debug.WriteLine("Dealer Cards: " + card);
            }

            foreach (Player speler in players)
            {
                foreach (Card kaart in speler.PlayerHand)
                {
                    Debug.WriteLine($"{speler.Name} kaart: {kaart}");
                }
            }
        }
    }
}