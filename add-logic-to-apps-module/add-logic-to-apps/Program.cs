// Booleans work mostly the same way that they do in JavaScript
// The only difference is that there is no === , so you cannot use == as a soft equality (ie. making 'a' equal to 'A')
// This means that when listening to user inputs, you need to equalize the data when it comes to certain key presses (ie. converting strings to all upper or lowercase, trimming whitespace, etc)
Console.WriteLine("A" == "A");
Console.WriteLine("b" == "B");
Console.WriteLine(1 == 2);
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// There are also certain methods that return a boolean
string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// The exclamation mark before a variable is called logical negation (ie. this variable does NOT equal the value shown)
Console.WriteLine(!pangram.Contains("fox"));

// The ternary operator also works the same as it does in JavaScript
// However, in C# it's called the conditional operator
// This can also be used within a WriteLine method
// Your if statements also don't need curly braces if they're short (ie. 1 line)
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

bool ifTest = true;
if (ifTest)
    Console.WriteLine($"if single line test result: {ifTest}!");

// Coin flip challenge

var rand = new Random();
string result = rand.Next(0, 2) > 0 ? "Heads" : "Tails";
Console.WriteLine(result);

// Decision logic challenge

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level <= 55)
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{

    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else if (level < 20)
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

// Scope works the same as it does in JavaScript
// There are some subtle differences, however: 
// The below evaluates to an error because the C# compiler considers both possibilities:
// 1) flag is true
// 2) flag is false
// Because of this, the Console.WriteLine outside of the code block doesn't have a value to return in the flag is false scenario
// This makes the compiler return an error instead

bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {{value}} returns an error");

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;

foreach (int number in numbers)
{

    total += number;

    if (number == 42)
    {
        bool found = true;
        if (found)
            Console.WriteLine("Set contains 42");
    }

}

Console.WriteLine($"Total: {total}");

// Switch statements work the same way as they do in JavaScript - no major changes

int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit
// SKU value format: <product #>-<2-letter color code>-<size code>

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweatshirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweatpants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");

// For loops also work as they do in JavaScript, but there are a few differences: 
// - You can use the break keyword to end a for loop early
// - You can update an array item within a for loop, which can't be done in a foreach loop

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    //if (name == "David") name = "Sammy";
}

// FizzBuzz challenge

for (int i = 1; i <= 100; i++)
{
    string fizzBuzz = "";
    if (i % 3 == 0)
    {
        fizzBuzz += "Fizz";
    }
    if (i % 5 == 0)
    {
        fizzBuzz += "Buzz";
    }

    Console.WriteLine($"{i} {fizzBuzz}");
}

// While statements can be written differently in C#
// When they are written in this way, they can use extra statements, such as the continue statement
// The continue statement lets you ignore the result of an iteration of a while loop and continue looping
// This is because it steps immediately to the bool of a while loop (ie. the reason it keeps looping)
// do-while loops also iterate at least once
// However, JavaScript's method is still available

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

Console.WriteLine($"Last number: {current}");

// Monster vs hero challenge - your solution

int heroHealth = 10;
int monsterHealth = 10;
int turnCounter = 1;

do
{

    string victim;
    int victimHealth;
    if (turnCounter % 2 != 0)
    {
        victim = "Monster";
        victimHealth = monsterHealth;
    }
    else
    {
        victim = "Hero";
        victimHealth = heroHealth;
    }

    current = random.Next(1, 11);
    victimHealth = victimHealth - current;

    Console.WriteLine($"{victim} was damaged and lost {current} health and now has {victimHealth} health.");

    if (victim == "Monster")
    {
        monsterHealth = victimHealth;
    }
    else
    {
        heroHealth = victimHealth;
    }
    turnCounter++;
} while (heroHealth > 0 && monsterHealth > 0);


if (heroHealth <= 0)
{
    Console.WriteLine("Monster wins...");
}
else
{
    Console.WriteLine("Hero wins!");
}

// Monster vs hero challenge - training solution

// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

// The Boolean expression evaluated by the while statement can be used to ensure user input meets a specified requirement. 
// For example, if a prompt asks the user to enter a string that includes at least three characters, the following code could be used:

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);


// // Integer validation challenge

string? scanResult;
bool validInt = false;
Console.WriteLine("Please enter an integer value between 5 and 10.");

do
{
    scanResult = Console.ReadLine();
    bool scanBool = int.TryParse(scanResult, out value);
    if (scanResult != null && scanBool)
    {
        if (value >= 5 && value <= 10)
        {
            validInt = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }

} while (validInt == false);

// // String input validation challenge

string? nullResult;
bool validNull = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    nullResult = Console.ReadLine();
    if (nullResult != null)
    {
        string sanitizedResult = nullResult.Trim().ToLower();
        if (sanitizedResult == "administrator" || sanitizedResult == "manager" || sanitizedResult == "user")
        {
            validNull = true;
            Console.WriteLine($"Your input value ({nullResult}) has been accepted.");
        }
        else
        {
            Console.WriteLine($"The role name that you entered, '{nullResult}' is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }
} while (validNull == false);

// String array content processing challenge - your solution (incorrect)

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad.", "I like all three of the menu choices" };

for (int i = 0; i < myStrings.Length; i++)
{
    string myString = myStrings[i];
    int period = myString.IndexOf(".");
    do
    {
        string sentence;
        if (period == -1)
        {
            sentence = myString;
        }
        else
        {
            sentence = myString.Substring(0, period);
        }
        Console.WriteLine(sentence);
        if (sentence.Length > 0 && period != -1)
        {
            myString = myString.Remove(0, sentence.Length + 1).TrimStart(' ');
            period = myString.IndexOf(".");
        }
    } while (period != -1);
}

// String array content processing challenge - training solution (frustrating)

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation); // Remove method can save the text being removed in a variable (it's not necessarily a simple deletion)

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}









