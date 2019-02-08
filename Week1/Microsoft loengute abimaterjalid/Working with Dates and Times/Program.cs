using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Dates_and_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datetime = DateTime.Now; //Objekti loomine, mis sisaldab endast praegust aega.
            datetime.ToShortDateString(); //month, day, year
            datetime.ToShortTimeString(); //16:00

            datetime.ToLongDateString(); //Tuesday, march 15, 2016
            datetime.ToLongTimeString(); //3:36:35 PM (seconds included)  
            
            datetime.AddDays(3).ToLongDateString(); //lisa kolm päeva DateTime'ile
            datetime.AddDays(-3).ToLongDateString();//eemalda kolm päeva.

            //myValue.Month Väärtused 1st 12ni.

            //Tuleviku või mineviku aja loomine.
            DateTime myBirthday = new DateTime(1959, 12, 7);

            DateTime myBirthday2 = DateTime.Parse("12/7/1969"); //Loob DateTime objekti, kui võimalik sõnest.

            //object that represents the span of time
            TimeSpan myAge2 = DateTime.Now.Subtract(myBirthday);
            myAge2.TotalDays.ToString(); //näitab, mitu päeva on möödunud teatud ajahetkest.
        }
    }
}
