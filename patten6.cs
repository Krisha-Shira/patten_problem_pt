using System;

public class Patten
{
    public static void Main(string[] args)
    {
        //int rows = 5; 

        for (int i = 1; i <= 5; i++)
        {
            // Print spaces
            for (int j = 1; j <= 5 - i; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }

            // Move to the next line
            Console.WriteLine();
        }
    }
}


