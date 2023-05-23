using System;
using System.Collections.Generic;

namespace VowelExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vowel Extractor!");

            while (true)
            {
                // Ask the user to input a word
                Console.Write("Enter a word: ");
                string word = Console.ReadLine();

                // Extract vowels and count occurrences
                List<char> vowels = new List<char>();
                Dictionary<char, int> vowelCounts = new Dictionary<char, int>();

                foreach (char letter in word)
                {
                    if (IsVowel(letter))
                    {
                        if (!vowels.Contains(letter))
                            vowels.Add(letter);

                        if (vowelCounts.ContainsKey(letter))
                            vowelCounts[letter]++;
                        else
                            vowelCounts[letter] = 1;
                    }
                }

                // Remove vowels from the word
                string wordWithoutVowels = RemoveVowels(word);

                // Display the vowel list and word without vowels
                Console.WriteLine("Vowels:");
                foreach (char vowel in vowels)
                {
                    Console.WriteLine($"{vowel} (Count: {vowelCounts[vowel]})");
                }

                Console.WriteLine("Word without vowels: " + wordWithoutVowels);

                // Ask if the user wants to continue
                Console.Write("Do you want to enter another word? (Y/N): ");
                string choice = Console.ReadLine();

                if (choice.ToUpper() != "Y")
                    break;
            }
        }

        static bool IsVowel(char letter)
        {
            letter = char.ToLower(letter);
            return letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u';
        }

        static string RemoveVowels(string word)
        {
            string wordWithoutVowels = "";
            foreach (char letter in word)
            {
                if (!IsVowel(letter))
                    wordWithoutVowels += letter;
            }
            return wordWithoutVowels;
        }
    }
}
