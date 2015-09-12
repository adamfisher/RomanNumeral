using System;
using Machine.Specifications;

namespace RomanNumeral.Tests
{
    /// <summary>
    /// Multiplication
    /// </summary>
    [Tags("Math")]
    [Subject(typeof(RomanNumeral))]
    public class When_multiplying_two_numbers
    {
        protected static int expectedResult;
        protected static RomanNumeral numberOne, numberTwo, result;

        private Establish context = () =>
        {
            var random = new Random(DateTime.Now.Millisecond);
            var first = random.Next(50, 100);
            var second = random.Next(1, 39);

            numberOne = new RomanNumeral(first);
            numberTwo = new RomanNumeral(second);
            expectedResult = first * second;
        };

        private Because test = () =>
        {
            result = numberOne * numberTwo;
        };

        private It Should_have_an_equivalent_result_to_the_expected_result =
            () => result.ToInt().ShouldEqual(expectedResult);
    }

    /// <summary>
    /// Division
    /// </summary>
    [Tags("Math")]
    [Subject(typeof(RomanNumeral))]
    public class When_dividing_two_numbers
    {
        protected static int expectedResult;
        protected static RomanNumeral numberOne, numberTwo, result;

        private Establish context = () =>
        {
            var random = new Random(DateTime.Now.Millisecond);
            var first = random.Next(50, 100);
            var second = random.Next(1, 39);

            numberOne = new RomanNumeral(first);
            numberTwo = new RomanNumeral(second);
            expectedResult = first / second;
        };

        private Because test = () =>
        {
            result = numberOne / numberTwo;
        };

        private It Should_have_an_equivalent_result_to_the_expected_result =
            () => result.ToInt().ShouldEqual(expectedResult);
    }

    /// <summary>
    /// Addition
    /// </summary>
    [Tags("Math")]
    [Subject(typeof(RomanNumeral))]
    public class When_adding_two_numbers
    {
        protected static int expectedResult;
        protected static RomanNumeral numberOne, numberTwo, result;

        private Establish context = () =>
        {
            var random = new Random(DateTime.Now.Millisecond);
            var first = random.Next(50, 100);
            var second = random.Next(1, 39);

            numberOne = new RomanNumeral(first);
            numberTwo = new RomanNumeral(second);
            expectedResult = first + second;
        };

        private Because test = () =>
        {
            result = numberOne + numberTwo;
        };

        private It Should_have_an_equivalent_result_to_the_expected_result =
            () => result.ToInt().ShouldEqual(expectedResult);
    }

    /// <summary>
    /// Subtraction
    /// </summary>
    [Tags("Math")]
    [Subject(typeof(RomanNumeral))]
    public class When_subtracting_two_numbers
    {
        protected static int expectedResult;
        protected static RomanNumeral numberOne, numberTwo, result;

        private Establish context = () =>
        {
            var random = new Random(DateTime.Now.Millisecond);
            var first = random.Next(50, 100);
            var second = random.Next(1, 39);

            numberOne = new RomanNumeral(first);
            numberTwo = new RomanNumeral(second);
            expectedResult = first - second;
        };

        private Because test = () =>
        {
            result = numberOne - numberTwo;
        };

        private It Should_have_an_equivalent_result_to_the_expected_result =
            () => result.ToInt().ShouldEqual(expectedResult);
    }
}
