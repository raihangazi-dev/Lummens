try
{
    List<BankAccount> BankAccountList = new List<BankAccount>();

    BankAccount Raihan = new BankAccount
    {
        CustomerName = "Raihan Gazi",
        AccountNumber = "13110002365",
    };
    BankAccount Borhan = new BankAccount
    {
        CustomerName = "Borhan Ashrafi",
        AccountNumber = "13110002366",
    };
    BankAccount Fahim = new BankAccount
    {
        CustomerName = "Quazi Fahim",
        AccountNumber = "13110002367",
    };
    BankAccount Mamun = new BankAccount
    {
        CustomerName = "Mamun Hossain",
        AccountNumber = "13110002368",
    };

    Raihan.Deposit(20000);
    Borhan.Deposit(15000);
    Fahim.Deposit(30000);
    Mamun.Deposit(5000);

    Raihan.Withdraw(5000);
    Mamun.Withdraw(3000);

    BankAccountList.Add(Raihan);
    BankAccountList.Add(Borhan);
    BankAccountList.Add(Fahim);
    BankAccountList.Add(Mamun);

    decimal bankDeposit = 0;

    foreach(BankAccount account in BankAccountList)
    {
        bankDeposit += account.Balance;
    }

    Console.WriteLine(bankDeposit);

}catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}