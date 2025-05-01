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

            Debug.WriteLine("DECK VOOR SHUFFLE:");
            deck.PrintDeck();


            deck.shuffleCards();

            Debug.WriteLine("\nDECK NA SHUFFLE:");
            deck.PrintDeck();


        }
    }
}