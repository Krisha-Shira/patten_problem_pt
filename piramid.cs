using System;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        int n = int.Parse(Console.ReadLine());

        int rows = n + 1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == 0 || i == rows - 1)
                {

                    Console.Write(n + " ");
                }
                else
                {
                    if (j == 0 || j == 2)
                    {

                        Console.Write(n + " ");
                    }
                    else if (j == 1)
                    {

                        Console.Write(i + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}