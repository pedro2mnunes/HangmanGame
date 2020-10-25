using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //Make this first to ensure randomness!

            string ThisAnswer;
            string Input;

            bool HasWon = false;

            // Make answers for the game to pick from, then choose one and get its length for the next part.
            List<string> GameAnswers = new List<string> { "Apple", "Pear", "Banana", "Mango", "Apricot", "Plum" };
            ThisAnswer = GameAnswers[random.Next(GameAnswers.Count)].ToUpper();
            int length = ThisAnswer.Length;
            // Let's welcome our player and let them know the rules, as well as give them a clue for our answer.
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("Discover the word in 5 attempts by guessing using letters.");
            string TellLength = "This word has: " + length + " letters. Good luck!";
            Console.WriteLine(TellLength);

            List<string> GuessDisplay = new List<string>(ThisAnswer.Length);

            // Set up the underscores so we can show the player how many letters they need to guess.
            for (int i = 0; i < ThisAnswer.Length; i++)
            {
                GuessDisplay.Add("_ ");
            }

            while (HasWon == false)
            {
                // For each letter left to guess, show it to the player so they can see their progress.
                foreach (string letter in GuessDisplay)
                {
                    Console.Write(letter);
                }

                Console.WriteLine();

                // Get the user's guess.
                Input = Console.ReadLine().ToUpper();

                if (ThisAnswer.Contains(Input) == true) // If the letter appears in the answer, they're correct!
                {
                    Console.WriteLine("Correct!"); // Let the player know how clever they are.
                    char guess = Input[0];

                    // Now we'll go through each letter of the answer and check our player's answer against it.
                    // If the guess and the letter matches, replace the guess display with the letter, so the player can see where they got it right.

                    for (int i = 0; i < ThisAnswer.Length; i++)
                    {
                        if (ThisAnswer[i].Equals(guess) == true)
                        {
                            GuessDisplay[i] = Input;
                        }
                    }

                    // If there's no more gaps left in the guess display, the player won!
                    if (GuessDisplay.Contains("_ ") == false)
                    {
                        HasWon = true; // Tell the program they won.
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }
            // When the player has won, we leave the game loop and enter the end game preparation.
            // This is also a good place to put the code that tells the player they lost the game.
            // Think about how you'd code such a system!
            if (HasWon == true)
            {
                Console.WriteLine("YOU WON! Press any key to quit.");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }
    }
}