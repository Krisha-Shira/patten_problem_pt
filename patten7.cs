//write the program
//input:1234
//output:one two three four

using System;

public class Class1
{
    public static void Main(string[] args)
    {


        Console.WriteLine("Enter the array element:");
        int digit;
        Console.WriteLine("Enter the Number:");
        int no = Convert.ToInt32(Console.ReadLine());

        while (no > 0)
        {
            digit = no % 10;
            no = no / 10;
            Console.WriteLine(no);
        }





    }
}