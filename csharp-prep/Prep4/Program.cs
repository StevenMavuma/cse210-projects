using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");

        var positiveNumbers = numbers.Where(n => n > 0);
        var sortedNumbers = numbers.OrderBy(n => n);

        Console.WriteLine($"The smallest positive number is: {positiveNumbers.Min()}");

        foreach(int num in sortedNumbers)
        {
            Console.WriteLine(num);
        }
    }
}