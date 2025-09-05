// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(String[] args)
    {
        // ! 1.
        // * Console.Write : Displaying output
        /*
        Console.WriteLine("This");
        Console.WriteLine("is");
        Console.WriteLine("Very");
        Console.WriteLine("Nice");
        */

        // * Console.Write : Outputing sound
        /*
        Console.Beep();
        */

        // ! 2.
        // * Comment and escape sequence
        /*
        Console.Write("Hey!");
        Console.WriteLine("Hello");
        */

        // This is a comment
        /*
        This
        is
        a
        multiline
        comment
        */

        // * Escape Sequence
        /*
        Console.WriteLine("\t This is would have a tab");
        Console.ReadKey();
        */

        // ! 3.
        // * Variable
        /*
        String name = "Fahrel";
        int age = 20;
        double height = 174.3;
        bool isAlive = true;
        char symbol = '@';

        System.Console.WriteLine("Hello " + name);
        System.Console.WriteLine("You are " + age + " years old");
        System.Console.WriteLine("Your height is " + height + " cm");
        System.Console.WriteLine("Are you alive? " + isAlive);
        System.Console.WriteLine("Your symbol is " + symbol);

        String userName = symbol + name;
        System.Console.WriteLine("Your username is " + userName);
        */

        // ! 4.
        // * Const
        /*
        const double pi = 3.14;
        System.Console.WriteLine(pi);
        */

        // ! 5.
        // * type casting = convert datatype
        /*
        double a = 3.14;
        int b = Convert.ToInt32(a);

        int c = 5;
        double d = Convert.ToDouble(c);

        int e = 425;
        String f = Convert.ToString(e);

        String g = "@";
        char h = Convert.ToChar(g);

        String i = "false";
        bool j = Convert.ToBoolean(i);

        System.Console.WriteLine(b.GetType());
        System.Console.WriteLine(d.GetType());
        System.Console.WriteLine(f.GetType());
        System.Console.WriteLine(h.GetType());
        System.Console.WriteLine(j.GetType());
        */

        // ! 6.
        // * Accept user Input
        System.Console.WriteLine("What is your name?");
        String name = Console.ReadLine();

        System.Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Hello " + name);
        System.Console.WriteLine("You are " + age + " years old");
    }
}
