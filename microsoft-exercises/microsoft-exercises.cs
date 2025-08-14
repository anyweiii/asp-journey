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

// string firstName = "Bob";
// string greeting = "Hello";
// Console.WriteLine(greeting + " " + firstName + "!");

// string message = greeting + " " + firstName + "!";
// string message = $"{greeting} {firstName}";
// Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version}";
Console.WriteLine(message);

// string projectName = "First-Project";
// Console.WriteLine($@"C:\Output\{projectName}\Data");

/*  
    CHALLENGE
*/

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English Output:
            c:\Exercise\{projectName}\data.txt");

Console.WriteLine($@"{russianMessage}:
            c:\Exercise\{projectName}\ru-RU\data.txt");


/*  
    Perform Basic Operations on Numbers in C#
*/

int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

string firstName = "Bob";
int widgetSold = 7;
Console.WriteLine(firstName + " sold " + widgetSold + " widgets.");
Console.WriteLine(firstName + " sold " + (widgetSold + 7) + " widgets.");

/*  
    Perform Basic Math Operations
*/

// int sum = 7 + 5;
// int difference = 7 - 5;
// int product = 7 * 5;
// int quotient = 7 / 5;

// Console.WriteLine("Sum: " + sum);
// Console.WriteLine("Difference: " + difference);
// Console.WriteLine("Product: " + product);
// Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
decimalQuotient = 7.0m / 5.0m; 
Console.WriteLine($"Decimal Quotient: {decimalQuotient}");

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

/*  
    Increment and Decrement Values
*/

// int value = 1;

// value = value + 1;
// Console.WriteLine("First increment: " + value);

// value += 1;
// Console.WriteLine("Second increment: " + value);

// value++;
// Console.WriteLine("Third Increment: " + value);

// value = value - 1;
// Console.WriteLine("First decrement: " + value);

// value -= 1;
// Console.WriteLine("Second decrement: " + value);

// value--;
// Console.WriteLine("Third decrement: " + value);

/*  
    Position the increment and decrement operators
*/

int value = 1;
value++;

Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

/*  
    Challenge: Fahrenheit to Celsius
*/

// parenthesis, exponent, multiplication, division, addition, subtraction
int fahrenheit = 94;
decimal conversion = (fahrenheit - 32m) * 5m / 9m;
Console.WriteLine($"The temperature is {conversion} Celsius");

Console.WriteLine("Windows " + 7 + 4);
Console.WriteLine(5 / 10);

/*  
    Preparation for Guided Projects
*/

int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahira1 = 84;
int zahira2 = 96;
int zahira3 = 73;
int zahira4 = 85;
int zahira5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahiraSum = zahira1 + zahira2 + zahira3 + zahira4 + zahira5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

Console.WriteLine($"Sophia: {sophiaSum}");
Console.WriteLine($"Nicolas: {nicolasSum}");
Console.WriteLine($"Zahira: {zahiraSum}");
Console.WriteLine($"Jeong: {jeongSum}");

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahiraScore = (decimal) zahiraSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine($"Sophia: {sophiaScore} A");
Console.WriteLine($"Nicolas: {nicolasScore} B");
Console.WriteLine($"Zahira: {zahiraScore} B");
Console.WriteLine($"Jeong: {jeongScore} A");

Console.WriteLine("Student Grade\n");
Console.WriteLine("Student\tGrade\n");
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahiraScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");