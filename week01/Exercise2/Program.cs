using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage?");
        string userinput = Console.ReadLine();
        int percentage = int.Parse(userinput);

        string letter = "";


        if (percentage >= 90) 
        
        {
            letter = "A";
        }
        else if (percentage >= 80) 
        
        {
            letter = "B";
        }
        else if (percentage >= 70) 
        
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        
        Console.WriteLine($"Your grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you have passed this term.");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't make it this term. Please try again next term.");
        }
    }
}