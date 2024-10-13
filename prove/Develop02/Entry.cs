//Entry class that creates Entry objects and prints info for an Entry
class Entry
{
    //Initialize variables
    public string _prompt;
    public string _input;
    public string _date;

    //stores required info in an Entry object
    public Entry(string _prompt, string _userInput, string _currentDate)
    {
        this._prompt = _prompt;
        _input = _userInput;
        _date = _currentDate;
    }

    //prints an Entry object's properties
    public void PrintEntry()
    {
        Console.WriteLine($"Entry for {_date}-");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Your entry: {_input} \n");
    }
}