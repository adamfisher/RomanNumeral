using System;
using FluentAssertions;
using Xunit;

namespace RomanNumerals.Tests
{
    public class MathTests
    {
        #region Fields & Properties

        private readonly int _firstNumber;
        private readonly int _secondNumber;
        private readonly RomanNumeral _firstRomanNumeral;
        private readonly RomanNumeral _secondRomanNumeral;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MathTests"/> class.
        /// </summary>
        public MathTests()
        {
            var random = new Random(DateTime.Now.Millisecond);

            _firstNumber = random.Next(1, 39);
            _secondNumber = random.Next(50, 100);

            _firstRomanNumeral = new RomanNumeral(_firstNumber);
            _secondRomanNumeral = new RomanNumeral(_secondNumber);
        }

        #endregion

        #region Tests

        [Fact]
        public void Multiply()
        {
            var expectedResult = _firstNumber * _secondNumber;
            var result = _firstRomanNumeral * _secondRomanNumeral;

            result.ToInt().Should().Be(expectedResult);
        }

        [Fact]
        public void Divide()
        {
            var expectedResult = _secondNumber / _firstNumber;
            var result = _secondRomanNumeral / _firstRomanNumeral;

            result.ToInt().Should().Be(expectedResult);
        }

        [Fact]
        public void Add()
        {
            var expectedResult = _firstNumber + _secondNumber;
            var result = _firstRomanNumeral + _secondRomanNumeral;

            result.ToInt().Should().Be(expectedResult);
        }

        [Fact]
        public void Subtract()
        {
            var expectedResult = _secondNumber - _firstNumber;
            var result = _secondRomanNumeral - _firstRomanNumeral;

            result.ToInt().Should().Be(expectedResult);
        }

        #endregion
    }
}
