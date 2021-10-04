using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPNumberCruncher
{
    public static class NumberHandler
    {
        public static int CrunchNumbers(int savedNumber, int userNumber)
        {
            int total = savedNumber + userNumber;

            if (total > 152)
            {
                total -= 152;
            }

            return total;

            // or 
            //return total > 152 ? total - 152 : total;
        }

        public static int GetNumberFromUser()
        {
            Console.WriteLine("Type in a number and then press Enter:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            return userNumber;
        }
    }
}
