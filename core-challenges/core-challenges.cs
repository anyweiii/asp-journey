// Console.WriteLine("Hello, World!");

/*  
    Hello World Challenge -  Try to modify the previous sample to use StartsWith and EndsWith instead of Contains. Search for "You" or "goodbye" at the beginning of a string. Search for "hello" or "goodbye" at the end of a string.
*/

string songLyrics = "You say goodbye, and I say hello";

Console.WriteLine(songLyrics.StartsWith("You"));
Console.WriteLine(songLyrics.StartsWith("goodbye"));
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.WriteLine(songLyrics.EndsWith("goodbye"));

/*  
    Numbers in C# Challenge - Write code that calculates the area of a circle whose radius is 2.50 centimeters. Remember that the area of a circle is the radius squared multiplied by PI. 
*/

double radius = 2.50;
double Area = 0;

// Math.Pow(value, exponent)
Area = Math.PI * Math.Pow(radius, 2);

Console.WriteLine(Area);

/*  
    Combine branches and loops
    See if you can write C# code to find the sum of all integers 1 through 20 that are divisible by 3. Here are a few hints:

    1. The % operator gives you the remainder of a division operation.
    2. The if statement gives you the condition to see if a number should be part of the sum.
    3. The for loop can help you repeat a series of steps for all the numbers 1 through 20.
*/

int sum = 0;
for (int number = 0; number <= 20; number++)
{
    if (number % 3 == 0)
    {
        sum = sum + number;
        number++;
    }
}

Console.WriteLine($"The sum of the numbers is: {sum}");

/*  
    List Collection Challenge
    Try to write the code to generate the first 20 numbers in the sequence. (As a hint, the 20th Fibonacci number is 6765.)
*/

List<int> fibonacciNumbers = [1, 1];

do
{
    int previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    int previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(previous + previous2);
} while (fibonacciNumbers.Count < 20);

foreach (int item in fibonacciNumbers)
{
    Console.WriteLine(item);
};

