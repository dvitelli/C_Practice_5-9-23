using System;
using System.Text;

namespace ExampleProject
{
    class Program
    {
        public static void Main(String[] args)
        {
            ConsoleKeyInfo keyInfo;
            Console.TreatControlCAsInput = true; // stops control c from closing console

            do
            {
                keyInfo = Console.ReadKey();

                if((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
                    Console.Write("ALT+"); 

                if((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                    Console.Write("SHIFT+");

                if((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                    Console.Write("CTL+");

            } while (keyInfo.Key != ConsoleKey.Escape);

        }
    }
}
