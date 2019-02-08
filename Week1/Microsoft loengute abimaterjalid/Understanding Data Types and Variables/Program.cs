using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muutuja loomine : Annan käsu .NET framework'ile mälu eraldamiseks kindla muutuja tüübi jaoks.

            //-----Numbriline-----

            sbyte i = 127; //-128 to 127

            byte e = 255; //0 to 255

            short j = 32767; //-32,768 to 32,767

            ushort m = 65535; //0 to 65,535

            int a; //-2bil to 2bil

            uint k = 4294967295; //0 - 4,294,967,295

            long h = -9223372036854775808; //-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            ulong l = 18446744073709551615; //0 to 18,446,744,073,709,551,615

            decimal g = 9995555555555555555; //Ainult positiivsed numbrid! 0 - 9999999999999999999
            
            //-----Komakohaga-----

            double b = 2.555555555555555; //komakohaga arv, näitab maksimaalselt 15 kohta peale koma.

            float c = 12345678902526772453; //1.234568E+19, näitab ühe täisosa ja seejärel 6 komakohta + E.

            //-----Non numeric-----

            char f = 'Ä'; //Unicode char, numbrid, special chars ja tähed. NB: Ainult üksik väärtus!

            string n = "sõne";

            bool d = true; //Saab olla kas true või false. Enamasti kasutatakse neid iteratsioonides, if'ides ja switch'is.

            //StreamWriter writer = new StreamWriter(@"C:\Users\TiitJaTeet\source\repos\IT-arendus2\UnderstandingDataTypesandVariables\bin\Debug");
            //*object d;

            Console.WriteLine(b);
            Console.ReadLine();
  
        }
    }
}
