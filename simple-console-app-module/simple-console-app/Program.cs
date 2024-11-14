// .Next() is a stateful method - it requires a variable in order to function, and does not function on its own or when connected to another method
// Stateless methods like Random() do not have this issue - they function regardless 

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Random bigDice = new Random();
int roll1 = bigDice.Next();
int roll2 = bigDice.Next(101);
int roll3 = bigDice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// .Max() works in the same way - it is a stateful method

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

// If/else statements
// Functionality is the same as in JavaScript

Random ifDice = new Random();
int roll4 = ifDice.Next(1, 7);
int roll5 = ifDice.Next(1, 7);
int roll6 = ifDice.Next(1, 7);

int total = roll4 + roll5 + roll6;

Console.WriteLine($"Dice roll: {roll4} + {roll5} + {roll6} = {total}");

if ((roll4 == roll5) || (roll5 == roll6) || (roll6 == roll4))
{
    if ((roll4 == roll5) && (roll5 == roll6))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}


if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration > 9)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration > 4)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage}%!");
}
else
{
    Console.WriteLine("Your subscription has expired.");
}

// Arrays
// Array syntax is different in C# - you also need to declare how large you'd like to make the array and use square brackets when declaring the datatype
// Declaring specific elements in an array is also done by index number
// Attempting to access an index that doesn't exist in the array will make an error, so be careful!


// string[] fraudulentOrderIDs = new string[3];
// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
// Note: some older syntax uses curly braces instead of square brackets around the array elements - as long as the variable datatype declared has square brackets, it's an array


Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// foreach method works the same as it does in JavaScript

int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

string[] invIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string invID in invIDs)
{
    if (invID.StartsWith("B"))
    {
        Console.WriteLine(invID);
    }
}

// Variables
// Variables have several rules:
// - Variable names can contain alphanumeric characters and the underscore (_) character. Special characters like the pound #, the dash -, and the dollar sign $ are not allowed.
// - Variable names must begin with an alphabetical letter or an underscore, not a number. Using an underscore character to start a variable name is typically reserved for private instance fields. A link to further reading can be found in the module summary.
// - Variable names must NOT be a C# keyword. For example, these variable name declarations won't be allowed: float float; or string string;.
// - Variable names are case-sensitive, meaning that string MyValue; and string myValue; are two different variables.
