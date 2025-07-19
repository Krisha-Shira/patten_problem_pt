//write the program
//input:1234
//output:one two three four

using System;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();

        foreach (char digit in input)
        {
            switch (digit)
            {
                case '0': Console.Write("zero "); break;
                case '1': Console.Write("one "); break;
                case '2': Console.Write("two "); break;
                case '3': Console.Write("three "); break;
                case '4': Console.Write("four "); break;
                case '5': Console.Write("five "); break;
                case '6': Console.Write("six "); break;
                case '7': Console.Write("seven "); break;
                case '8': Console.Write("eight "); break;
                case '9': Console.Write("nine "); break;
                default:
                    Console.Write(""); // Ignore non-digit characters
                    break;
            }
        }

        Console.WriteLine(); // To move to the next line after output
    }
}