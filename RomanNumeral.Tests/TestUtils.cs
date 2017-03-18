using System;
using System.Collections.Generic;
using System.IO;

namespace RomanNumerals.Tests
{
    public static class TestUtils
    {
        /// <summary>
        /// Loads the test data.
        /// </summary>
        /// <returns>A dictionary of int to roman numeral mappings.</returns>
        public static IDictionary<int, string> GetTestData()
        {
            var dictionary = new Dictionary<int, string>(4100);
            var lines = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestValues.txt"));

            foreach (var line in lines)
            {
                var item = line.Split('=');
                var number = int.Parse(item[0]);
                var numeral = item[1];
                dictionary[number] = numeral;
            }

            return dictionary;
        }
    }
}
