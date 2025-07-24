using System;

public class Class1
{
    
    static void change(ref int a, ref int b)
    {
        a = 100;
        b = 200;

    }
    static void updates(out int x, out int y)
    {
        x = 100; 
        y = 200;
    }
    public static void Main(string[] args)
    {
        int a = 10, b = 20;
        int x = 10, y = 20;
        Console.WriteLine("Before the swap: a = {0} and b = {1}", a, b);

        change(ref a, ref b); // Pass variables by reference

        Console.WriteLine("After the swap: a = {0} and b = {1}", a, b);


        Console.WriteLine("Before the swap: a = {0} and b = {1}", x, y);

        updates(out x, out y); // Pass variables by reference

        Console.WriteLine("After the swap: a = {0} and b = {1}", x, y);
    }
}
