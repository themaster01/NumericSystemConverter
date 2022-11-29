using System;
using System.Collections.Generic;
using System.Text;

namespace NumericSystemConverter
{
    public class Errors
    { }

    public class DigitError : Exception 
    {
        public DigitError() { }

        public DigitError(string message) : base(message) { }

    }

    public class BaseHigherThanDecimal : Exception
    {
        public BaseHigherThanDecimal() { }

        public BaseHigherThanDecimal(string message) : base(message) { }

    }

    public class BaseLessThanBinary : Exception
    {
        public BaseLessThanBinary() { }
        
        public BaseLessThanBinary(string message) : base(message) { }

    }
}
