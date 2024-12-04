// Testing, debugging, and exception handling are all different things
// The code below, for example, requires debugging:

// string[] students = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };

// int studentCount = students.Length;

// Console.WriteLine("The final name is: " + students[studentCount]);

// Generally speaking, the term debugging is reserved for runtime issues that aren't easy to isolate
// This also means that debugging falls on the developer to do
// The same is true of exception handling: 
// These are the warnings and errors that occur during an app's runtime that weren't caught by debugging
// Exceptions are thrown by code that encounter an error and caught by code that can correct an error
// Exceptions in C# also have their own class, and you can create different types and access their contents

// In short:
// - Testing, debugging, and exception handling are all important tasks for software developers.
// - Testing can be categorized into functional and nonfunctional testing, and developers are expected to perform some level of testing.
// - Code debugging is the process of isolating issues and identifying ways to fix them, and it's a developer responsibility.
// - Exception handling is the process of managing errors that occur during runtime, and developers are responsible for handling exceptions by using "try" and "catch" statements in their code.
// - An exception gets created at runtime when your code produces an error.
// - The exception can be treated like a variable that has some extra capabilities.
// - You can write code that accesses the exception and takes corrective action.

// The best way to find those errors is to use a debugger - using Console.WriteLine() throughout the code is a waste of time!'

// VSCode has a C# debugger built into it, which you can access by pressing F5 or going to the Run menu option in the top toolbar and selecting "Start Debugging"
// The Run menu provides menu options that are grouped into six sections:
// - Start and stop applications. This section of the menu includes options for starting and stopping code execution, with and without the debugger attached.
// - Launch configurations. This section of the menu provides access to examine or create launch configurations.
// - Runtime control. This section of the menu enables the developer to control how they want to advance through the code. Controls are enabled when execution has paused during a debug session.
// - Set Breakpoints. This section of the menu enables the developer to set breakpoints on code lines. Code execution pauses on Breakpoints during a debug session.
// - Manage Breakpoints. This section of the menu enables the developer to manage breakpoints in bulk rather than individually.
// - Install Debuggers. This section of the menu opens the Visual Studio Code EXTENSIONS view filtered for code debuggers.

// The RUN AND DEBUG view provides access to runtime tools that can be invaluable during the debug process.
// - Run and Debug controls panel. Used to configure and start a debug session.
// - VARIABLES section. Used to view and manage variable state during a debug session.
// - WATCH section. Used to monitor variables or expressions. For example, you could configure an expression using one or more variables and watch it to see when a particular condition is met.
// - CALL STACK section. Used to keep track of the current point of execution within the running application, starting with the initial point of entry into the application. The call stack shows which method is currently being executed, as well as the method or methods in the execution path that led to the current point of execution (current line of code).
// - BREAKPOINTS section. Displays the current breakpoint settings.
// - Debug toolbar. Used to control code execution during the debug process. This toolbar is only displayed while the application is running.
// - Current execution step. Used to identify the current execution step by highlighting it in the Editor. In this case, the current execution step is a breakpoint (breakpoints are marked with a red dot to the left of the line number).
// - DEBUG CONSOLE. Used to display messages from the debugger. The DEBUG CONSOLE panel is the default console for console applications and is able to display output from Console.WriteLine() and related Console output methods.

// At the top of the RUN AND DEBUG view, you can find the launch controls:
// - Start debugging. This button (a green arrow) is used to start a debug session.
// - Launch configurations. This dropdown menu provides access to launch configurations. The selected option is displayed.
// - Open 'launch.json'. This button (a gear shape) can be used to open the launch.json file, where you can edit the launch configuration if needed.
// - Views and More Actions. This button (an ellipsis) enables you to show/hide sections of the debug panel as well as the DEBUG CONSOLE panel.

// The Debug toolbar provides execution controls while your application is running:
// - Pause/Continue. This button can be used to pause execution when the code is running and Continue when code execution has been paused.
// - Step Over. This button can be used to execute the next method as a single command without inspecting or following its component steps.
// - Step Into. This button can be used to enter the next method or code line and observe line-by-line execution steps.
// - Step Out. When inside a method, this button can be used to return to the earlier execution context by completing all remaining lines of the current method as though they were a single command.
// - Restart. This button can be used to terminate the current program execution and start debugging again using the current configuration.
// - Stop. This button can be used to terminate the current program execution.

