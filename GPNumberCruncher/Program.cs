namespace GPNumberCruncher
{
    class Program
    {
        static void Main()
        {
            const string fileName = @"LastNumber.txt";

            FileHandler.CheckFileExists(fileName);

            int savedNumber = FileHandler.GetSavedNumber(fileName);
            int userNumber = DisplayHandler.GetNumberFromUser();

            int result = NumberHandler.CrunchNumbers(savedNumber, userNumber);

            DisplayHandler.DisplayNumber(result);

            // or, but this is a bit cryptic...
            //DisplayHandler.DisplayNumber(
            //    NumberHandler.CrunchNumbers(
            //        FileHandler.GetSavedNumber(fileName), 
            //        DisplayHandler.GetNumberFromUser()
            //    )
            //);

            // spec says save this after display - there is an argument it would be better to save before display
            // because if the user closes the console by hitting the X instead of hitting another key, the value will not be saved.
            // we could catch the close event of the console to counter this, but that would be daft.
            FileHandler.SaveNumber(fileName, result);
        }
    }
}
