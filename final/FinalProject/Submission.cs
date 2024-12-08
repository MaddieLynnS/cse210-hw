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

    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Submission Assignment has this file: {_fileName}."+
        $"\nIt's due on {GetDate()} and it's worth {GetPoints()} points.");
    }

    public override void CompleteAssignment()
    {
        throw new NotImplementedException();
    }
}