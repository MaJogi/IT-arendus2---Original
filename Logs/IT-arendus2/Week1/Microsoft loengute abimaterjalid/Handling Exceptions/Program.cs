using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handling_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alati mõtle läbi stsenaariumid, kus võib programm katki minna.
            //Tee enda kood kuulikindlaks ja et see töötaks igas olukorras.
            try
            {
                string content = File.ReadAllText(@"C:\Users\TiitJaTeet\Desktop\fail.txt");
                Console.WriteLine(content);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Meil on probleem!");
                Console.WriteLine("Tee kindlaks, et faili nimi on sisestatud õigesti: Exampl.txt");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Meil on probleem!");
                Console.WriteLine(@"Tee kindlaks, et dictionary C:\TiitJaTeet eksisteerib.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Meil on probleem!");
                Console.WriteLine(ex.Message);
            }
            finally //Finally koodiplokk käivitatakse alati lõpus, näiteks selleks, et koristada programmi järel. Nt muutujad viia algsesse olukorda tagasi.
            {
                // Programmi lõpetamise kood
                // Objektide määramine null'iks.
                // Andmebaasiühenduste sulgemine
                Console.WriteLine("Closing application now ...");
            }
            Console.ReadLine();
        }
    }
}
