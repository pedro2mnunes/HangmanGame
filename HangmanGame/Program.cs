using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame {
    class Program {
        static void Main (string[] args) {
            //Instantiate random number generator using system-supplied value as seed.
            var rand = new Random ();
            //The string Input will store the user input.
            string Input;

            //The string Solution stores the solution word.
            string Solution;

            // The bool HasFinished stores the player status in the game. While false means that the player has not win/finished the game. 
            bool HasFinished = false;

            //Create one answer for the game from the list. Calculate its length.
            //System.Collections.Generic(T): Represents a strongly typed list of objects that can be accessed by index. Provides methods to search, sort, and manipulate lists.
            List<string> WordLibrary = new List<string> { "shirt", "dress", "glove", "short", "cap", "shoe" };

            /*class System.Random
            Represents a pseudo-random number generator, which is a device that produces a sequence of numbers that meet certain statistical requirements for randomness.
            An object reference is required for the non-static field, method, or property 'Random.Next(int)' */
            /* string string.ToUpper()
            Returns a copy of this string converted to uppercase.
            Returns:The uppercase equivalent of the current string.*/
            Solution = WordLibrary[Random.Next (WordLibrary.Count)].ToUpper ();

            int SolutionLength = Solution.Length;

        }
    }
}