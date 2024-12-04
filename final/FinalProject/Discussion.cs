public class Discussion : Assignment
{
    private string _topic;
    private int _wordCount;
    private int _numRequiredResponses;

    public Discussion(string name, int points, int dur, DateTime due, string top, int count, int res)
    : base(name, points, dur, due)
    {
        _topic = top;
        _wordCount = count;
        _numRequiredResponses = res;
    }
}