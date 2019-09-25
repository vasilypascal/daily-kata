using System;
using Xunit;

namespace DailyKata.Tests
{
    public class StringCalculatorKataTests
    {
        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("32", 32)]
        [InlineData("7.391", 7.391d)]
        public void Calculate_SingleNumber_ReturnsSingleNumber(string input, double expected)
        {
            var actual = StringCalculatorKata.Calculate(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,3", 5)]
        [InlineData("2,9", 11)]
        [InlineData("8.23,1.379", 9.609d)]
        public void Calculate_TwoNumbers_ReturnsSumOfNumbers(string input, double expected)
        {
            var actual = StringCalculatorKata.Calculate(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1,2,3,4,5,6,7", 28)]
        [InlineData("2,9,5,20,8,16", 60)]
        [InlineData("8.23,1.379,5,30,999", 1043.609d)]
        public void Calculate_MultipleNumbers_ReturnsSumOfNumbers(string input, double expected)
        {
            var actual = StringCalculatorKata.Calculate(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1, 2,3 ,4 ,5,6, 7", 28)]
        [InlineData(" 2,9 ,5,20, 8,16 ", 60)]
        [InlineData("8.23, 1.379,5, 30,999.2,73.81 ", 1117.619d)]
        public void Calculate_MultipleNumbers_WithSpaces_ReturnsSumOfNumbers(string input, double expected)
        {
            var actual = StringCalculatorKata.Calculate(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(",\n1,2,3,4,5,6,7", 28)]
        [InlineData("|\n2|9|5|20|8|16", 60)]
        [InlineData(";\n8.23;1.379;5,30;999", 1043.609d)]
        public void Calculate_MultipleNumbers_WithDifferentSeparators_ReturnsSumOfNumbers(string input, double expected)
        {
            var actual = StringCalculatorKata.Calculate(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("-13")]
        [InlineData("3,-7")]
        [InlineData("-2, 7, 42,98, -901 ")]
        [InlineData(";\n-5; 8; 51;43; -101 ")]
        public void Calculate_NegativeNumbers_TrowsArgumentException(string input)
        {
            Action act = () => StringCalculatorKata.Calculate(input);

            Assert.Throws<ArgumentException>("input", act);
        }

        [Theory]
        [InlineData("-13")]
        [InlineData("3,-7")]
        [InlineData("-2, 7, 42,72, -105 ")]
        [InlineData(";\n-5; 8; 51;98; -901 ")]
        public void Calculate_NegativeNumbers_TrowsArgumentExceptionWithMessage(string input)
        {
            var exception = Record.Exception(() => StringCalculatorKata.Calculate(input));

            Assert.Equal("Negative numbers not supported", exception.Message);
        }

        [Fact]
        public void Calculate_WhiteSpace_ThrowsException()
        {
            Action act = () => StringCalculatorKata.Calculate("       ");

            Assert.Throws<ArgumentException>("input", act);
        }

        [Fact]
        public void Calculate_EmptyString_ThrowsException()
        {
            Action act = () => StringCalculatorKata.Calculate(string.Empty);

            Assert.Throws<ArgumentException>("input", act);
        }

        [Fact]
        public void Calculate_NullString_ThrowsException()
        {
            Action act = () => StringCalculatorKata.Calculate(default(string));

            Assert.Throws<ArgumentNullException>("input", act);
        }
    }
}
