// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string aFriend = "Bill";
Console.WriteLine(aFriend);

aFriend = "Maria";
Console.WriteLine(aFriend);

Console.WriteLine("Hello" + " " + aFriend);

// $ includes a variable. String interpolation. String concatenation / literals. 

Console.WriteLine($"Hello {aFriend}");

/* 
    Working with strings 
    String - sequence of characters and described by double quotes ("")
*/

string firstFriend = "Maria";
string secondFriend = "Sage";

Console.WriteLine("My friends are " + firstFriend + " " + "and " + secondFriend);
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// .length counts the number of letters in a string including spaces
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

/* 
    Trim
*/

string greeting = "                 Hello World!          ";
Console.WriteLine($"[{greeting}]");

// trims start
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

// trims end
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

// trims both sides
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

/* 
    Replace
*/

string sayHello = "Hello World";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

// Capitalization
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

/* 
    Seach Strings
*/
 
string songLyrics = "You say goodbye and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye")); // true
Console.WriteLine(songLyrics.Contains("greetings")); // false
Console.WriteLine(songLyrics.StartsWith("You")); // true
Console.WriteLine(songLyrics.EndsWith("hello")); // true
Console.WriteLine(songLyrics.StartsWith("goodbye")); // false
Console.WriteLine(songLyrics.EndsWith("goodbye")); // false
