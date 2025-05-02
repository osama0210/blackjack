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
            Player player = new Player();


            Debug.WriteLine("Start van programma");

            dealer.dealCards(deck, player);


            foreach (Card card in dealer.DealerHand)
            {
                Debug.WriteLine("Dealer Card: " + card);
            }
        }
    }
}