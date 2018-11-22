using System;

namespace EventSimple
{
    class Program
    {
        public static void Main()
        {
            try
            {
                //...
            }
            catch(Exception ex)
            {
                if ( ex is FormatException || ex is InvalidCastException || ex is DivideByZeroException)
                {
                    return;
                }
                throw;
            }
        }
        
    }
}