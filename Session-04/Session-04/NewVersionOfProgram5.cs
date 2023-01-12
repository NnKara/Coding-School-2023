using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class NewVersionOfProgram5
    {

        int seconds = 45678;

        public void operatingSeconds()
        {
            Console.WriteLine("//    Program Number  #6      //\n");

            TimeSpan time=TimeSpan.FromSeconds(seconds);
            int minutes = (int)time.TotalMinutes;
            int hours = (int)time.TotalHours;
            int days = (int)time.TotalDays;
            int years = days * 365;


            Console.WriteLine("Seconds are: " + seconds +
                              "\n Seconds converted to Minutes are: " + minutes +
                              "\n Seconds converted to Hours are: " + hours +
                              "\n Seconds converted to Days are: " + days +
                              "\n Seconds converted to Years are: " + years);
        }
    }
}
