//Applied activity 1 : Problem 2 - Identify Vowels

//variables required for the program
bool flag = false;
string choice;

// do while loop for the user choice to continue checking vowels
do
{
    // Getting user input
    Console.WriteLine("Enter an Alphabet: ");
    string userInput = Console.ReadLine();

    string alphabet = userInput.ToLower();

    //Storing the vowels
    string[] vowels = { "a", "e", "i", "o", "u" };

    // looping through the vowels array
    for (int i = 0; i < vowels.Length; i++)
    {
        if (alphabet == vowels[i])
        {
            flag = true;
            break;
        }
    }

    // Checking if the alphabet is vowel or not
    if (flag)
    {
        Console.WriteLine("Vowel");
    }
    else
    {
        Console.WriteLine("Not a vowel!");
    }

    Console.WriteLine("Do you want to continue (y/n): ");

    choice = Console.ReadLine();

} while (choice == "y");
