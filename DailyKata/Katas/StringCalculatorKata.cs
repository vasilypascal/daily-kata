using System;
using System.Linq;
using System.Text;

namespace DailyKata
{
    public class StringCalculatorKata
    {
        public static double Calculate(string input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            if (input == string.Empty || input.All(c => c.Equals(' '))) 
                throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
            if (ContainsNegativeNumbers(input))
                throw new ArgumentException("Negative numbers not supported", nameof(input));

            double result = 0;
            string[] stringNumbers;
            char[] delimiter = new char[] { ',' };
            stringNumbers = Parse(input).Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            foreach (string number in stringNumbers)
                result += Convert.ToDouble(number);
            return result;
        }

        public static string Parse(string input) // Parsing any symbols (except [0-9] '-', '.') to ','
        {
            char[] charArray = input.ToCharArray();
            StringBuilder stringBuilder = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                if ((charArray[i] > 47 && charArray[i] < 58) || charArray[i] == '-' || charArray[i] == '.')
                    stringBuilder.Append(charArray[i]);
                else stringBuilder.Append(',');
            }
            return stringBuilder.ToString();
        }

        public static bool ContainsNegativeNumbers(string input) // Checking if string contains negative numbers
        {
            foreach (char c in input)
                if (c == '-')
                    return true;
            return false;
        }


        ////------Unfinished Regex variant (still to read about it)
        //input.ToCharArray();
        //string[] regNumbers = Regex.Split(input, @"[0-9. ]");

        //var charArray = input.ToCharArray();
        //for(int i=0; i <charArray.Length;i++)
        //{
        //    if (charArray[i] < (char)48 || charArray[i] > (char)57 && charArray[i] != (char)46) 
        //    {
        //        charArray[i] = ',';
        //    }
        //}
    }
}
