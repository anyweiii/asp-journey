// using of Classes from the System namespace
using System;

// container for classes and other namespaces
namespace HelloWorld
{
    // container for data and methods - every line of code that runs in C# must be inside a class
    class Program
    {
        // Any code inside the brackets will be ran when debugged
        static void Main(string[] args)
        {
            // Can also be written as System.Console.WriteLine() if using System is ommited
            Console.WriteLine("Hello World");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);
            Console.Write("Hello World! ");
            Console.WriteLine("I will print on the same line.");

            /*  
                int - stores integers (whole numbers) such as 123 or -123
                double - stores floating point numbers, with decimals such as 19.99 or -19.99
                char - store single characters reprsented by single quotes
                string - stores text represented by double quotes
                bool - stores values with true or false
            */

            // string name = "John";
            // Console.WriteLine(name);

            // int myNum = 15;
            // Console.WriteLine(myNum);

            // int myNum = 15;
            // myNum = 20;
            // Console.WriteLine(myNum);

            // Constant value is not changeable
            // const int myNum = 15;
            // myNum = 20;

            // string name = "John";
            // Console.WriteLine("Hello " + name);

            // string firstName = "John ";
            // string lastName = "Doe";
            // string fullName = firstName + lastName;
            // Console.WriteLine(fullName);

            // int x = 5;
            // int y = 6;
            // Console.WriteLine(x + y);

            // Multiple Variables
            // int x = 5, y = 6, z = 50;
            // Console.WriteLine(x + y + z);

            // int x, y, z;
            // x = y = z = 50;
            // Console.WriteLine(x + y + z);

            /*  
                DATA TYPES
            */

            // int - can store whole number from -2147483648 to 2147483647.
            int myNum = 100000;
            Console.WriteLine(myNum);

            // long - can store whole number from -9223372036854775808 to 9223372036854775807.
            long myNum1 = 15000000000L;
            Console.WriteLine(myNum1);

            // float - precision is only six or seven decimal digits
            float myNum2 = 5.75F;
            Console.WriteLine(myNum2);

            // double - precision of about 15 digits
            double myNum3 = 19.99D;
            Console.WriteLine(myNum3);

            // e - means power of 10
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            // Booleans
            // bool isCSharpFun = true;
            // bool isFishTasty = false;
            // Console.WriteLine(isCSharpFun);
            // Console.WriteLine(isFishTasty);

            // Characters
            char myGrade = 'B';
            Console.WriteLine(myGrade);

            // Strings
            // string greeting = "Hello World";
            // Console.WriteLine(greeting);

            /* 
                C# Type Casting
                Implicit Casting (automatically) - converting a smaller type to a larger type size
                char - int - long - float - double

                Explicit Casting (manual) - converting a larger type to a smaller size type
                double - float - long - int - char
            */

            // Implicit Casting
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            // Explicit Casting
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2;
            Console.WriteLine(myDouble2);
            Console.WriteLine(myInt2);

            // Conversion Methods
            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt3));
            Console.WriteLine(Convert.ToDouble(myInt3));
            Console.WriteLine(Convert.ToInt32(myDouble3));
            Console.WriteLine(Convert.ToString(myBool));

            // Get User Input
            // Type your username and press enter
            // Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            // string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            // Console.WriteLine("Username is: " + userName);
            // string test = "hello";
            // Console.WriteLine(Convert.ToInt32(test));

            // Console.WriteLine("Enter your age:");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Your age is: " + age);

            // Operators
            // int x = 100 + 50;
            // int sum1 = 100 + 50;
            // int sum2 = sum1 + 250;
            // int sum3 = sum2 + sum2;

            /*  
                C# Math
            */
            // returns the maximum value
            Console.WriteLine(Math.Max(5, 10));
            // returns the minimum value
            Console.WriteLine(Math.Min(5, 10));
            // returns the square root 
            Console.WriteLine(Math.Sqrt(64));
            // absolute value
            Console.WriteLine(Math.Abs(-4.7));
            // rounding of
            Console.WriteLine(Math.Round(9.99));

            /*  
                Strings
            */

            // string greeting = "Hello";
            // string greeting2 = "Nice to meet you";
            // string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // Console.WriteLine("The length of the txt string is: " + txt.Length);

            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper());
            Console.WriteLine(txt2.ToLower());

            /*  
                String Concatenantion
            */
            // string firstName = "John ";
            // string lastName = "Doe";
            // string name = firstName + lastName;
            // Console.WriteLine(name);

            // int x = 10;
            // int y = 20;
            // int z = x + y;

            // Console.WriteLine(z);

            // string x = "10";
            // string y = "20";
            // string z = x + y;

            // Console.WriteLine(z);

            // String Interpolation
            // string firstName = "John";
            // string lastName = "Doe";
            // string name = $"My full name is: {firstName} {lastName}";
            // Console.WriteLine(name);

            // Access Strings
            string myString = "Hello";
            Console.WriteLine(myString[0]);
            Console.WriteLine(myString[1]);
            Console.WriteLine(myString.IndexOf("e"));

            string name = "John Doe";
            int charPos = name.IndexOf("D");
            string lastName = name.Substring(charPos);
            Console.WriteLine(lastName);

            // Special Characters
            // string txt = "We are the so-called \"Vikings\" from the north";
            // txt = "It\'s alright.";

            // Booleans
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            // int x = 10;
            // int y = 9;
            // Console.WriteLine(x > y);
            // Console.WriteLine(x == 10);
            // Console.WriteLine(10 == 15);

            int myAge = 25;
            int votingAge = 18;
            Console.WriteLine(myAge >= votingAge);

            if (myAge >= votingAge)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }

            // IF Else Statement
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
        }
    }
} 