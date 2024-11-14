// C# enforces data types and punctuation (like PHP), so remember to use the proper quotes, brackets, and colons

// WriteLine Adds a return after the string, Write does not
// Single quotes for single character, double quotes for strings
Console.WriteLine("Congratulations!");
Console.Write("You just wrote your first line of C#.");
Console.Write('b');

// Use \ for escaping a doublequote in a string so it will show up in the final written line
// Use \\ for escaping a backslash
// Use @ for a string literal (ie. it will keep all whitespace and characters without the need to escape the backslash)
// C# also supports Unicode characters, but some are UTF-16 and some are UTF-32 (meaning they require a different escape sequence), so be careful when using them!
//Example below:

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// Integers need no quotation marks
Console.WriteLine(123);

// 3 different decimal number types: float, double, & decimal
var f = 0f; // float
var d = 0d; // double
var m = 0m; // decimal (money)
var u = 0u; // unsigned int
var l = 0l; // long
var ul = 0ul; // unsigned long
Console.WriteLine(0.25F);
Console.WriteLine(0.5);
Console.WriteLine(1.24356463m);

// For math equations that involve decimals and division, the quotient (left of the assignment operator) must be of type decimal and at least one of numbers being divided must also be of type decimal (both numbers can also be a decimal type). 
// In general, if your equation's solution involves decimals, you must set the variable to be a float, double, or decimal data type - otherwise it will read as 0
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// The following operators work the same as they do in JavaScript (+, -, *, /, %, +=, -=);
// For ++ & --, the position they have influences how they update the variable that they're attached to
// If you use the operator before the value (as in ++value), then the increment will happen before the value is retrieved 
// Likewise, value++ will increment the value after the value has been retrieved
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

// If you need to convert from an integer value to a decimal value, you will need to perform a data type cast.
// This converts the integer value to a decimal value
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

// Variables can declared by the type of data that they store first to enforce it
// However, you can still use 'var' so that the computer implies (ie. figures out) the data type on its own
// This also means that a variable declared as 'var' will never be able to hold a different type once the computer implies the data type for the first time
var firstName = "Bob";
var greeting = "Hello";

//String concatenation - combining strings together into a single literal by attaching them together
Console.WriteLine(greeting + " " + firstName + "!");

//String interpolation - combines multiple different values into a single literal
Console.WriteLine($"{greeting} {firstName}!");

// Ideally for both, you want to avoid making intermediate variables to combine them and then use them
// You can also do basic calculations in the curly braces, but this is not recommended
// You can also combine interpolation with string literals (@)
// This lets you use newlines and tabs in a writeline methods without using the shorthands (ie. \n, \t)
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

// Nullable strings are written with a question mark after the data type

string? readResult;
Console.WriteLine("Enter a string: ");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);


