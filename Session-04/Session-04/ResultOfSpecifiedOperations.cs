using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ResultOfSpecifiedOperations
    {
        public String firstBullet()
        {
            Console.WriteLine("//    Program Number  #3      //\n");
            int a = -1;
            int b = 5;
            int c = 6;

            int calculationResult = (b * c) + a;
            String firstBulletResult = ("First bullet's result is: " + calculationResult);
            return firstBulletResult;
        }

        public String secondBullet()
        {
            int a = 38;
            int b = 5;
            int c = 7;

            int calculationResult = (b % 7) + a;
            String secondBulletResult = ("Second bullet's result is: " + calculationResult);
            return secondBulletResult;
        }
        
        public String thirdBullet()
        {
            int a = 14;
            int b = -3;
            int c = 6;
            int d = 7;

            int calculationResult = ((b * c) / d) + a;
            String thirdBulletResult = ("Third bullet's result is: " + calculationResult);
            return thirdBulletResult;
        }
        
        public String fourthBullet()
        {
            int a = 2;
            int b = 13;
            int c = 6;
            int d = 6;
            double e =Math.Floor(Math.Sqrt(7));

            double calculationResult = ((b / c) * d) + a + e;
            String fourthBulletResult = ("Fourth bullet's result is: " + calculationResult);
            return fourthBulletResult;
        } 
        
        public String fifthBullet()
        {
            double a = Math.Pow(6,4);
            double b = Math.Pow(5,7);
            int c = 9%4;


            double calculationResult = (a + b) / c;
            String fifthBulletResult = ("Fifth bullet's result is: " + calculationResult);
            return fifthBulletResult;
        }
    }
}
