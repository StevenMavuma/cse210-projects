using System;

class Program
{

    static void Name(out string myName)
    {
        Console.Write("Please enter your name: ");
        string n = Console.ReadLine();
        myName = n;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        string n;
        Name(out n);
        Console.WriteLine(n);

    }
}