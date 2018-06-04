using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RomanNumerals.Tests
{
    public static class RomanNumeralTestValuesDataSource
    {
        public static IEnumerable<object[]> ListOfAllSupportedRomanNumerals {
            get
            {
                var list = new List<object[]>(4000);
                var lines = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestValues.txt"));

                list.AddRange(from line in lines
                    select line.Split('=') into item
                    let number = int.Parse(item[0])
                    let numeral = item[1]
                    select new object[] {number, numeral});

                return list;
            }
        }
    }
}
