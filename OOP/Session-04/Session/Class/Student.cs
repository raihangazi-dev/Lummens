public class Student
{
    public string Name {get;private set;}
    public string RegNo {get;private set;}
    public string Email {get;private set;}
    public ResultCard StudentResultCard {get; set;}

    public Student()
    {
        
    }

    public Student(string name, string regNo, string email) : this()
    {
        Name = name;
        RegNo = regNo;
        Email = email;
    }

    public bool IsPassed()
    {
        if (StudentResultCard == null)
        {
            throw new InvalidOperationException("Result card is not assigned to the student.");
        }

        if (StudentResultCard.TotalObtainedScore >= 250)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

}