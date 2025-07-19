using System;

class Program
{
    static void Main()
    {
        int lines = 4;

        for (int i = 1; i <= lines; i++)
        {
            char symbol = (i % 2 == 1) ? '*' : '#';

            for (int j = 0; j < i; j++)
            {
                Console.Write(symbol + " ");
                symbol = (symbol == '*') ? '#' : '*';
            }
            Console.WriteLine();
        }
    }
}