public class Submission : Assignment
{
    private string _fileName;
    private int _docType;

    public Submission(string name, int points, int dur, DateTime due, string file, int type)
    : base(name, points, dur, due)
    {
        _fileName = file;
        _docType = type;
    }
}