

using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What's your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);


    if (grade >= 90)
        {
            Console.WriteLine("Congratulactions! Your grade is A! You pass the class!");
        }
    else if (grade >= 80 && grade <= 89)
        {
            Console.WriteLine("Congratulactions! Your grade is B! You pass the class!");
        }
    else if (grade >= 70 && grade <= 79)
        {
            Console.WriteLine("Congratulactions! Your grade is C! You pass the class!");
        }
    else if (grade >= 60 && grade <= 69)
        {
            Console.WriteLine("Sorry! You couldn't get through. Try better next time. Your grade is D!");
        }
    else if (grade <= 59)
        {
            Console.WriteLine("Sorry! You couldn't get through. Try better next time. Your grade is F!");
        }
    }
}