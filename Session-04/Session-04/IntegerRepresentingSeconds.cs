using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class IntegerRepresentingSeconds
    {
        public void  represantation() {
            Console.WriteLine("//    Program Number  #5      //\n");

            int seconds = 45678;
            int minutes = seconds / 60;
            int hours= seconds / 3600;
            int days= seconds / 86400;
            int years = seconds /(86400* 365);

            Console.WriteLine("Seconds are: " + seconds +
                              "\n Seconds converted to Minutes are: " + minutes +
                              "\n Seconds converted to Hours are: " + hours +
                              "\n Seconds converted to Days are: " + days +
                              "\n Seconds converted to Years are: " + years);
                              

        }
    }
}
