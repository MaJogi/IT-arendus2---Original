using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program //NB: Program klassi meetodid peavad sisaldama static võtmesõna!
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            DisplayResult(ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city));

            Console.ReadLine();
        }

        private static string ReverseString(string messenge)
        {
            char[] messageArray = messenge.ToCharArray();
            Array.Reverse(messageArray);
            //String.Concat teeb arrayst või listi elementidest ühe suure sõne.
            return String.Concat(messageArray); 
        }

        private static void DisplayResult(string reversedFirstName,
            string reversedLastName,
            string reversedCity)
        {
            Console.Write("Results: ");
            //string format ehitab üles uue sõne kasutades uut formaati, mille me ise sisestame.
            Console.Write(String.Format($"{reversedFirstName} {reversedLastName} {reversedCity}"));
        }
    }
}
