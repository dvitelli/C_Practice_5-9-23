using System;
using System.Text;

namespace ExampleProject
{
    class Program
    {
        public static void Main(String[] args)
        {

            Console.WriteLine("\n Please enter a number: ");
            do
            {
                string userInput = Console.ReadLine();
                int number;

                if(!int.TryParse(userInput, out number))
                {
                    Console.ForegroundColor = ConsoleColor.Red; //set text to red
                    Console.WriteLine("You entered invlaid Input!");
                    Console.ResetColor();
                    Console.WriteLine("\n Please enter a number: ");

                }
                else
                {
                    Console.WriteLine("\n Thanks! Enter another number: ");
                }
            }while(true);

        }
    }
}
