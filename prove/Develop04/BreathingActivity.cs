public class BreathingActivity : Activity
{
    //Standard constructor
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by counting out " +
        "your breathing to slow it down. Clear your mind and focus on your breathing.";
        
    }

    public void Breathe()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadingSymbol(2);
        
        StartTimer();
        while(!TimesUp())
        {
            Console.Write("\nBreathe in...");
            CountdownTimer(7);
            Console.Write("\nNow breathe out...");
            CountdownTimer(5);
            Console.WriteLine();
        }
    }
}