// Breakpoints are invaluable tools in debugging - you can start or stop code from running with them
// Conditional breakpoints work like if statements 
// First you need to give the breakpoint an expression
// You can pause sections of code if that specific section with the breakpoint evaluates as true 
// Hit count breakpoints are used to specify the number of times that a breakpoint must be encountered before it will 'break' execution 
// (aka continue running the rest of the code)
// Logpoints are breakpoint variants that log messages to the console instead of the debugger tool
// They are represented by a diamond instead of a circle

// Example debugging code - using a names array and corresponding methods to display greeting messages:

// string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

// string messageText = "";

// foreach (string name in names)
// {
//     if (name == "Sophia")
//         messageText = SophiaMessage();
//     else if (name == "Andrew")
//         messageText = AndrewMessage();
//     else if (name == "AllGreetings")
//         messageText = SophiaMessage();
//     messageText = messageText + "\n\r" + AndrewMessage();

//     Console.WriteLine(messageText + "\n\r");
// }

// // bool pauseCode = true;
// // while (pauseCode == true);

// static string SophiaMessage()
// {
//     return "Hello, my name is Sophia.";
// }

// static string AndrewMessage()
// {
//     return "Hi, my name is Andrew. Good to meet you.";
// }

// Your launch and tasks.json files are important too - they handle how your debugger is configured:
// - name: The reader-friendly name assigned to the launch configuration
// - type: The type of debugger to use for the launch configuration
// - request: The request type of the launch configuration
// - preLaunchTask: Specifies a task to run before debugging your program
// - program: Set to the path of the application dll or .NET Core host executable to launch
// - cwd: Specifies the working directory of the target process
// - args: Specifies the arguments that are passed to your program at launch
// - console: Specifies the type of console that's used when the application is launched
//      - internalConsole (default - debug console in VSCode (does not support console input, which means it can't work with .ReadLine() ))
//      - integratedTerminal (output in VSCode)
//      - externalTerminal (external terminal window)

// You can configure multiple projects in one folder with one launch.json & tasks.json - they can support multiple configurations
// Once you've done so, you can choose which project to debug with the dropdown in the Run & Debug sidebar section

// Example code to show how conditional breakpoints can be used:

// int productCount = 2000;
// string[,] products = new string[productCount, 2];

// LoadProducts(products, productCount);

// for (int i = 0; i < productCount; i++)
// {
//     string result;
//     result = Process1(products, 1);

//     if (result != "obsolete")
//     {
//         result = Process2(products, i);
//     }
// }

// bool pauseCode = true;
// while (pauseCode == true);

// static void LoadProducts(string[,] products, int productCount)
// {
//     Random rand = new Random();

//     for (int i = 0; i < productCount; i++)
//     {
//         int num1 = rand.Next(1, 10000) + 10000;
//         int num2 = rand.Next(1, 101);

//         string prodID = num1.ToString();

//         if (num2 < 91)
//         {
//             products[i, 1] = "existing";
//         }
//         else if (num2 == 91)
//         {
//             products[i, 1] = "new";
//             prodID = prodID + "-n";
//         }
//         else
//         {
//             products[i, 1] = "obsolete";
//             prodID = prodID + "-0";
//         }

//         products[i, 0] = prodID;
//     }
// }

// static string Process1(string[,] products, int item)
// {
//     Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

//     return products[item, 1];
// }

// static string Process2(string[,] products, int item)
// {
//     Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
//     if (products[item, 1] == "new")
//         Process3(products, item);

//     return "continue";
// }

// static void Process3(string[,] products, int item)
// {
//     Console.WriteLine($"Process3 message - processing product information for 'new' product");
// }

// string? readResult;
// int startIndex = 0;
// bool goodEntry = false;

// int[] numbers = {1, 2, 3, 4, 5};

// Display the array to the console.
// Console.Clear();
// Console.Write("\n\rThe 'numbers' array contains: { ");
// foreach (int number in numbers)
// {
//     Console.Write($"{number} ");
// }

// To calculate a sum of array elements,
// prompt the user for the starting element number
// Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
// while (goodEntry == false) 
// {
//     readResult = Console.ReadLine();
//     goodEntry = int.TryParse(readResult, out startIndex);

//     if (startIndex > 5)
//     {
//         goodEntry = false;
//         Console.WriteLine("\n\rEnter an integer value between 1 and 5");
//     }
// }

// Display the sum and then pause.
// Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex - 1)}");
// Console.WriteLine("press Enter to exit");
// readResult = Console.ReadLine();

