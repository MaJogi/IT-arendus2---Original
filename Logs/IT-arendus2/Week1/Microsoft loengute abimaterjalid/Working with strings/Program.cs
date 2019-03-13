using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "My \"so-called\" Life"; 
            //Kasuta \ character'i jutumärkide lisamiseks "". Samuti saab ka teise characteri samuti lisada.
            // \n selleks, et alustada kirjutamist uuest reast.

            string myString2 = @"Go to your c:\drive"; //Kasuta @ märki selleks, et kasutada "\" tekstis.

            //String.Format("insert text") to create a new string out of smth.
            //Use :C in text to show your region currency in cmd.
            //To add decimal points and commas to currency, use :N
            //To display number as a percentage use :P.

            string myString3 = "  That summer we took threes across the board  ";
            //myString.Replace(" ", "--");
            //myString.Remove(6, 14);
            //myString.Trim() selleks, et eemaldada tühikud sõne eest ja tagant.


            //Mitteefektiivne viis stringi ülesehituseks.
            string myString4 = "";
            for (int i = 0; i < 100; i++)
            {
                myString4 += "--" + i.ToString();
            }

            //Efektiivne viis stringi ülesehituseks.
            StringBuilder myString5 = new StringBuilder();

            for (int i = 0; i < 100; i++) 
            {
                //Sellist viisi kasutades runtime ei pea tegema rohkesti temp muutujaid sõnest, mille tõttu programmi kiirus tõuseb.
                myString5.Append("--");
                myString5.Append(i);
            }
        }
    }
}
