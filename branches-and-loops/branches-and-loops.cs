// Console.WriteLine("Hello, World!");

/*  
    IF STATEMENTS AND LOOPS
*/

/* 
    int a = 5;
    // int b = 6;
    int b = 3;
    if (a + b > 10)
        Console.WriteLine("The answer is greater than 10"); 
*/

/*  
    MAKE IF AND ELSE WORK TOGETHER
*/

/*  
    int a = 5;
    int b = 3;
    if (a + b > 10)
        Console.WriteLine("The answer is greater than 10");
    else
        Console.WriteLine("The answer is not greater than 10");
*/

/* 
    int a = 5;
    int b = 3;
    if (a + b > 10)
    {
        Console.WriteLine("The answer if greater than 10");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
    } 
*/

/*  
    int a = 5;
    int b = 3;
    int c = 4;

    if ((a + b + c > 10) || (a == b))
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("And the first number is equal to the second");
        }
    else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("Or the first number is not equal to the second number");
        }
*/

/*  
    Use loops to repeat operations
    While Loop
*/

/*  
    int counter = 0;
    while (counter < 10) // 0
    {
        Console.WriteLine($"Hello World, the counter is {counter}");
        counter++; // 1
    }
*/

/*  
    DO - WHILE LOOP
    Do the code first before checking the condition
*/

/* 
    int counter = 0;
    do
    {
        Console.WriteLine($"Hello world! The counter is {counter}");
        counter++;
    } while (counter < 10); 
*/

/*  
    FOR LOOP
*/

/* 
    for (int counter = 0; counter < 10; counter++)
    {
        Console.WriteLine($"Hello world! The counter is {counter}");
    } 
*/

/*  
    NESTED LOOPS
*/

/* 
    for (int row = 1; row < 11; row++)
    {
        Console.WriteLine($"The row is {row}");
    }

    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The column is {column}");
    }

    for (int row = 1; row < 11; row++)
    {
        for (char column = 'a'; column < 'k'; column++)
        {
            Console.WriteLine($"The cell is ({row}, {column})");
        }
    } 
*/

/*  
    Challenge
    Find the sum of all inttegers 1 through 20 that is divisible by 3
*/
int sum = 0;
for (int number = 0; number <= 20; number++)
{
    if (number % 3 == 0)
    {
        sum = sum + number;
    }
}
Console.WriteLine($"The sum is equal to {sum}");