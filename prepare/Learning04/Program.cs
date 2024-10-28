using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Bob Thompson", "Mathss");
        MathAssignment mats = new MathAssignment("Bob THompson", "Mathies", "Section 2", "Problems 2-222");
        Console.WriteLine(mats.GetSummary());
        Console.WriteLine(mats.GetHomeworkList());
        WritingAssignment paper = new WritingAssignment("Bob Thompson", "English Paper", "History of Reporting");
        Console.WriteLine(paper.GetSummary());
        Console.WriteLine(paper.GetWritingInformation());
    }
}