using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace Events_and_Event_Driven_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000); //Iga 2 millisekundi tagant käivitatakse ´.

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start(); //Timeri käivitamine

            Console.WriteLine("Vajutage enter, et eemaldada punane event.");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1; //Eemaldab event'i

            Console.ReadLine();
        }
        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Aega möödunud: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Aega möödunud: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
   
}
