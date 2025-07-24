//create one add method to add two numbers and return result of addition of that numbers.
using System;

public class Class1
{

    static int Add(int a, int b)//non static
    {
        return a + b;
    }
    static int Sub(int a, int b)//non static
    {
        return a - b;
    }
    static int Mul(int a, int b)//non static
    {
        return a * b;
    }
    static int Div(int a, int b)//non static
    {
        return a / b;
    }
    //can not use non-static members within static method
    public static void Main(string[] args)
    {
        int a = 20, b = 10;
        int ra;
        ra = Add(a, b);
        Console.WriteLine("Addition of two numbers is: " + ra);
        ra = Sub(a, b);
        Console.WriteLine("Subtraction of two numbers is: " + ra);
        ra = Mul(a, b);
        Console.WriteLine("Multiplication of two numbers is: " + ra);
        ra = Div(a, b);
        Console.WriteLine("Division of two numbers is: " + ra);
        //Console.WriteLine("Addition of two numbers is: {0}", ra, a);
        //Console.WriteLine("Addition of two numbers is: {0} + {1} : {2}", ra, a, b);
    }
}
