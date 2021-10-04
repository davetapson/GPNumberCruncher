using System;
using System.IO;
using System.Text;

namespace GPNumberCruncher
{
    public static class FileHandler
    {
        public static void CheckFileExists(string file)
        {
            if (!File.Exists(file))
                SaveNumber(file, 0);
        }

        public static int GetSavedNumber(string file)
        {
            try
            {
                StreamReader streamReader = new(file);

                var line = streamReader.ReadLine();

                streamReader.Close();

                return Convert.ToInt32(line);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"GetSavedNumber from {file} - Error encountered: {ex.Message}");
                throw;
            }
        }

        public static void SaveNumber(string filePath, int number)
        {
            using FileStream fileStream = File.OpenWrite(filePath);

            Byte[] bytes = new UTF8Encoding(true).GetBytes(number.ToString());

            fileStream.Write(bytes, 0, bytes.Length);

            fileStream.Close();
        }
    }
}
