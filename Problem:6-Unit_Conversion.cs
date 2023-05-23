using System;

namespace UnitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Unit Conversion!");

            // Ask the user to select speed or distance
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Speed");
            Console.WriteLine("2. Distance");
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                ConvertSpeed();
            }
            else if (choice == 2)
            {
                ConvertDistance();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.ReadLine();
        }

        static void ConvertSpeed()
        {
            Console.WriteLine("Speed Conversion");
            Console.WriteLine("1. Miles per hour to kilometers per hour");
            Console.WriteLine("2. Kilometers per hour to miles per hour");
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter the speed in miles per hour: ");
                double mph = double.Parse(Console.ReadLine());
                double kph = mph * 1.60934;
                Console.WriteLine($"Speed in kilometers per hour: {kph} kph");
            }
            else if (choice == 2)
            {
                Console.Write("Enter the speed in kilometers per hour: ");
                double kph = double.Parse(Console.ReadLine());
                double mph = kph / 1.60934;
                Console.WriteLine($"Speed in miles per hour: {mph} mph");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }

        static void ConvertDistance()
        {
            Console.WriteLine("Distance Conversion");
            Console.WriteLine("1. Miles to kilometers");
            Console.WriteLine("2. Kilometers to miles");
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter the distance in miles: ");
                double miles = double.Parse(Console.ReadLine());
                double kilometers = miles * 1.60934;
                Console.WriteLine($"Distance in kilometers: {kilometers} km");
            }
            else if (choice == 2)
            {
                Console.Write("Enter the distance in kilometers: ");
                double kilometers = double.Parse(Console.ReadLine());
                double miles = kilometers / 1.60934;
                Console.WriteLine($"Distance in miles: {miles} mi");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
