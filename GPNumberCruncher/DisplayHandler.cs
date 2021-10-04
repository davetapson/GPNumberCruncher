using System;

namespace GPNumberCruncher
{
    public static class DisplayHandler
    {
        public static int GetNumberFromUser()
        {
            Console.WriteLine("Type in a number and then press Enter:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            return userNumber;
        }

        public static void DisplayNumber(int number)
        {
            Console.WriteLine(number);
            Console.Read();
        }
    }
}
