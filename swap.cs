using System;

public class Class1
{
    // Method to swap values using ref keyword
    static void Swap(ref int a, ref int b)
    {
        //int temp = a;
        //a = b;
        //b = temp;
        (a,b) = (b,a);

    }

    public static void Main(string[] args)
    {
        int a = 10, b = 20;
        Console.WriteLine("Before the swap: a = {0} and b = {1}", a, b);

        Swap(ref a, ref b); // Pass variables by reference

        Console.WriteLine("After the swap: a = {0} and b = {1}", a, b);
    }
}
