// Author: Yanzhi Wang
// Purpose: Prompts user for name and calls GiveRaise() function to determine if they are eligible for a raise.
// Restrictions: None known.

using System;

class Program
{
    static void Main(string[] args)
    {
        string sName;
        double dSalary = 30000;

        // Prompt for user's name
        Console.WriteLine("What is your name?");
        sName = Console.ReadLine();

        // Call GiveRaise() function to determine if user is eligible for a raise
        if (GiveRaise(sName, ref dSalary))
        {
            Console.WriteLine("Congratulations! You got a raise!");
        }
        else
        {
            Console.WriteLine("Sorry, you are not eligible for a raise.");
        }

        // Display user's new salary
        Console.WriteLine("Your new salary is {0:C}", dSalary);
    }

    // Purpose: Increases the salary by $19,999.99 if the given name matches the author's name.
    // Restrictions: None known.
    static bool GiveRaise(string name, ref double salary)
    {
        const string AUTHOR_NAME = "Yanzhi Wang"; // replace with your  name
        const double RAISE_AMOUNT = 19999.99;

        // Check if name matches author's name
        if (name == AUTHOR_NAME)
        {
            // Give raise and return true
            salary += RAISE_AMOUNT;
            return true;
        }
        else
        {
            // Don't give raise and return false
            return false;
        }
    }
}
