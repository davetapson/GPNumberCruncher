using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPNumberCruncher
{
    public static class FileHandler
    {
        public static int GetNumberFromUser()
        {
            Console.WriteLine("Enter number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            return userNumber;
        }

        public static void CheckFileExists(string file)
        {
            if (!File.Exists(file))
                SaveNumber(file, 0);
        }

        public static int GetSavedNumber(string filePath)
        {
            try
            {
                StreamReader file = new(filePath);

                var line = file.ReadLine();

                file.Close();

                return Convert.ToInt32(line);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"GetSavedNumber - Error encountered: {ex.Message}");
                throw;
            }
        }

        public static void SaveNumber(string filePath, int number)
        {
            string path = filePath;

            using FileStream fileStream = File.OpenWrite(path);

            Byte[] info = new UTF8Encoding(true).GetBytes(number.ToString());

            fileStream.Write(info, 0, info.Length);
        }
    }
}
