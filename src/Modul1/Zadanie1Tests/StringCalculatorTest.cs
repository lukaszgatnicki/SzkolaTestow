using System;
using Xunit;
using Zadanie1;

namespace Zadanie1Tests
{
    public class StringCalculatorTest
    {
        private StringCalculator _calculator;

        public StringCalculatorTest()
        {
            _calculator = new StringCalculator();
        }

        [Fact]
        public void ShouldReturnZeroWhenEmptyStringInputGiven()
        {
            //Given
            string input = string.Empty;

            //When
            int result = _calculator.Add(input);

            //Then
            Assert.Equal(0, result);
        }

        [Fact]
        public void ShouldReturnZeroWhenOnlyWhiteSpacesStringInputGiven()
        {
            //Given
            string input = "  ";

            //When
            int result = _calculator.Add(input);

            //Then
            Assert.Equal(0, result);
        }

        [Fact]
        public void ShouldReturnZeroWhenNullInputGiven()
        {
            //Given
            string input = null;

            //When
            int result = _calculator.Add(input);

            //Then
            Assert.Equal(0, result);
        }

        [Fact]
        public void ShouldThrowExceptionWhenInputStringContainsOnlyCommas()
        {
            //Given
            string input = ",";

            //When
            //Then
            Assert.Throws<FormatException>(() => _calculator.Add(input));
        }

        [Theory]
        [InlineData("asd")]
        [InlineData("1,2,asd")]
        [InlineData("1.2.3")]
        public void ShouldThrowExceptionWhenInputStringContainsNonNumericOrNonCommaChars(string input)
        {
            //Given
            //input

            //When
            //Then
            Assert.Throws<FormatException>(() => _calculator.Add(input));
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("1,2,3", 6)]
        [InlineData("-1,-2,-3", -6)]
        [InlineData("1,2,-3", 0)]
        [InlineData("1,2,3,4,5,6", 21)]
        [InlineData("100,200,300", 600)]
        public void ShouldReturnSummedUpValueWhenCommaSeparatedNumbersInputGiven(string input, int expected)
        {
            //Given
            //input 

            //When
            int result = _calculator.Add(input);

            //Then
            Assert.Equal(expected, result);
        }
    }
}
