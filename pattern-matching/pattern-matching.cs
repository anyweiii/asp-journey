// Console.WriteLine("Hello, World!");

/*  
    Match a value
*/

string bankRecords = """
    DEPOSIT, 1000, Initiial balance
    DEPOSIT, 500, Regular Deposit
    WITHDRAWAL, 1000, Rent
    DEPOSIT, 2000, Freelance Payment
    WITHDRAWAL, 300, Groceries
    DEPOSIT, 700, Gift from Friend
    WITHDRAWAL, 150, Utility Bill
    DEPOSIT, 1200, Tax Refund
    WITHDRAWAL, 500, Car Maintenance
    DEPOSIT, 400, Cashback Reward
    WITHDRAWAL, 250, Dining Out
    DEPOSIT, 3000, Bonus Payment
    WITHDRAWAL, 800, Loan Repayment
    DEPOSIT, 600, Stock Dividends
    WITHDRAWAL, 100, Subsciption Fee
    DEPOSIT, 1500, Side Hustle Income
    WITHDRAWAL, 200, Fuel Expenses
    DEPOSIT, 900, Refund from Store
    WITHDRAWAL, 350, Shopping
    DEPOSIT, 2500, Project Milestone Payment
    WITHDRAWAL, 400, Entertainment
""";

double CurrentBalance = 0.0;
// String Reader - reads the strings inside the bankRecords.
var reader = new StringReader(bankRecords);

string? line;
// if the reader.Readline is not null proceed the operation.
while ((line = reader.ReadLine()) is not null)
{
    // if the line is null or in white space proceed to the next line.
    if (string.IsNullOrWhiteSpace(line)) continue;

    // Split arrays into comma
    string[] parts = line.Split(',');

    // Trim first part or item for whitespaces
    string? transactionType = parts[0]?.Trim();

    // If the value in position 1 is number then it will proceed if not it will return a false value.
    if (double.TryParse(parts[1].Trim(), out double amount))
    {
        if (transactionType?.ToUpper() is "DEPOSIT")
            CurrentBalance += amount;
        else if (transactionType?.ToUpper() is "WITHDRAWAL")
            CurrentBalance -= amount;

        Console.WriteLine($"{line.Trim()} => Parsed Amount: {amount}, New Balance: {CurrentBalance}");
    }
}