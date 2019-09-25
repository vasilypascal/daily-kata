using System;
using DailyKata.Katas;
using Xunit;

namespace DailyKata.Tests
{
    public class PolymorphicRefactoringKataTests
    {
        [Theory]
        [InlineData(JobTitle.Junior, 100)]
        [InlineData(JobTitle.Middle, 175)]
        [InlineData(JobTitle.Senior, 195)]
        [InlineData(JobTitle.Consultant, 215)]
        public void GetSalary_ForGrade_ExpectedSalary(JobTitle jobTitle, double expected)
        {
            var sut = new PolymorphicRefactoringKata(jobTitle);

            var actual = sut.GetSalary();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetSalary_ForUnknownGrade_ThrowsException()
        {
            var sut = new PolymorphicRefactoringKata(JobTitle.Unknown);

            Action act = () => sut.GetSalary();

            Assert.Throws<InvalidOperationException>(act);
        }

        [Fact]
        public void GetSalary_ForUnknownGrade_ThrowsExceptionWithMessage()
        {
            var sut = new PolymorphicRefactoringKata(JobTitle.Unknown);

            var exception = Record.Exception(() => sut.GetSalary());

            Assert.Equal("Invalid job title", exception.Message);
        }
    }
}