// This method returns the sum of elements n through 5
// static int SumValues(int[] numbers, int n)
// {
//     int sum = 0;
//     for (int i = n; i < numbers.Length; i++)
//     {
//         sum += numbers[i];
//     }
//     return sum;
// }

/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

ChangeValue(x);

Console.WriteLine(x);

// Declare the method's data type so that the variable can be updated
int ChangeValue(int value)
{
   value = 10;
   // Add a return here to ensure that variable given is updated
   return value;
}

// Exception handling in C# is implemented by using the try, catch, and finally keywords:
try
{
   // try code block - code that may generate an exception
}
catch
{
   // catch code block - code to handle an exception
}
finally
{
   // finally code block - code to clean up resources
}

// Exception handling in a C# application is generally implemented using one or more of the following patterns:

// - The try-catch pattern consists of a try block followed by one or more catch clauses. 
//   Each catch block is used to specify handlers for different exceptions.
// - The try-finally pattern consists of a try block followed by a finally block. 
//   Typically, the statements of a finally block run when control leaves a try statement.
// - The try-catch-finally pattern implements all three types of exception handling blocks. 
//   A common scenario for the try-catch-finally pattern is when resources are obtained and used in a try block, 
//   exceptional circumstances are managed in a catch block,
//   and the resources are released or otherwise managed in the finally block.

// When an exception occurs, the .NET runtime searches for the nearest catch clause that can handle the exception
// Generally, this means looking for any try block that encompasses the exception, then finding the associated catch
// If no catch clause or try clause is found, the runtime terminates the application and displays an error message instead

// The compiler-generated exceptions are as follows:

// ArrayTypeMismatchException: Thrown when an array can't store a given element because the actual type of the element is incompatible with the actual type of the array.
// DivideByZeroException: Thrown when an attempt is made to divide an integral value by zero.
// FormatException: Thrown when the format of an argument is invalid.
// IndexOutOfRangeException: Thrown when an attempt is made to index an array when the index is less than zero or outside the bounds of the array.
// InvalidCastException: Thrown when an explicit conversion from a base type to an interface or to a derived type fails at runtime.
// NullReferenceException: Thrown when an attempt is made to reference an object whose value is null.
// OverflowException: Thrown when an arithmetic operation in a checked context overflows.

// Exceptions are all inherited from a base class, System.Exception
// They don't add any additional functionality from this class
// These are the properties of the Exception class:
// Data: The Data property holds arbitrary data in key-value pairs.
// HelpLink: The HelpLink property can be used to hold a URL (or URN) to a help file that provides extensive information about the cause of an exception.
// HResult: The HResult property can be used to access to a coded numerical value that's assigned to a specific exception.
// InnerException: The InnerException property can be used to create and preserve a series of exceptions during exception handling.
// Message: The Message property provides details about the cause of an exception.
// Source: The Source property can be used to access the name of the application or the object that causes the error.
// StackTrace: The StackTrace property contains a stack trace that can be used to determine where an error occurred.
// TargetSite: The TargetSite property can be used to get the method that throws the current exception.

// In particular, the Message property is important when building your own exceptions
// Example of looking for a specific exception using catch and showing an appropriate message:
try
{
   Process1();
}
catch
{
   Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
   try
   {
      WriteMessage();
   }
   catch (DivideByZeroException ex)
   {
      // DivideByZeroException ex above is a variable with the Exception.DivideByZeroException data type
      // This allows you to call on specific properties as necessary
      // However, this also means it will fail if a different exception type is encountered
      Console.WriteLine($"Exception caught in Process1: {ex.Message}");
   }
}

static void WriteMessage()
{
   double float1 = 3000.0;
   double float2 = 0.0;
   int number1 = 3000;
   int number2 = 0;
   byte smallNumber;

   Console.WriteLine(float1 / float2);
   Console.WriteLine(number1 / number2);
   checked
   {
      // Try-catch statements can only catch 1 exception, without exception (lol)
      // It's important to make try-catch statements as close to your potential exceptions as possible, and for all of your potential exceptions
      try
      {
         smallNumber = (byte)number1;
      }
      catch (OverflowException ex)
      {
         Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
      }
   }
}

// You can also use multi-catch statements like below:

string[] inputValues = new string[] { "three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
   int numValue = 0;
   try
   {
      numValue = int.Parse(inputValue);
   }
   catch (FormatException)
   {
      Console.WriteLine("Invalid readResult. Please enter a valid number.");
   }
   catch (OverflowException)
   {
      Console.WriteLine("The number you entered is too large or too small.");
   }
   catch (Exception ex)
   {
      Console.WriteLine(ex.Message);
   }
}

