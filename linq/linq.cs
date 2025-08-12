// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Specify the data source.
int[] scores = [97, 92, 81, 60];

// Define the query expression.
IEnumerable<string> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select $"The score is: {score}";

// Execute the query.
foreach (string i in scoreQuery)
{
    Console.WriteLine(i);
}

// Output: 97 92 81