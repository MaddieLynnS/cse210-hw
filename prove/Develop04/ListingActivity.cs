public class ListingActivity : Activity
{
    Random random = new Random();
    
    //List of questions the user may be presented
    private List<string> _beginningQuestions = new List<string>
    {
        "What are some things that have made you happy this week?",
        "Who are people that you know care about you?",
        "What are some things that remind you God loves you?",
        "How have you brought happiness to someone recently?",
        "What are you grateful for right now?",
        "What different feelings have you felt the last few days?"
    };

    //Standard constructor
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you list the good "+
        "things in life!! List as many as you can during the time "+
        "you set based on the prompt.";
    }

    public void MakeList()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadingSymbol(2);

        //Chooses a random question to show to the user
        Console.WriteLine("\nThink about all the responses you have for this prompt:\n");
        Console.WriteLine($"----- {_beginningQuestions[random.Next(0, _beginningQuestions.Count)]} -----\n");
        Thread.Sleep(1500);
        Console.Write("Your time will begin in: ");
        CountdownTimer(5);
        Console.Clear();

        //Will run until the duration the user entered has passed
        StartTimer();
        int totalItems = 0;
        while (!TimesUp())
        {
            //Allows user to enter items and keeps track of how
            //many list items they entered
            Console.Write("> ");
            Console.ReadLine();
            totalItems++;
        }
        
        Console.WriteLine($"\n\nYou listed {totalItems} items!");
        LoadingSymbol(1);
    }
}