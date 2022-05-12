using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingHeadsOrTails
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Guess which will have more: heads or tails");
            var headsOrTailsGuess = false;
            
            var input = string.Empty;
            do
            {
                input = Console.ReadLine();
                headsOrTailsGuess = input.ToLower() == "heads";

            } while (input.ToLower() != "heads" && input.ToLower() != "tails");

            Console.WriteLine("How many times shall we flip a coin? ");
            var numberOfFlips = int.Parse(Console.ReadLine() + "\n");

            do
            {

            } while (!int.TryParse(Console.ReadLine(), out numberOfFlips));

            var rand = new Random();

            var heads = 0;
            var tails = 0;

            //var percentageFlips = (headsOrTailsGuess) / (numberOfFlips)100;   **throwing CS0118 error**
            for (var i = 0; i < numberOfFlips; i++)
            {
                if (rand.Next(0, 2) == 0)
                {
                    Console.WriteLine("Heads!");
                    heads++;
                }
                else
                {
                    Console.WriteLine("Tails!");
                    tails++;
                }
            }
            var correctGuess = (headsOrTailsGuess && heads > tails) ||
                (!headsOrTailsGuess && tails > heads);

            Console.WriteLine("Your guess, " + headsOrTailsGuess + " came up "
                + correctGuess + " time(s).");
            //Console.WriteLine("That's " + percentageFlips + "%.");   
            Console.WriteLine(headsOrTailsGuess);

        }
    }
}

