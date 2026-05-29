try
{
    CreditCard RaihanCard = new CreditCard();
    CreditCard BorhanCard = new CreditCard();

    RaihanCard.Setname("Raihan Gazi");
    BorhanCard.Setname("Borhan Ashrafi");

    RaihanCard.SetNumber("ABCD-12345");
    BorhanCard.SetNumber("ABCD-67890");

    // RaihanCard.BillPayment(200000);
    BorhanCard.BillPayment(180000);

    // RaihanCard.CashWithdraw(30000);
    BorhanCard.CashWithdraw(20000);

    // RaihanCard.Repayments(240000);

    Console.WriteLine($"{RaihanCard.GetName()} has {RaihanCard.GetBalance()} against the card {RaihanCard.GetNumber()}");
    Console.WriteLine($"{BorhanCard.GetName()} has {BorhanCard.GetBalance()} against the card {BorhanCard.GetNumber()}");

}catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
