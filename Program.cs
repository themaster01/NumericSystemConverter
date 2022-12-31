using System;
using System.Threading;

namespace NumericSystemConverter
{
    class Program
    {
        // First we start our program with our beautiful Key-to-the-main-door function, main.
        public static void Main()
        {
            HeadStart();
            while (true)
            {
                Console.WriteLine("I guess we're done here! Do you want to start over and convert another number?");
                if (Console.ReadLine() == "yes")
                {
                    HeadStart();
                } else { break; }
            }
        }

        static void HeadStart()
        {
            // Here I defined 3 variables for later use as Console.WriteLine() is only stored as string, therefore gotta try converting and adding to new values to start the checking process

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
                // Here I put these in a try-catch statement in case of a runtime that's going to happen in the case of having invalid inputs in there program

                base1 = Int32.Parse(bas1);
                base2 = Int32.Parse(bas2);
                number = Int64.Parse(num);
                
                // Here I must test and check if given values are correct according to the actual numeric system, by checking each digit that is and is not higher than the actual given (converting from) base value

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
            
            // The point of this is to make a specific method to convert numbers to decimal and so on. using these if conditions to ensure the functionality and accuracy of the program, and that it's not just doing numbers for no reason
            // I am using Custom-created exceptions, only to display reasonable errors to the end-user. To see them, lease go to Errors.cs

            if (base1 == base2)
            {
                Console.WriteLine("Are you trying to convert the same base to the same base? We will start over...\n");
                Thread.Sleep(3000);
                Console.Clear();
                Main();
            }
            else if (base1 == 10 && base2 != 10 && base1 > base2 && base2 > 2)
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
