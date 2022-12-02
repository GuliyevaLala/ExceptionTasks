using FindFactorialException.Exceptionnn;
using FindFactorialException.Exceptionnn.ExceptionMessage;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindFactorialException {
    public class FindFact {
        public static int? CalcFact(int num)
        {

            int result = 1;

            if (num < 0)
            {
                throw new NotFact(ExceptionMessage.NotFact);
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    result *= i;

                }
                return result;
            }
        }

    }
}
