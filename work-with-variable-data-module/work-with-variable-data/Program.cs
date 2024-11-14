// There are two data types in C#: value and reference
// Variables of reference types store references to their data (objects), that is they point to data values stored somewhere else
// In comparison, variables of value types directly contain their data
// As you learn more about C#, new details emerge related to the fundamental difference between value and reference types
// Within types, there are also further distinctions
// For example, integral types (int) have two subtypes: signed and unsigned
// Signed can represent negative and positive numbers, unsigned only represents positive

Console.WriteLine("Signed integral types: ");
Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int   : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");

Console.WriteLine("Unsigned integral types:");
Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");

Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// For the 'new' operator, all variables use it to create a new instance
// However, string variables don't need to use it since they're used so often

int[] data = new int[3];
string shortenedString = "Hey world";

// Overall, use the data types in the following situations: 
// int for most whole numbers
// decimal for numbers representing money
// bool for true or false values
// string for alphanumeric value
// byte: working with encoded data that comes from other computer systems or using different character sets.
// double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
// System.DateTime for a specific date and time value.
// System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.

// Converting data types works similarly to JavaScript
// Integer variables can be automatically converted to strings, but not the other way around
// Integer variables can also be converted to decimals, provided they are declared as such
// These types of conversions are known as 'narrowing conversions' because you're converting a data type that can hold more information into one that can hold less
// Conversely, 'widening conversions' are ones that convert data types that can hold less information into ones that can hold more
// You can convert by casting data types (like below), but you can also convert using the Convert methods (ie. Parse() and ToString())
// Casting truncates decimal values and conversion rounds decimal values

int first = 2;
string second = "4";
string combination = first + second; // This will work - int combination would not
Console.WriteLine(combination);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

string parseValue = "102";
int parseResult = 0;

// TryParse requires an input value and an (optional) output value for the result
// TryParse itself technically returns two values - a bool (whether or not it parsed), and the parsed result of the input

