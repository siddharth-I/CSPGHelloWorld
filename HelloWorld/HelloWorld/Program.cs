using System;
using System.Xml;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How's it going?");
            Console.WriteLine("Where are we at?");
            Console.WriteLine("Oh, I see.");
            Console.WriteLine("That's great!");
            Console.WriteLine("Let's continue.");

            Console.WriteLine();
            
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            string name = Console.ReadLine();
            Console.WriteLine("Noted: " + name + " got bread.");

            Console.WriteLine();

            Console.WriteLine("What kind of thing are we talking about?");

            // Thing type
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

            /* description */
            string b = Console.ReadLine();

            // "of Doom" text
            string c = " of Doom";

            /* the number */
            string d = "3000";

            Console.WriteLine("The " + b + " " + a  + c + " " + d + "!");
        }
    }
}
