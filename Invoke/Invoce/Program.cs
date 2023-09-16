
using Invoce;
using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter string:");
        var str = Console.ReadLine();

        MyClass cls = new MyClass(str);

        // Create delegates for Space() and Reverse() methods
        Func spaceDelegate = new Func(cls.Space);
       Func reverseDelegate = new Func(cls.Reverse);
        Run run = new Run();

        Console.Write("Result of Space():");
        run.runFunc(spaceDelegate, str);

        Console.WriteLine("Result of Reverse():");
        run.runFunc(reverseDelegate, str);
      }
}