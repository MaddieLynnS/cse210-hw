public class Quiz : Assignment
{
    private int _questionAmount;

    public Quiz(string name, int points, int dur, DateTime due, int questions)
    : base(name, points, dur, due)
    {
        _questionAmount = questions;
    }
}