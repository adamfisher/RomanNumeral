# ![](https://raw.githubusercontent.com/adamfisher/RomanNumeral/master/icon.png) RomanNumeral
This is a C# .NET data type representation of the numeric system used in ancient Rome, employing combinations of letters from the Latin alphabet. Permissible values fall within the range of 1 - 3,999.

This package is available as a [**Nuget package**](https://www.nuget.org/packages/RomanNumeral) on nuget.org.

```Math
I, II, III, IV, V, VI, VII, VIII, IX, X ...
```

## Getting Started


### Creation

Several convenience constructors give you the ability to create a roman numeral data type using either a numeric value or a roman numeral string. Once a `RomanNumeral` object is created, its value is static for the duration of its lifetime.

```csharp
var numberOne = new RomanNumeral(411);		// CDXI
var numberTwo = new RomanNumeral("MCMXC");	// 1990
Console.WriteLine(new RomanNumeral(31));	// XXXI
```

### Conversion

Convert a roman numeral string to a numeric value.

```csharp
int value;
if (RomanNumeral.TryParse(romanNumeral, out value))
{
	// Do something with the converted value.
}
```

### Math

You can treat a RomanNumeral type just like you would treat any other numeric type to perform math operations.

```csharp
var numberOne = new RomanNumeral(10);
var numberTwo = new RomanNumeral(5);

Console.WriteLine(numberOne * numberTwo);		// L
Console.WriteLine(numberOne / numberTwo);		// II
Console.WriteLine(numberOne + numberTwo);		// XV
Console.WriteLine(numberOne - numberTwo);		// V
```
