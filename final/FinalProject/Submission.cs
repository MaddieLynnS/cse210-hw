public class Submission : Assignment
{
    //Private variables specific to this type
    private string _fileName;
    private string _docType;

    //Constructor
    public Submission(string name, int points, int dur, DateTime due, string doc)
    : base(name, points, dur, due)
    {
        _docType = doc;
    }

    //Prints assignment info
    public override void PrintAssignmentInfo()
    {
        Console.WriteLine($"This Submission Assignment is about {GetName()}  and needs this file type: "+
        $"{_docType} \nIt's due on {GetDueDate()} and it's worth {GetPoints()} points.");
    }

    //Completes assignment
    public override void CompleteAssignment()
    {
        Console.Write("Enter the name of the file you'd like to submit: ");
        _fileName = Console.ReadLine() + $".{_docType}";
    }
}