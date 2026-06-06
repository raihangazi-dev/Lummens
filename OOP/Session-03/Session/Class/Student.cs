public class Student
{
    public string Name {get; private set;} = string.Empty;
    public string Regno {get; private set;} = string.Empty;
    public string Email {get; private set;} = string.Empty;

    // public int TotalScore {get; private set;}
    // public int Failed {get; private set;}
    // public ResultCard StudentResultCard{get; set;}

    public int TotalScore => StudentResultCard?.TotalObtainedScore ?? 0;
    public int Failed => StudentResultCard?.FailCount ?? 0;
    public ResultCard? StudentResultCard { get; set; }

    public Student ()
    {

    }
    public Student (string name, string email, string reg) : this ()
    {
        Name = name;
        Email = email;
        Regno = reg;
    }
    public string StudentStatus()
    {
        if(StudentResultCard == null)
        {
            throw new ArgumentException ("Student result card not defined");
        }
        return StudentResultCard.Ispassed() ? "Passed" : "Failed";
    }
}
