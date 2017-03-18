using System.Collections.Generic;
using Machine.Specifications;

namespace RomanNumerals.Tests
{
    /// <summary>
    /// Numeric to roman numeral
    /// </summary>
    [Tags("Conversion")]
    [Subject(typeof(RomanNumerals.RomanNumeral))]
    public class When_converting_numeric_values_to_roman_numerals
    {
        protected static int ExpectedNumber;
        protected static string InvalidNumeral, ExpectedNumeral;
        protected static IDictionary<int, string> NumeralMappings;

        private Establish context = () =>
        {
            NumeralMappings = TestUtils.GetTestData();
        };

        private Because test = () =>
        {
            foreach (var number in NumeralMappings.Keys)
            {
                var numeral = new RomanNumerals.RomanNumeral(number).ToString();
                var expectedNumeral = NumeralMappings[number];

                if (!numeral.Equals(expectedNumeral))
                {
                    ExpectedNumber = number;
                    InvalidNumeral = numeral;
                    ExpectedNumeral = expectedNumeral;
                    break;
                }
            }
        };

        private It Conversion_of_ExpectedNumber = () => ExpectedNumber.ShouldEqual(0);

        private It Conversion_of_InvalidNumeral = () => InvalidNumeral.ShouldBeNull();

        private It Conversion_of_ExpectedNumeral = () => ExpectedNumeral.ShouldBeNull();
    }


    /// <summary>
    /// Roman numeral to numeric
    /// </summary>
    [Tags("Conversion")]
    [Subject(typeof(RomanNumerals.RomanNumeral))]
    public class When_converting_roman_numerals_values_to_numeric
    {
        protected static int InvalidNumber;
        protected static string ExpectedNumeral;
        protected static IDictionary<int, string> NumeralMappings;

        private Establish context = () =>
        {
            NumeralMappings = TestUtils.GetTestData();
        };

        private Because test = () =>
        {
            foreach (var expectedNumeral in NumeralMappings.Values)
            {
                var convertedNumber = new RomanNumerals.RomanNumeral(expectedNumeral).ToInt();

                if (!NumeralMappings[convertedNumber].Equals(expectedNumeral))
                {
                    InvalidNumber = convertedNumber;
                    ExpectedNumeral = expectedNumeral;
                    break;
                }
            }
        };

        private It Conversion_of_InvalidNumber = () => InvalidNumber.ShouldEqual(0);

        private It Conversion_of_ExpectedNumeral = () => ExpectedNumeral.ShouldBeNull();
    }
}
