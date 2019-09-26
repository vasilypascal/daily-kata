using System;
using System.Collections.Generic;

namespace DailyKata
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //----------------CALCULATOR-----------------------------------------------------------------------------
            //--------------initialization---------------------
            string input1 = "2";
            string input2 = "3,5";
            string input3 = "20,5,5";
            string input4 = "10.23,2,20,8";
            Action act2 = () => StringCalculatorKata.Calculate(string.Empty);
            Action act3 = () => StringCalculatorKata.Calculate(default(string));

            //-----------------checking------------------------
            Console.WriteLine("Sum = " + StringCalculatorKata.Calculate(input1));
            Console.WriteLine("Sum = " + StringCalculatorKata.Calculate(input2));
            Console.WriteLine("Sum = " + StringCalculatorKata.Calculate(input3));
            Console.WriteLine("Sum = " + StringCalculatorKata.Calculate(input4));
            try
            {
                act2();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("ArgumentException catched!");
            }
            try
            {
                act3();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException catched!");
            }

            //---------------------------POLYMORPHIC REFACTORING--------------------------
            



            
            Console.ReadKey();
        }
    }
}
