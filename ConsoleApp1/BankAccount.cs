public class BankAccount
{
    private string accountNumber;
    private double balance;

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Balance cannot be zero or negative.");
            }
        }
    }

    // Constructor to set account number and initial balance
    public BankAccount(string accNum, double initialBalance)
    {
        accountNumber = accNum;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than 0.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid withdraw amount.");
        }
    }
}