checked
{
   try
   {
      int num1 = int.MaxValue;
      int num2 = int.MaxValue;
      int result = num1 + num2;
      Console.WriteLine("Result: " + result);
   }
   catch (OverflowException ex)
   {
      Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
   }
}

// Creating and throwing exceptions from within your code is an important aspect of C# programming
// The ability to generate an exception in response to a specific condition, issue, or error helps you to ensure the stability of your application

// The exception type that you create depends on the coding issue, and should match the intended purpose of the exception as closely as possible.

// Here are some common exception types that you might use when creating an exception:

// - ArgumentException or ArgumentNullException: 
//   Use these exception types when a method or constructor is called with an invalid argument value or null reference.
// - InvalidOperationException: 
//   Use this exception type when the operating conditions of a method don't support the successful completion of a particular method call.
// - NotSupportedException: 
//   Use this exception type when an operation or feature is not supported.
// - IOException: 
//   Use this exception type when an input/output operation fails.
// - FormatException: 
//   Use this exception type when the format of a string or data is incorrect.

// Some considerations to keep in mind when throwing an exception include:

// - The Message property should explain the reason for the exception. 
//   However, information that's sensitive, or that represents a security concern shouldn't be put in the message text.
// - The StackTrace property is often used to track the origin of the exception. 
//   This string property contains the name of the methods on the current call stack, together with the file name and line number in each method that's associated with the exception. 
//   A StackTrace object is created automatically by the common language runtime (CLR) from the point of the throw statement
//   Exceptions must be thrown from the point where the stack trace should begin.
// - The throw command can also be used to re-throw an exception from inside a catch code block

// The following list identifies practices to avoid when throwing exceptions:

// - Don't use exceptions to change the flow of a program as part of ordinary execution. 
//   Use exceptions to report and handle error conditions.
// - Exceptions shouldn't be returned as a return value or parameter instead of being thrown.
// - Don't throw System.Exception, System.SystemException, System.NullReferenceException, or System.IndexOutOfRangeException intentionally from your own source code.
// - Don't create exceptions that can be thrown in debug mode but not release mode. 
//   To identify runtime errors during the development phase, use Debug.Assert instead.

// Guided create an exception challenge

// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;

bool exit = false;

do
{
   try
   {
      // Calculate the sum of the even numbers between the bounds
      averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

      // Display the value returned by AverageOfEvenNumbers in the console
      Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

      exit = true;
   }
   catch (ArgumentOutOfRangeException ex)
   {
      Console.WriteLine("An error has occurred.");
      Console.WriteLine(ex.Message);
      Console.WriteLine($"The upper bound must be greater than {lowerBound}");
      Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
      string? userResponse = Console.ReadLine();
      if (userResponse.ToLower().Contains("exit"))
      {
         exit = true;
      }
      else
      {
         exit = false;
         upperBound = int.Parse(userResponse);
      }
   }
} while (exit == false);

// Wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
   if (lowerBound >= upperBound)
      throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutofRangeException: upper bound must be greater than lower bound.");

   int sum = 0;
   int count = 0;
   decimal average = 0;

   for (int i = lowerBound; i <= upperBound; i++)
   {
      if (i % 2 == 0)
      {
         sum += i;
         count++;
      }
   }

   average = (decimal)sum / count;

   return average;
}

// Create an exception challenge

string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
   UserWorkflow(userEnteredValues);
}
catch (DivideByZeroException ex)
{
   Console.WriteLine("An error occurred during 'UserWorkflow'.");
   Console.WriteLine(ex.Message);
}

static void UserWorkflow(string[][] userEnteredValues)
{

   foreach (string[] userEntries in userEnteredValues)
   {
      try
      {
         UserProcess(userEntries);
      }
      catch (FormatException ex) {
         Console.WriteLine("'UserProcess' encountered an issue, process aborted.");
         Console.WriteLine(ex.Message);
         Console.WriteLine("");
      }
   }
}

static void UserProcess(String[] userEntries)
{
   int valueEntered;

   foreach (string userValue in userEntries)
   {
      bool integerFormat = int.TryParse(userValue, out valueEntered);

      if (integerFormat == true)
      {
         if (valueEntered != 0)
         {
            checked
            {
               int calculatedValue = 4 / valueEntered;
            }
         }
         else
         {
            throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
         }
      }
      else
      {
         throw new FormatException("Invalid data. User input values must be valid integers.");
      }
   }
}