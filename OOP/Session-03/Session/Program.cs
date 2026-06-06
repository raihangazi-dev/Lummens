try
{
    Student Raihan = new Student("Raihan Gazi", "raihan@gmail.com", "STU0001");
    
    /*
    Raihan.StudentResultCard = new ResultCard("RES0001");
    Raihan.StudentResultCard.AddScore(80);
    Raihan.StudentResultCard.AddScore(80);
    Raihan.StudentResultCard.AddScore(90);
    Raihan.StudentResultCard.AddScore(85);
    Raihan.StudentResultCard.AddScore(84);
    */

    // /*
    ResultCard RaihanResultCard = new ResultCard("RES0001");
    Raihan.StudentResultCard = RaihanResultCard;
    RaihanResultCard.AddScore(90);
    RaihanResultCard.AddScore(90);
    RaihanResultCard.AddScore(90);
    RaihanResultCard.AddScore(80);
    RaihanResultCard.AddScore(90);
    // */

    Console.WriteLine($"{Raihan.Name}, regno is {Raihan.Regno} has got total of {Raihan.TotalScore} score and failed at {Raihan.Failed} subjects and His status is {Raihan.StudentStatus()}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}