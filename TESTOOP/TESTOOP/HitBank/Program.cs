namespace TESTOOP;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        HitBank bank = new HitBank();
        
        var savingAccount = new SavingAccount("SA123", 5000, 3.5);
        var checkingAccount = new CheckingAccount("CA123", 2000, savingAccount);

        var customer = new Customer("Nguyen Van A");
        customer.AddAccount(savingAccount);
        customer.AddAccount(checkingAccount);

        bank.AddCustomer(customer);
        
        customer.DisplayAccountsInfo();
        
        Console.WriteLine("\nGửi tiền vào tài khoản CA123:");
        bank.Deposit("CA123", 1000);
        customer.DisplayAccountsInfo();
        
        Console.WriteLine("\nRút tiền 8000 từ tài khoản CA123:");
        if (bank.Withdraw("CA123", 8000))
            Console.WriteLine("Rút tiền thành công!");
        else
            Console.WriteLine("Rút tiền thất bại!");
        customer.DisplayAccountsInfo();
    }
}