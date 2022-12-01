using System;
using System.Collections.Generic;
using System.Text;

namespace NumericSystemConverter
{
    public class Errors
    { }

    // I might have messed things a little but since i'm not making a lot of properties for each exception I put them all in the same file.

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
