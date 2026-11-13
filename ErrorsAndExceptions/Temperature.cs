using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorsAndExceptions
{
    public class Temperature
    {
        public double temp;

        public void DisplayTemp()
        {
            if (temp != 0)
            {
                Console.WriteLine(temp);
            }
            else
                throw new TempIsZeroException("Temperatura este zero");
        }
    }

    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {

        }
    }
}
