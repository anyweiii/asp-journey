// Console.WriteLine("Hello, World!");
/* 
    long - stores a 2^64 bit number.
    checked - checks whether the output value is correct and will throw an error if not. 
*/

// Integers
/* 
    int a = 18;
    int b = 6;
    // int c = a + b;
    int c = a - b;
    Console.WriteLine(c); 
*/

/* 
    int a = 5;
    int b = 4;
    int c = 2;
    // int d = a + b * c;
    // int d = (a + b) * c;
    int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d); 
*/

/* 
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    Console.WriteLine(d); 
*/

/* 
    Integer and Precision Limits
*/

/* 
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"quotient: {d}");
    Console.Write($"remainder: {e}"); 
*/

/* 
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}"); 
*/

/* 
    int max = int.MaxValue;
    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}"); 
*/

/* 
    Work with Double Type
*/

/* 
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);
*/

/* 
    double a = 19;
    double b = 23;
    double c = 8;
    double d = (a + b) / c;
    Console.WriteLine(d); 
*/

/* 
    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}"); 
*/

/* 
    double third = 1.0 / 3.0;
    Console.WriteLine(third); 
*/

/* 
    Work with Decimal Types
*/

/* 
    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of the decimal type is {min} to {max}"); 
*/

/* 
    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a / b);

    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c / d); 
*/

/* 
    Integer Challenge
*/
double radius = 2.50;
double Area = Math.PI * Math.Pow(radius, 2);
Console.WriteLine($"The area of a circle is {Area}");
