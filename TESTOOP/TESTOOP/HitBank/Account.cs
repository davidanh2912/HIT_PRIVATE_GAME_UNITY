namespace TESTOOP;

public abstract class Account
{
    public string AccountNumber { get; set; }
    public double Balance { get; protected set; }

    public Account(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual bool Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            return true;
        }

        return false;
    }

    public abstract bool Withdraw(double amount);

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Account number: " + AccountNumber + "\nBalance: " + Balance);
    }
}