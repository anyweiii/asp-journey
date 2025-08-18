/*  
    Evaluate an expression
*/

Console.WriteLine("a" == "a ");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

Console.WriteLine(myValue != "a");
Console.WriteLine("this is a new line");

// Comparison Operators
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);


Console.WriteLine("this is a new line");
Console.WriteLine("Methods that return a boolean value");
string pangram = "The quick brown fox jumps over a lazy dog";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// Logical Negation
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

Console.WriteLine("this is a new line");

// Inequality Operator Versus Logical Negation
int a = 7;
int b = 6;
Console.WriteLine(a != b);

string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2);

// Conditional Operator
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

/*  
    Challenge
*/

// Random coin = new Random();
// int number = coin.Next(0, 2);
// Console.WriteLine($"Coin: {(number == 0 ? "heads" : "tail")}");

// string permission = "Admin|Manager";
// int level = 21;

// if (permission.Contains("Admin") && level > 55)
// {
//     Console.WriteLine($"Welcome, Super Admin user.");
// }
// else if (permission.Contains("Admin") && level <= 55)
// {
//     Console.WriteLine($"Welcome, Admin user.");
// }
// else if (permission.Contains("Manager") && level > 20)
// {
//     Console.WriteLine($"Contact Admin for access.");
// }
// else if (permission.Contains("Manager") && level < 20)
// {
//     Console.WriteLine($"You do not have sufficient privileges");
// }
// else
// {
//     Console.WriteLine($"You do not have sufficient privileges");
// }

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine($"Welcome, Super Admin user.");
//     }
//     else if (level <= 55)
//     {
//         Console.WriteLine($"Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level > 20)
//     {
//         Console.WriteLine($"Contact Admin for access.");
//     }
//     else if (level < 20)
//     {
//         Console.WriteLine($"You do not have sufficient privileges");
//     }
// }
// else
// {
//     Console.WriteLine($"You do not have sufficient privileges");
// }

/*  
    Control Variable Score and Logic using Code Blocks in C#
        - Usually defined in a squiggly braces {}
*/

/* 
    bool flag = true;
    int value;

    if (flag)
    {
        value = 10;
        Console.WriteLine($"Inside the code block: {value}");
    }
    // This code is an error because the variable is defined inside the code block and not universally defined. 
    // Console.WriteLine($"Outside the code block: {value}");

    value = 0;
    Console.WriteLine($"Outside the code block: {value}"); 
*/

// bool flag = true;
// if (flag) 
//     Console.WriteLine(flag);

// string name = "steve";
// if (name == "bob")
//     Console.WriteLine("Found Bob!");
// else if (name == "steve")
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck!");

/*  
    Update Problematic Code
*/

int[] numbers = [4, 8, 15, 16, 23, 42];

foreach (int number in numbers)
{
    int total = 0;
    // addition of the total to the numbers array. Adding of each number adding to themselves.
    total += number;

    if (number == 42)
    {
        Console.WriteLine("The set contains 42");
    }

    Console.WriteLine($"Total: {total}");
}

/*  
    Implement a switch statement
*/

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
// SKU value format: <product #>-<2 letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-'); // items are split via '-'

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat Shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat Pants";
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
        color = "Other";
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

/*  
    Create and Configure Iteration Loops
        foreach - iterates through a codeblock once for each item
        while - iterates until condition is met
*/

/* 
for (int i = 10; i >= 0; i--)
{
    // starts with 10 then checks if >= 0 then proceeds with the codeblock statement (printing) then decrement
    Console.WriteLine(i);
} 
*/

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}

/*  
    Activity
*/

for (int x = 1; x <= 100; x++)
{
    if ((x % 3 == 0) && (x % 5 == 0))
    {
        Console.WriteLine($"{x} - FizzBuzz");
    }
    else if (x % 3 == 0)
    {
        Console.WriteLine($"{x} - Fizz");
    }
    else if (x % 5 == 0)
    {
        Console.WriteLine($"{x} - Buzz");
    }
    else
    {
        Console.WriteLine($"{x}");
    }
}