using System;
using System.Collections.Generic;
using System.Text;

namespace FindFactorialException.Exceptionnn {
    public class NotFact :Exception {
        public NotFact(string message) : base(message)
        {

        }
    }
}
