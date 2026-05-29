public class CreditCard
{
    private string name;
    private string number;
    private decimal balance = 500000;

    public void Setname (string cardholderName)
    {
        if(cardholderName.Length < 3)
        {
            throw new ArgumentException("Invalid Name. Cardholder name can't be less than 3 characters.");
        }
        if(cardholderName is not string )
        {
            throw new ArgumentException("Invalid Name. Name can't be anything else string");
        }
        this.name = cardholderName;
    }

    public string GetName ()
    {
        return name;
    }

    public void SetNumber (string accountNumber)
    {
        if(accountNumber.Length < 10 || accountNumber.Length > 10)
        {
            throw new ArgumentException ("Account number must be 10 characters long.");
        }

        this.number = accountNumber;
    }

    public string GetNumber ()
    {
        return number;
    }

    public decimal GetBalance ()
    {
        return balance;
    }

    public void CashWithdraw (decimal amount)
    {
        if(amount > balance)
        {
            throw new ArgumentException ("You do not have sufficient balance");
        }
        if(amount > 50000)
        {
            throw new ArgumentException ("You can not withdraw more than 50000 TK per transaction");
        }
        this.balance -= amount;
    }

    public void BillPayment (decimal amount)
    {
        if(amount > balance)
        {
            throw new ArgumentException ("You do not have sufficient balance");
        }
        this.balance -= amount;        
    }

    public void Repayments (decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException ("Negative amount is not possible.");
        }
        if(balance == 500000)
        {
            throw new ArgumentException ("You do not have any repayments.");
        }
        if((balance + amount) >= 500000)
        {
            throw new ArgumentException ($"You have to pay {500000 - balance}.");
        }

        this.balance += amount;

    }

}