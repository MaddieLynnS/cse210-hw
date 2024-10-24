using System.IO;

class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    //Constructor for if there is only one verse
    public Reference(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = "";
    }

    //Constructor for if there are multiple verses
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    //returns complete reference
    public override string ToString() 
    {
        string output = $"{_book} {_chapter}:{_startVerse}";
        if (_endVerse != "")
        {
            output += $"-{_endVerse}";
        }
        return output;
    }

}