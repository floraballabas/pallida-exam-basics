using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueCharacters
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"
            var inputToCheck = "anagram";
            foreach (var charachter in UniqueCharacter(inputToCheck))
            {
                Console.Write(charachter + ", ");
            }
            Console.ReadLine();

        }
        public static List<char> UniqueCharacter(string input)
        {
            List<char> uniqueLetterList = new List<char>();
            Dictionary<char, int> letterDictionary = new Dictionary<char, int>();
            string inputLower = input.ToLower();
            char[] inputArray = inputLower.ToCharArray();

            foreach (var character in inputArray)
            {
                if (!letterDictionary.ContainsKey(character))
                {
                    letterDictionary.Add(character, 1);
                }
                else
                {
                    letterDictionary[character]++;
                }
            }
            foreach (var letter in letterDictionary)
            {
                if (letter.Value == 1)
                {
                    uniqueLetterList.Add(letter.Key);
                }
            }
            return uniqueLetterList;
        }
    }
}
