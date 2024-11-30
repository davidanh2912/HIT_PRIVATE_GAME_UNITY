namespace TESTOOP;

public class CheckingAccount : Account
{
    public SavingAccount LinkedSavingAccount { get; set; }

    public CheckingAccount(string accountNumber, double balance, SavingAccount linkedSavingAccount = null)
        : base(accountNumber, balance)
    {
        LinkedSavingAccount = linkedSavingAccount;
    }

    public override bool Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            return true;
        }
        else if (LinkedSavingAccount != null)
        {
            double totalBalance = Balance + LinkedSavingAccount.Balance;
            if (amount <= totalBalance)
            {
                double remainingAmount = amount - Balance;
                Balance = 0;
                LinkedSavingAccount.Withdraw(remainingAmount);
                return true;
            }
        }

        return false;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Loại tài khoản: Tài khoản vãng lai");
    }
}