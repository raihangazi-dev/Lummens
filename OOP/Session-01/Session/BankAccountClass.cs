public class BankAccount()
{
    private string name;
    private string accountnumber;
    private decimal balance;

    public string GetName ()
    {
        return name;
    }

    public void SetName(string customerName)
    {
        this.name = customerName;
    }

    public string GetAccountnumber()
    {
        return accountnumber;
    }

    public decimal GetBalance ()
    {
        return balance;
    }

    public void Deposit (decimal amount)
    {
        if (amount < 0 )
        {
            throw new ArgumentException("Negative balance can not be deposited.");
        }
        balance += amount;
    }

    public void Withdraw (decimal amount)
    {
        if(amount > balance)
        {
            throw new ArgumentException ("You do not have sufficient balance.");
        }
        balance -= amount;
    }
}

