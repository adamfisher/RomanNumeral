using FluentAssertions;
using Xunit;

namespace RomanNumerals.Tests
{
    public class ConversionTests
    {
        #region Tests

        [Theory]
        [MemberData(nameof(RomanNumeralTestValuesDataSource.ListOfAllSupportedRomanNumerals), 
            MemberType = typeof(RomanNumeralTestValuesDataSource))]
        public void ConvertingNumericValuesToRomanNumerals(int expectedNumber, string expectedRomanNumeral)
        {
            var numeral = new RomanNumeral(expectedNumber).ToString();
            numeral.Should().BeEquivalentTo(expectedRomanNumeral);
        }

        [Theory]
        [MemberData(nameof(RomanNumeralTestValuesDataSource.ListOfAllSupportedRomanNumerals),
            MemberType = typeof(RomanNumeralTestValuesDataSource))]
        public void ConvertingRomanNumeralsToNumericValues(int expectedNumber, string expectedRomanNumeral)
        {
            var numeral = new RomanNumeral(expectedNumber).ToInt();
            numeral.Should().Be(expectedNumber);
        }

        #endregion
    }
}
