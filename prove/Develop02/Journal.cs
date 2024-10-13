using System.IO;

//Journal class containing functions for saving multiple Entry objects, saving a Journal file, or loading a Journal file
class Journal
{
    //Initialize variables
    Random _random = new Random();
    private List<Entry> _entries = new List<Entry>();
    private string _entryPrompt;

    //function that randomly chooses a prompt and assigns it using a switch/case block
    private string RandomPrompt() {
        int randNum = _random.Next(1, 7);
        switch (randNum) 
        {
            case 1:
                _entryPrompt = "What is something that made you smile today?";
                return _entryPrompt;
            case 2:
                _entryPrompt = "What was a positive interaction you had this past week?";
                return _entryPrompt;
            case 3:
                _entryPrompt = "How have you gotten closer to Jesus Christ in the last few days?";
                return _entryPrompt;
            case 4:
                _entryPrompt = "Have you tried anything new lately?";
                return _entryPrompt;
            case 5:
                _entryPrompt = "What's something about today you want to make sure you don't forget?";
                return _entryPrompt;
            case 6:
                _entryPrompt = "What did you do to make someone else happy today?";
                return _entryPrompt;
            case 7:
                _entryPrompt = "Anything you're looking forward to?";
                return _entryPrompt;
        }
        return _entryPrompt;
    }

    //chooses from the prompts and returns it to the Program
    public string PrintPrompt()
    {
        RandomPrompt();
        return _entryPrompt;
    }

    //takes an Entry object from the Program and saves it in the Journal entries list
    public void AddEntry(Entry _dailyEntry)
    {
        _entries.Add(_dailyEntry);
        Console.WriteLine("Entry added successfully!");
    }

    //iterates through all entries in a Journal and displays them
    public void PrintJournal()
    {
        foreach (Entry i in _entries)
        {
            i.PrintEntry();
        }
    }

    //writes all lines of each Journal entry into a file named based on user input
    public void SaveJournal()
    {
        Console.Write("Enter the name of the file you want to save this to: ");
        string _filename = Console.ReadLine() + ".txt";

        //creates file and saves each entry into the file
        using (StreamWriter _outputFile = new StreamWriter(_filename))
        {
            foreach (Entry i in _entries)
            {
                _outputFile.WriteLine($"{i._prompt}~{i._input}~{i._date}");
            }
        }
        Console.WriteLine("File saved successfully!");
    }

    //loads a previously saved journal and prints all entries in the file
    public void LoadJournal()
    {
        Console.Write("Enter the name of the file you would like to load: ");
        string _input = Console.ReadLine() + ".txt";

        string[] _lines = File.ReadAllLines(_input);

        foreach (string line in _lines)
        {
            string[] parts = line.Split("~");
            Console.WriteLine($"Entry for {parts[2]}");
            Console.WriteLine($"Prompt: {parts[0]}");
            Console.WriteLine($"Your entry: {parts[1]}\n");
            
        }
    }
}