using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_decision_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ühe rea tingimuslik avaldis.
            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            //Kui tingimus on tõene, siis määra muutujale esimene väärtus, else teine.
            string message = (userValue == "1") ? "boat" : "strand of lint"; 

            Console.WriteLine($"You won a {message}");


            //Kuidas ifs, else-ifs ja else töötab.

            Console.WriteLine("Bob's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string userValue2 = Console.ReadLine();

            if (userValue2 == "1")
            {
                string message2 = "You won 1";
            }
            else if (userValue2 == "2")
            {
                string message2 = "You won 2";
            }
            else if (userValue2 == "3")
            {
                string message2 = "You won 3";
            }
            else
            {
                string message2 = "Vabandage, programm ei saanud aru.";
            }

            if (true) 
            {
                
            }
            if (true) 
            {

            }
        }
    }
}
