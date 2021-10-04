using System;

namespace GPNumberCruncher
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = @"LastNumber.txt";

            FileHandler.CheckFileExists(fileName);

            int savedNumber = FileHandler.GetSavedNumber(fileName);
            int userNumber = NumberHandler.GetNumberFromUser();

            int result = NumberHandler.CrunchNumbers(savedNumber, userNumber);

            FileHandler.SaveNumber(fileName, result);

            // or, but this is a bit cryptic...
            //FileHandler.SaveNumber(
            //    fileName, 
            //    NumberHandler.CrunchNumbers(
            //        FileHandler.GetSavedNumber(fileName), 
            //        NumberHandler.GetNumberFromUser()));
        }
    }
}
