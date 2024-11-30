namespace TESTOOP;

public class SavingAccount : Account
{
    public double InterestRate { get; set; }

    public SavingAccount(string accountNumber, double balance, double interestRate) : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override bool Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            return true;
        }

        return false;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Lãi suất: {InterestRate}%");
    }
}