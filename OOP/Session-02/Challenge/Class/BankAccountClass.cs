public class BankAccount
{
    public string CustomerName {get; set;}
    public string AccountNumber {get; set;}
    public decimal Balance {get; private set;}

    public BankAccount (string name, string number) : this (number)
    {
        this.CustomerName = name;
    }
    public BankAccount (string number) : this ()
    {
        this.AccountNumber = number;
    }
    public BankAccount ()
    {
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException ("Amount can not be negative or zero.");
        }
        Balance += amount;
    }
    public void Withdraw (decimal amount)
    {
        if (amount > Balance)
        {
            throw new ArgumentException("You do not have sufficient Balance.");
        }
        Balance -= amount;
    }
}