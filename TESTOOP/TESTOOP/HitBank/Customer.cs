namespace TESTOOP;

public class Customer
{
    public string Name { get; set; }
    private List<Account> Accounts { get; set; }

    public Customer(string name)
    {
        Name = name;
        Accounts = new List<Account>();
    }

    public void AddAccount(Account account)
    {
        if (Accounts.Count < 4)
            Accounts.Add(account);
    }

    public Account GetAccount(string accountNumber)
    {
        return Accounts.Find(acc => acc.AccountNumber == accountNumber);
    }

    public void DisplayAccountsInfo()
    {
        Console.WriteLine($"Khách hàng: {Name}, Tổng số tài khoản: {Accounts.Count}");
        double totalBalance = 0;
        foreach (var account in Accounts)
        {
            account.DisplayInfo();
            totalBalance += account.Balance;
        }

        Console.WriteLine($"Tổng số tiền: {totalBalance}");
    }
}