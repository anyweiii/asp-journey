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

Random coin = new Random();
int number = coin.Next(0, 2);
Console.WriteLine($"Coin: {(number == 0 ? "heads" : "tail")}");