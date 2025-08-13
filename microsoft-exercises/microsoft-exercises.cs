// C# is a case sensitive
// Console.WriteLine("Hello, World!");

// Console.Write("Congratulations!");
// Console.Write(" ");
// Console.Write("You wrote your first line of code.");

/* 
    Console.WriteLine("Congratulations");
    Console.Write("You wrote your first lines of code");
*/

/*  
    Challenge
*/

Console.WriteLine("This is the first line.");
Console.WriteLine("This is the second line");

/*  
    Store and Retrieve Data using Literal and Variable Values
*/

// Character Literal
Console.WriteLine('a');
Console.WriteLine(123);

// Float
Console.WriteLine(0.25F);

// Double
Console.WriteLine(2.625);

// Decimal
Console.WriteLine(12.39816m);

// Boolean 
Console.WriteLine(true);
Console.WriteLine(false);

/*  
    Data Types Define Capabilities
*/

Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);

/*  
    Declare Variables
*/

/* string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName); */

/*  
    Variable - Challenge
*/

/* var name = "Bob";
var message = 3;
var temperature = 34.4;

Console.WriteLine($"Hello, {name}! You have {message} messages in your inbox. The temperature is {temperature} celsius"); */

/*  
    Basic String Formatting in C#
*/

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\t World!");
Console.WriteLine("Hello \"World\"!");

Console.WriteLine("C:\\Source\\Repos");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ..... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Verbatim String Literal
Console.WriteLine(@"         c:\source\repos
                (this is where your code goes)");
Console.WriteLine(@"c:\invoices");

// Unicode Escape Characters
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// string firstName = "Bob";
// string message = "Hello " + firstName;
// Console.WriteLine(message);

// string firstName = "Bob";
// string greeting = "Hello";

// string message = greeting + " " + firstName + "!";
// Console.WriteLine(message);

string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

// string message = greeting + " " + firstName + "!";
string message = $"{greeting} {firstName}";
Console.WriteLine(message);