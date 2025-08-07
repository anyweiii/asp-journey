// Console.WriteLine("Hello, World!");

/*  
    Basic List Example
*/

List<string> names = ["Hui", "Ana", "Felipe"];
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");
}

Console.WriteLine();

names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");
}

Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

// Count, really counts the array
Console.WriteLine($"The list has {names.Count} people in it.");

/*  
    Search and sort lists
*/

var index = names.IndexOf("Felipe");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

index = names.IndexOf("Not Found");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

/*  
    Sorting
*/
names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

/*  
    List of other types
*/
// List<int> fibonacciNumbers = [1, 1];
// var previous = fibonacciNumbers[fibonacciNumbers.Count - 1]; // last item
// var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2]; // second to the last item

// fibonacciNumbers.Add(previous + previous2);

// foreach (var item in fibonacciNumbers)
// {
//     Console.WriteLine(item);
// }

/*  
    Challenge
    Expand on what you built so far with Fibonacci Numbers. Try to write the code to generate the first 20 numbers in the sequence. (As a hint, the 20th Fibonacci number is 6765.)

    fibonacci = first + previous
*/

List<int> fibonacciNumbers = [1, 1];

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}

foreach (var fibonacci in fibonacciNumbers)
{
    Console.WriteLine(fibonacci);
}
