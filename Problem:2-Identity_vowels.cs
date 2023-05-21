//Applied activity 1 : Problem 2 - Identify Vowels

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Getting user input
        Console.WriteLine("Enter an Alphabet: ");
        string userInput = Console.ReadLine();

        string alphabet = userInput.ToLower();

        bool flag = false;

        //Storing the vowels
        string[] vowels = { "a", "e", "i", "o", "u" };

        // looping through the vowels array
        for(int i = 0; i < vowels.Length; i++)
        {
            if (alphabet == vowels[i])
            {
                flag = true;
                break;
            }
        }

        // Checking if the alphabet is vowel or not
        if(flag)
        {
            Console.WriteLine("Vowel");
        }
        else
        {
            Console.WriteLine("Not a vowel!");
        }
        

}
}
