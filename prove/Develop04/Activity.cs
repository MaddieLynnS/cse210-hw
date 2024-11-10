public class Activity
{
    //Initialize variables
    protected string _name;
    protected string _description;
    private int _duration = 0;
    private DateTime futureTime;

    public void SetDuration(int newDuration)
    {
        _duration = newDuration;
    }

    public Activity()
    {
        _name = "Activity";
        _description = "description";
    }

    //Standard messages to display
    public override string ToString()
    {
        return $"\n{_name}: \n{_description}";
    }

    public string StartMessage()
    {
        return $"Welcome to the {_name}.\n\n{_description}\n\nEnter how many seconds you would like this session to last: ";
    }

    public string EndMessage()
    {
        return $"\nYou're done!!\n\nYou have completed {_duration} seconds" +
        $" of the {_name}.";
    }

    //Creates and erases text to look like a loading symbol
    public void LoadingSymbol(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Console.Write('|');
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    //Counts down until a certain amount of time has passed
    public void CountdownTimer(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    //Starts countdown using DateTime for start and end
    public void StartTimer()
    {
        futureTime = DateTime.Now.AddSeconds(_duration);
    }

    //Turns true when a certain amount of time has passed
    public bool TimesUp()
    {
        if (DateTime.Now < futureTime)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}