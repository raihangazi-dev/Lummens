public class ResultCard
{
    public string ResultId {get; private set;}
    public double TotalObtainedScore {get; private set;}
    public static int TotalSubjects {get; private set;}
    private int totalCountOfAddMethodCall;

    static ResultCard()
    {
        TotalSubjects = 5;   
    }

    public ResultCard()
    {
        totalCountOfAddMethodCall = 0;
        TotalObtainedScore = 0;
    }

    public ResultCard(string resultId) : this()
    {
        ResultId = resultId;
    }

    public void AddScore(double score)
    {
        if (score < 0 || score > 100)
        {
            throw new ArgumentException("Score cannot be negative or greater than 100.");
        }

        if (TotalObtainedScore + score > 500)
        {
            throw new ArgumentException("Total score cannot be greater than 500.");
        }

        if (totalCountOfAddMethodCall >= 5)
        {
            throw new ArgumentException("You have already added scores for 5 subjects. Cannot add more.");
        }

        TotalObtainedScore += score;
        totalCountOfAddMethodCall++;
    }

}