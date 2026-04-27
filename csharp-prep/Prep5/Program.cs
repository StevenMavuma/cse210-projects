using System;

class Program
{

    static void Name(out string myName)
    {
        Console.Write("Please enter your name: ");
        string n = Console.ReadLine();
        myName = n;
    }

    static void Num(ref int myNumber, string type)
    {
        if (type == "fav")
        {
            Console.Write("Please enter your favorite number: ");
            double num = double.Parse(Console.ReadLine());
            num = Math.Pow(num, 2.00);
            myNumber = (int)num;
        }
        else if (type == "dob")
        {
            Console.Write("Please enter the year you were born: ");
            int num = int.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - num;
            myNumber = age;
        }

    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Welcome to the program!");
            string name;
            int age = 0;
            int favNumSqr = 0;
            Name(out name);
            Num(ref favNumSqr, "fav");
            Num(ref age, "dob");
            
            Console.WriteLine($"Brother {name}, the square of your number is {favNumSqr}");
            Console.WriteLine($"Brother {name}, you will turn {age} this year.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: Exception Occurred");
            Console.WriteLine("Exception message: " + ex.Message);
        }

    }
}