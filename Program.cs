using System;
using System.Threading;

namespace NumericSystemConverter
{
    class Program
    {
        public static void Main(string[] args)
        {
            HeadStart();
            Thread.Sleep(-1);
        }

        static void HeadStart()
        {
            int base1 = 0;
            int base2 = 0;
            long number = 0;

            Console.WriteLine("Welcome! Please enter the base you want to convert from:\n");
            var bas1 = Console.ReadLine();

            Console.WriteLine("Please enter the number you want to convert:\n");
            var num = Console.ReadLine();

            Console.WriteLine("Please enter the base you want to convert to:\n");
            var bas2 = Console.ReadLine();

            try
            {
                base1 = Int32.Parse(bas1);
                base2 = Int32.Parse(bas2);
                number = Int64.Parse(num);
                
                var checkList = new int[num.ToString().Length];
                var checkNum = number;
                int c = 0;
                while (checkNum > 0)
                {
                    checkList[c] = (int)checkNum % 10;
                    checkNum /= 10;

                    if (checkList[c] > base1 - 1)
                    {
                        ErrorHandling.ErrorHandler(new DigitError("One or more digits are higher/equal to the first base given."));
                    } else { continue; }
                    c += 1;
                }

            }
            catch (Exception e)
            {
                ErrorHandling.ErrorHandler(e);
            }
            
            if (base1 == 10 && base2 != 10 && base1 > base2 && base2 > 2)
            {
                Converter.Method1(base1, (int)number, base2);
            } else if (base1 != 10 && base2 == 10)
            {
                Converter.Method2(base1, (int)number, base2);
            } else
            {
                if (base2 > 10) {
                    ErrorHandling.ErrorHandler(new BaseHigherThanDecimal("Base is higher than Decimal value"));
                } else if (base2 < 2 || base2 == 0)
                {
                    ErrorHandling.ErrorHandler(new BaseLessThanBinary("Base is less than Binary value"));
                } else
                {
                    Converter.Method3(base1, (int)number, base2);
                }
            }
        }
    }
}
