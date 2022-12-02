using System;
using static FindFactorialException.FindFact;

namespace FindFactorialException {
    class Program {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(CalcFact(-99));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

    }
}
