public class Level
{
    private int _level;
    private string _levelName;
    private string _levelDescription;

    public Level()
    {
        _level = 0;
        _levelName = "Extreme Ultra Noob";
        _levelDescription = "Either you are brand new to this, " +
        "or you are the laziest person known to man. Get on it!";
    }

    public int GetLevel()
    {
        return _level;
    }

    public void SetLevel(int level)
    {
        _level = level;
    }

    public void UpdateValues()
    {
        switch(_level)
        {
            case 1:
                _levelName = "Uncertain Ninja";
                _levelDescription = "As the name implies, you are clumsy, noisy" +
                "prone to mistakes, but at least you're still trying";
                break;
            case 2:
                _levelName = "That One Kid at Walmart";
                _levelDescription = "You know you're here for a reason... now"+
                " if you could remember what it was... then you could go home";
                break;
            case 3:
                _levelName = "Just Your Average Plastic Cup";
                _levelDescription = "You are decently productive, and you're"+
                " getting stuff done, but you'll get crusty if you stop now";
                break;
            case 4:
                _levelName = "The Proud Blade of Grass";
                _levelDescription = "You are tall, happy, and elegant. No one"+
                "can challenge you, because you are beyond the reach of the lawn"+
                "mower and the goal-haters.";
                break;
            case 5:
                _levelName = "Straight-A Middle Schooler";
                _levelDescription = "You are really good at getting things done!"+
                " The only problem- well, you're a middle schooler. Come on.";
                break;
            case 6:
                _levelName = "Extra Slay Style Koala";
                _levelDescription = "You have sunglasses and a crocodile skin"+
                " purse. Anyone that doubts you is CLEARLY an idiot.";
                break;
            case 7:
                _levelName = "Get That Dough Like a Mario Bro";
                _levelDescription = "Yahoo! You-a got more points! Nothing"+
                " can-a stop you! Let's-a go!!";
                break;
            case 8:
                _levelName = "Made from 100% recycled Material";
                _levelDescription = "You don't let anything stand in your way-"+
                " not even death! You keep coming back bigger and better and"+
                " nothing is gonna change that!";
                break;
            case 9:
                _levelName = "Nearly Complete Masterpiece";
                _levelDescription = "You have come so far and have invested"+
                " so much time in succeeding. Now, just don't mess up that"+
                " final, finishing stroke... WATCH OUT-";
                break;
            case 10:
                _levelName = "Completionist Queen King Conqueror";
                _levelDescription = "How did you even get here. There are"+
                " no more levels! You are the best at doing things. I have "+
                "no more words for you. Big proud :)";
                break;
            default:
                _level = 0;
                Console.WriteLine("Some error occurred. Guess you get to start over mwahahaha");
                break;
        }
    }

    public void GetLevelStatus()
    {
        Console.WriteLine($"You are a level {_level} - {_levelName}\n");
        Console.WriteLine($"{_levelDescription}\n");
    }

    
}