using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_statements__for__foreach__while__do_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esiteks, me teeme muutuja (counter)
            //Teiseks, vaatame, kas meie muutuja vastab kriteeriumitele
            //Kolamdaks, kui vastab kriteeriumitele, siis käivitatakse kood for tsüklis
            //Siis suurendatakse või vähendatakse muutujat
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break; //Automaatselt lõpetab for loop'i töö. 
                }
            }
           
            //for code snippet => for + tab

            int[] numsArray = new int[] {2, 4, 6};

            int sum = 0; //Counteri tegemine

            foreach (int number in numsArray)
            {
                sum += number;
            }
            Console.WriteLine(sum);


            //Sõne ümberkeeramine.
            string zig = "VERY LOOOOOOOOOOOOOOOOOOOOOOOOONG TEXT";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (var zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            
            //Me kasutame while iteratsiooni, kui me ei tea, mitu korda tuleks koodiplokki korrata.
            //While tsükkel lõpetab töö, kui tingimus on saavutatud. Ex: Kasutaja sisestas õige parooli.

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            
            Console.ReadLine();
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("option 1");
            Console.WriteLine("option 2");
            Console.WriteLine("exit");

            string result = Console.ReadLine();
            if (result == "1")
            {
                return true;
            }
            else if (result == "2")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game!");

            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            //Do while tsükkel - do sees olev koodiplokk käivitatakse vähemalt ühe korra kindlasti

            do
            {
                Console.WriteLine("Guess a number between 0-10");
                string result = Console.ReadLine();
                guesses++;

                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong!");

            } while (incorrect); //Koodiplokki käivitatakse taas, kui kasutaja on incorrect.

            Console.WriteLine($"Correct! It took {guesses} guesses");
        }
    }
}