if (int.TryParse(parseValue, out parseResult))
{
    Console.WriteLine($"Measurement: {parseResult}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + parseResult}");

string[] arrayValues = { "12.3", "45", "ABC", "11", "DEF", };
string message = "";
decimal decTotal = 0;

foreach (string arrayVal in arrayValues)
{
    if (Decimal.TryParse(arrayVal, out _))
    {
        decTotal += Convert.ToDecimal(arrayVal);
    }
    else
    {
        message += arrayVal;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {decTotal}");

int valueInt = 11;
decimal valueDec = 6.2m;
float valueFloat = 4.3f;

int result1 = Convert.ToInt32(valueInt / valueDec); //Answer that test wanted was 2, so Convert.ToInt32 was necessary - not logical...
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = valueDec / (decimal)valueFloat;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = valueFloat / (float)valueInt; // Not necessary, but good to keep your skills sharp 
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// Array methods work similarly to how they do in JavaScript
// There are some extra methods available in C#, however

// Methods available in both JavaScript & C#
string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}



// Methods available in C#
// Clear method works like splice does in JavaScript
// Key difference:
// The elements it clears from the array are gone, but their index is still present (it just stores null values)
// IMPORTANT: null values CANNOT be removed from an array. 
// When removing elements from an array, it's best to create a new array with the elements you want from the old one instead
Console.WriteLine("");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Resize method works like push/shift in JavaScript
// Key differences: 
// You can input new elements anywhere in the array with the index that you provide
// You can also remove elements with resize if you shrink the array, like splice
// (you can do this in JavaScript too, but not with the methods mentioned above)
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// ToCharArray method works like split in JavaScript
string exampleText1 = "abc123";
char[] chars1 = exampleText1.ToCharArray();
Array.Reverse(chars1);
string charResult1 = new string(chars1);
Console.WriteLine(charResult1);

// Split & join method works like split & join in Javascript
// Key differences:
// Join method does not attach to variable, but instead to the String class
// The variable to join is included as a parameter in the method afterwards
string exampleText2 = "abc123";
char[] chars2 = exampleText2.ToCharArray();
Array.Reverse(chars2);
string charResult2 = String.Join(",", chars2);
Console.WriteLine(charResult2);
string[] items = charResult2.Split(",");
foreach (string item in items)
{
    Console.WriteLine(item);
}

// Reverse word challenge
string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramItems = pangram.Split(" ");
for (int i = 0; i < pangramItems.Length; i++)
{
    char[] reverseChars = pangramItems[i].ToCharArray();
    Array.Reverse(reverseChars);
    pangramItems[i] = String.Join("", reverseChars);
}

string finalPangram = String.Join(" ", pangramItems);
Console.WriteLine(finalPangram);

// Order parser challenge
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderStreamItems = orderStream.Split(",");
Array.Sort(orderStreamItems);
foreach (string item in orderStreamItems)
{
    if (item.Length != 4)
    {
        Console.WriteLine($"{item} \t- Error");
    }
    else
    {
        Console.WriteLine(item);
    }
}

// Composite formatting uses numbered placeholders within a string
// At run time, everything inside the braces is resolved to a value that is also passed in based on their position
// This is most clearly seen when using the Format() method
// String interpolation simplifies this further - it's the format you've already been using!

// composite
string firstFormat = "Hello";
string secondFormat = "World";
string formatResult = string.Format("{0} {1}!", firstFormat, secondFormat);
Console.WriteLine(formatResult);
// interpolation
Console.WriteLine($"{firstFormat} {secondFormat}!");

// Currency formatting uses :C
// This format has the benefit of updating itself depending on the user's browser language

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// Number formatting uses :N
// By default, the N numeric format specifier displays only two digits after the decimal point
// You can change that by adding a number after the N to denote number of decimal places

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

// Percentage formatting uses :P
// Like numbers, the P percentage format specifier displays only two digits after the decimal point
// You can change that by adding a number after the P to denote number of decimal places

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

// You can also use formatters with composite formatting (and even calculations between variables): 

decimal formatPrice = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (formatPrice - salePrice), formatPrice);

yourDiscount += $"A discount of {((formatPrice - salePrice) / formatPrice):P2}!";
Console.WriteLine(yourDiscount);

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3} Product");
Console.WriteLine($"    Sub Total: {subtotal:C}");
Console.WriteLine($"        Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:C}");

// Strings can also be formatted like HTML (ie. with padding)
// These can also have extra functionality - methods that have this are considered "overloaded methods"
// For PadLeft, if your padding amount is more than the string, it will add whitespace (or whatever you want if you put in parameters)

string input = "Pad this";
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentID = "796C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = $"{5000:C}";

var formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

