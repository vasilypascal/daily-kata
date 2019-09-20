using System;
using Xunit;

namespace DailyKata.Tests
{
    public class StringCalculatorKataTests
    {
        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("-32", -32)]
        public void Calculate_SingleNumber_ReturnsSingleNumber(string input, int expected)
        {
            var actual = StringCalculatorKata.Calculate(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,3", 5)]
        [InlineData("2,-9", -7)]
        public void Calculate_TwoNumbers_ReturnsSumOfNumbers(string input, int expected)
        {
            var actual = StringCalculatorKata.Calculate(input);

            Assert.Equal(expected, actual);
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
