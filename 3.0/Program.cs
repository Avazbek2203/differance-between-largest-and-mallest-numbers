using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[4];

        for (int i = 0; i < numbers.Length; i++)
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.Write($"Enter number {i + 1}: ");

                double input;
                if (double.TryParse(Console.ReadLine(), out input))
                {
                    numbers[i] = (int)input;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        int smallest = numbers[0];
        int largest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        int difference = largest - smallest;
        Console.WriteLine($"The difference between the largest number {largest} and the smallest number {smallest} numbers is {difference}.");
    }
}
