using System;

namespace Exercise8
{
    class Program
    {
        /*
         Write a console-based application that prompts a user for an hourly pay rate. While the user 
         enters values less than $5.65 or greater than $49.99, continue to prompt the user. Before the 
         program ends, display the valid pay rate.
        */
        static void Main(string[] args)
        {

            string a = "y";

            while (a == "y")
            {
                Console.WriteLine("Plase input your hourly pay rate: ");
                double pay = Convert.ToDouble(Console.ReadLine());

                while ((pay < 5.65) || (pay > 49.99))
                {
                   Console.WriteLine("\nSorry something is wrong. Please try again: ");
                   Console.WriteLine("\nPlase input your hourly pay rate: ");
                   pay = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                }

                Console.WriteLine("\nYou pay rate of "+ pay+ " is valid.");


                Console.WriteLine("Do you wanna input another pay rate? \nPlease press y to yes or other to no");
                a = Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
