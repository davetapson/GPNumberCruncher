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
    }
}
