using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        float grade = float.Parse(Console.ReadLine());
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        else
        {
            letter = "Grade not defined";
        }


        if (grade%10 >= 7)
        {
            letter ="+"+letter;
        }
        else if(grade%10 < 4)
        {
            letter ="-"+letter;
        }

        Console.WriteLine($"The letter grade for {grade}% is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations, you've passed the class!");
        }
        else
        {
            Console.WriteLine($"Unfortunately, you did not pass the class. Don't be discouraged, but try again next time.");
        }


    }
}