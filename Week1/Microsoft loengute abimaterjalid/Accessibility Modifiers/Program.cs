using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Accessibility_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Private, Public, Internal, Protected, External, Internal protected, protected internal etc;

            WebClient client = new WebClient();
            //Salvestab kogu veebilehe sisu string'i.
            string reply = client.DownloadString("http://msdn.microsoft.com");

            //Faili salvestamine
            File.WriteAllText(@"C:\Lesson17\WriteText.txt", reply);

           
        }
    }
}
