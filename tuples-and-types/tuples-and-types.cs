// Console.WriteLine("Hello, World!");


/* 
    Record Type
*/
using System;

public record Point(int X, int Y);

public class Program {
    public static void Main()
    {
        Point pt = new Point(1, 1);
        var pt2 = pt with { Y = 10 };
        Console.WriteLine($"The two points are {pt} and {pt2}");
    }
}



/*  
    Tuples
*/

/* var pt = (X: 1, Y: 2);
var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}");

pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");

var pt2 = pt with { Y = 10 };
Console.WriteLine($"The point 'pt2' is at {pt2}");

var subscript = (A: 0, B: 0);
subscript = pt;
Console.WriteLine(subscript);

var namedData = (
    Name: "Morning Observation",
    Temp: 17,
    Wind: 4
);

var person = (
    FirstName: "",
    LastName: ""
);

var order = (
    Product: "Guitar Picks",
    Style: "Triangle",
    Quantity: 500,
    UnitPrice: 0.10m
);

Console.WriteLine(namedData);
Console.WriteLine(person);
Console.WriteLine(order); */

