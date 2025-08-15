// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Random dice = new Random();
// int roll = dice.Next(1, 6);
// Console.WriteLine(roll);


// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

/*  
    Code challenge: Implement a method of the Math class that returns the larger of two numbers
*/

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

/*  
    Create Decision Logic with IF Statements
*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

/*  
    Double Bonus
*/

/*  
    Add an if statement to display different messages based on the value of the total variable
*/

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1)) // Compound condition
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

string message = "The quick brown fox jumps over the lazy dog";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

/*  
    Improve Renewal Rate of Subscriptions
*/

Random random = new Random();
int daysUntilExpiration = 5; //random.Next(12);
int discountPercentage = 0;

// subscription <= 10 (Your subscription will expire soon. Renew now!)
// subscription <= 5 (Your subscription expires in _ days. Renew now and save 10%)
// subscription = 1 (Your subscription expires within a day! Renew now and save 20%)
// subscription > 10 (No display)

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}

/*  
    Arrays
*/

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

/*  
    Length Array Property
*/

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process");

/*  
    ForEach Statement
*/
string[] names = ["Rowena", "Robin", "Bao"];
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory");

string[] fraudOrder = [
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
];

foreach (string order in fraudOrder)
{
    if (order.StartsWith("B"))
    {
        Console.WriteLine($"These are the Fraud IDs: {order}");
    }
}

string firstName = "Bob";
int widgetSold = 7;
Console.WriteLine($"{firstName} sold {widgetSold} widgets.");

string[] orderIDs = new string[5]; // Creation of Array with max 5 values
for (int i = 0; i < orderIDs.Length; i++)
{
    // Prefix Values are between 65 to 70 in ASCII
    int prefixValue = random.Next(65, 70);
    // Conversion of the prefix value to Character and String
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Choosing of Random Value then Converting to String
    string suffix = random.Next(1, 1000).ToString("000");
    // orderID is the combination of the prefix and suffix
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}