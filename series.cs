using System;

class A1
{
    public static void Main()
    {
        Console.Write("Input the number of terms: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Input number: ");
        int digit = int.Parse(Console.ReadLine());

        int term = 0;
        int sum = 0;

        Console.WriteLine("\nSeries:");
        for (int i = 1; i <= n; i++)
        {
            term = term * 10 + digit;  // Builds terms like 5, 55, 555, etc.
            Console.Write(term);
            if (i < n)
                Console.Write(" + ");
            sum += term;
        }

        Console.WriteLine($"\nThe Sum is: {sum}");
    }
}