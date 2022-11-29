using System;
using System.Linq;

namespace NumericSystemConverter
{
    class Converter
    {
        public static int Method1(int a, int num, int b)
        {
            string result = "";
                while (num >= b)
                {
                    Console.WriteLine($"\n{num / b}      {num % b}");
                    result += (num % b).ToString();
                    num /= b;
                    if (num < b)
                    {
                        result += (num % b).ToString();
                        Console.WriteLine($"\n{num / b}      {num % b}");
                        Console.WriteLine($"The final result is: {new string (result.Reverse().ToArray())}");
                    }
                }
            return Int32.Parse(result);
        }
    
        public static int Method2(int a, int num, int b)
        {
                int[] list = new int[num.ToString().Length];
                int res = num;
                var result = 0;
                int i = 0;

                while (res > 0)
                {
                    list[i] = res % 10;
                    res /= 10;
                     
                    string addition = (res <= 0) ? "" : "+";
                    Console.WriteLine($"Number{i}: {a}^({i}) * {list[i]} = {Math.Pow(a, i) * list[i]}" + $" {addition}");
                    result += (int)Math.Pow(a, i) * list[i];

                    if (res <= 0)
                    {
                    Console.WriteLine($"The final result is: {result}");
                    }
                    i += 1;
                }
            return result;
        }
        
        public static void Method3(int a, int num, int b)
        {
            Console.WriteLine($"Convertion from {a} to 10:\n");
            
            var num1 = Method2(a, num, b);
            
            Console.WriteLine($"First we converted from base {a} to base 10 which resulted in {num1}");
            Console.WriteLine($"Convertion from 10 to {b}:\n");
            
            var num2 = Method1(a, num1, b);
            
            Console.WriteLine($"The final number after conversion: {num2}");
        }
    }
}
