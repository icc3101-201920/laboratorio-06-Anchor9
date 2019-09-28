using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Laboratorio_5_OOP_201902.Cards; // asi puedo llamar a cards

namespace Laboratorio_5_OOP_201902
{   //Manejar inputs y outpus -- interaccion usuario
    public static class Visualization 
    {
        public static void ShowHand(Hand hand)
        {
            //Game game = new Game();
            //game.AddDecks();
            //game.AddCaptains();
            //Player player = new Player();
            //Board board = new Board();
            //player.Board = board;
            //player.Deck = game.Decks[0];
            //player.Deck.Shuffle();
            //player.FirstHand();
            //player.ChooseCaptainCard(game.Captains[0]);
            //Console.WriteLine($"Player captain card: {player.Captain.Name}\n");
            //int counter = 1;
            //Console.WriteLine("Player Hand:");
            //foreach (Card card in player.Hand.Cards)

            int contador = 0; // parecido al for de arriba
            foreach (Card card in hand.Cards)
            {
                if (card.GetType().Name == nameof(SpecialCard))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"({contador++}) {card.Name} ({card.GetType()})");

                }

                if (card.GetType().Name == nameof(CombatCard))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"({contador++}) {card.Name} ({card.GetType()})");
                }

            }



        }
        public static void ShowDecks(List<Deck> decks)
        {
            int contador = 0;
            Console.WriteLine("Select  Deck: ");
            foreach (Deck deck in decks)
            {
                Console.WriteLine($"({contador}) Deck {contador + 1}");
                contador = contador +1;
            }

        }
        public static void ShowCaptains(List<SpecialCard> captains)
        {
            int contador = 0;
            foreach (SpecialCard captain in captains)
            {
                Console.WriteLine($"({contador}) Captain: {captain.Name}: {captain.Effect}");
                contador = contador + 1;

            }
        }
        public static void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;

        }

        public static void ShowProgramMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void ShowListOptions(List<string> options, string message = null)
        {
            int contador = 0;
            if (message != null)
            {
                Console.WriteLine(message);

                foreach (string option in options)
                {
                    Console.WriteLine($"({contador}) {option}");

                }
            }
            

        }
        public static void ClearConsole()
        {
            Console.Clear();
        }

        // falta completar metodo getuserinput 

        static void GetUserInput(int maxInput, bool stopper = false)
        {
            while (true)
            {
                string Input = Console.ReadLine();
                int number;
                try
                {
                    number = Convert.ToInt32(); // Que va en el int

                }
            }
        }


    }
}
