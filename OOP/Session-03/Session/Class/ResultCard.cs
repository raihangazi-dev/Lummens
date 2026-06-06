public class ResultCard
{
    public static int TotalSubjects {get; private set;}
    public static int PassingMark {get; private set;}
    public string ResultId {get; private set;} = string.Empty;
    public int TotalObtainedScore {get; private set;}
    public int FailCount {get; private set;}
    private int ScoreAddedCount;

    static ResultCard()
    {
        PassingMark = 400;
        TotalSubjects = 5;
    }
    public ResultCard()
    {
        FailCount = 0;
        TotalObtainedScore = 0;
        ScoreAddedCount = 0;
    }

    public ResultCard (string id) : this ()
    {
        ResultId = id;
    }

    public void AddScore (int score)
    {
        if(score < 0  || score > 100)
        {
            throw new ArgumentException ("Score can not be negative or more than 100");
        }
        if(ScoreAddedCount >= 5)
        {
            throw new ArgumentException ("Already added score for all the subjects");
        }

        if(score < 80) FailCount++;
        ScoreAddedCount++;
        TotalObtainedScore += score;
    }

    public bool Ispassed ()
    {
        if(TotalObtainedScore >= PassingMark && FailCount == 0)
        {
            return true;
        }
        return false;
    }

}