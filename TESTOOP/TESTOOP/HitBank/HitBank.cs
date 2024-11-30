namespace TESTOOP;

public class HitBank
{
    private List<Customer> Customers { get; set; }

    public HitBank()
    {
        Customers = new List<Customer>();
    }

    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public Customer FindCustomer(string nameOrAccountNumber)
    {
        foreach (var customer in Customers)
        {
            if (customer.Name == nameOrAccountNumber)
                return customer;

            if (customer.GetAccount(nameOrAccountNumber) != null)
                return customer;
        }

        return null;
    }

    public bool RemoveCustomer(string name)
    {
        var customer = Customers.Find(c => c.Name == name);
        if (customer != null)
        {
            Customers.Remove(customer);
            return true;
        }

        return false;
    }

    public bool Deposit(string accountNumber, double amount)
    {
        foreach (var customer in Customers)
        {
            var account = customer.GetAccount(accountNumber);
            if (account != null)
                return account.Deposit(amount);
        }

        return false;
    }

    public bool Withdraw(string accountNumber, double amount)
    {
        foreach (var customer in Customers)
        {
            var account = customer.GetAccount(accountNumber);
            if (account != null)
                return account.Withdraw(amount);
        }

        return false;
    }
}