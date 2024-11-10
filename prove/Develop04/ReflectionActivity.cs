public class ReflectionActivity : Activity
{
    //Initializing variables
    Random random = new Random();
    int questionIndex;
    private List<string> _reflectivePrompts = new List<string>
    {
        "Think of a time you overcame a trial you didn't think you could.",
        "Think of a time when you did something kind for someone else.",
        "Think of a time when you acted even though you were scared.",
        "Think of a time you turned your day around when it started out bad."
    };
    private List<string> _questions = new List<string>();

    //Standard constructor
    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times " +
        "in your life when you have been resilient or overcome something " +
        "difficult. Reflecting on these times will remind you that you are " +
        "strong and can keep pushing forward!";
    }

    //Restores list of questions whenever the list is empty
    private void LoadList()
    {
        _questions.Add("How did you feel before this experience began?");
        _questions.Add("How did this experience make you feel afterwards?");
        _questions.Add("What did you like about this experience?");
        _questions.Add("What did you learn about yourself by doing this?");
        _questions.Add("Why does this experience matter to you?");
        _questions.Add("How did this experience change you?");
        _questions.Add("What prompted you to do this?");
        _questions.Add("Would you do something like this again?");
    }

    public void Reflect()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadingSymbol(2);

        //Chooses a random prompt and displays it
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"\n----- {_reflectivePrompts[random.Next(0, _reflectivePrompts.Count)]} -----\n");
        Console.Write("When you have some responses in mind, press enter to begin.");
        Console.ReadLine();
        Console.WriteLine("Think of your response to each of these questions as they appear onscreen.");
        Thread.Sleep(1500);
        Console.Write("Your time will begin in: ");
        CountdownTimer(5);
        Console.Clear();

        //This will run until the duration the user input has ended
        StartTimer();
        while(!TimesUp())
        {
            //This will make sure the questions don't get repeated
            //and restore the list if needed
            if(_questions.Count <= 0)
            {LoadList();}

            //Display random questions for user to ponder
            questionIndex = random.Next(0, _questions.Count);
            Console.Write($"\n> {_questions[questionIndex]} ");
            _questions.RemoveAt(questionIndex);
            LoadingSymbol(3);
        }
    }
}