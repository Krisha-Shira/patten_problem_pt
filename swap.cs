using System;

public class Class1
{
    
    static void Swap( int a,  int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main(string[] args)
    {
        int a = 10, b = 20;
        Console.WriteLine("Before the swap: a = {0} and b = {1}", a, b);

        Swap( a, b); 

        Console.WriteLine("After the swap: a = {0} and b = {1}", a, b);
    }
}