// String interpolation challenge

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.Write($@"Dear {customerName},
As a customer of our {currentProduct} we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.

Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.

");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage += $"{currentProduct.PadRight(20)}{currentReturn:P2}  {currentProfit:C2}\n{newProduct.PadRight(20)}{newReturn:P2}  {newProfit:C2}";

Console.WriteLine(comparisonMessage);

// The substring method works the same way as it does in JavaScript
// Generally, it's recommended to use only characters and not strings or numbers
// Those are considered 'magic values' because it's very easy to make a mistake and the compiler to subsequently not recognize them
// If you need to use strings or numbers, try to reduce the amount of times that you define them and use the const keyword for them to ensure they cannot be changed

string bracketMessage = "Find what is (inside the parentheses)";

int openingPosition = bracketMessage.IndexOf('(');
int closingPosition = bracketMessage.IndexOf(')');

openingPosition++;

int length = closingPosition - openingPosition;
Console.WriteLine(bracketMessage.Substring(openingPosition, length));

// IndexOf works like it does in JavaScript, but there is an additional method: LastIndexOf
// IndexOf finds the first, LastIndexOf finds the last (obviously)

string indexMessage = "hello there!";

int first_h = indexMessage.IndexOf('h');
int last_h = indexMessage.LastIndexOf('h');

Console.WriteLine($"For the message: '{indexMessage}', the first 'h' is at position {first_h} and the last 'h' is at the position {last_h}'.");

string lastSubMessage = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingLastSubMessagePosition = lastSubMessage.LastIndexOf('(');

openingLastSubMessagePosition += 1;
int closingLastSubMessagePosition = lastSubMessage.LastIndexOf(')');
int snippetLength = closingLastSubMessagePosition - openingLastSubMessagePosition;
Console.WriteLine(lastSubMessage.Substring(openingLastSubMessagePosition, snippetLength));

string allInstances = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingInstancePosition = allInstances.IndexOf('(');
    if (openingInstancePosition == -1) break;

    openingInstancePosition += 1;
    int closingInstancePosition = allInstances.IndexOf(')');
    int instanceLength = closingInstancePosition - openingInstancePosition;
    Console.WriteLine(allInstances.Substring(openingInstancePosition, instanceLength));

    // Note the overload of the substring to return only the remaining unprocessed message:
    allInstances = allInstances.Substring(closingInstancePosition + 1);
}

// IndexOfAny can be used with character arrays to find the first instance of any character in the array
// It's important to note that it does NOT find all first instances of the characters

string symbolMessage = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS message: {symbolMessage}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingSymbolPosition = symbolMessage.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {symbolMessage.Substring(openingSymbolPosition)}");

openingSymbolPosition = symbolMessage.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {symbolMessage.Substring(openingSymbolPosition)}");

string symbolsMessage = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

int closingSymbolPosition = 0;

while (true)
{
    openingSymbolPosition = symbolsMessage.IndexOfAny(openSymbols, closingSymbolPosition);

    if (openingSymbolPosition == -1) break;

    string currentSymbol = symbolsMessage.Substring(openingSymbolPosition, 1);

    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closing position:
    // - Use an overload of the IndexOf method 
    // - Specify that the search for the matching symbol should start at the opening position in the string

    openingSymbolPosition += 1;
    closingSymbolPosition = symbolsMessage.IndexOf(matchingSymbol, openingSymbolPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int symbolsLength = closingSymbolPosition - openingSymbolPosition;
    Console.WriteLine(symbolsMessage.Substring(openingSymbolPosition, symbolsLength));

}

// Remove and Replace methods work similarly to JavaScript
// Remove works like Substring - you give the start and end index and the method removes everything within that
// Replace is exactly the same as JavaScript

string stringData = "12345John Smith          5000 3  ";
string updatedData = stringData.Remove(5, 20);
Console.WriteLine(updatedData);

string hyphenatedMessage = "This--is--ex-amp-le--da-ta";
hyphenatedMessage = hyphenatedMessage.Replace("--", " ");
hyphenatedMessage = hyphenatedMessage.Replace("-", "");
Console.WriteLine(hyphenatedMessage);

// String method challenge
// Overall correct, but remember to use variables to store indexof values whenever possible to avoid magic values
// Fine here because the scale is small, but do NOT do this in larger projects

const string elemInput = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
string quantity = "";
string elemOutput = "";

int firstQuantity = elemInput.IndexOf('5');
int lastQuantity = elemInput.LastIndexOf('0') + 1;
int quantityLength = lastQuantity - firstQuantity;
quantity = $"Quantity: {elemInput.Substring(firstQuantity, quantityLength)}";

int firstDiv = elemInput.IndexOf('>') + 1;
elemOutput = elemInput.Remove(0, firstDiv);
int lastDiv = elemInput.LastIndexOf('<');
elemOutput=  elemOutput.Remove(lastDiv);
elemOutput = elemOutput.Replace("&trade;", "&reg;");
elemOutput = $"Output: {elemOutput}";


Console.WriteLine(quantity);
Console.WriteLine(elemOutput);
