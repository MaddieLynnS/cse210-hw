using System.IO;
using System.Reflection.Metadata.Ecma335;

class Scripture
{
    private Reference _reference;
    private string _scriptureText;
    private List<Word> _words = new List<Word>();
    Random random = new Random();
    private int wordTotal = 0;

    //Constructor containing a reference and its text
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _scriptureText = scriptureText;
    }

    //prints scripture with full reference and scripture text
    public override string ToString()
    {
        //call function that shows updated scripture text
        UpdatedScripture();
        return $"{_reference} {_scriptureText}";
    }

    //Takes the text of the scripture and adds each word to the word list
    public void makeListofWords() 
    {
        string[] fullVerse = _scriptureText.Split(' ');
        foreach (string word in fullVerse)
        {
            _words.Add(new Word(word));
        }
    }

    //replaces three randomly chosen words and returns updated scripture text
    private string UpdatedScripture()
    {
        if (wordTotal == 0)
        {
            wordTotal++;
            return _scriptureText;
        }
        for (int i = 0; i < 3; i++)
        {
            if (wordTotal < _words.Count + 1)
            {

                //calls function to pick one word to remove
                int whichWord = RemoveRandomWords();
                //calls function to hide chosen word
                _words[whichWord].HideWord();
                wordTotal++;
            }
        }
        _scriptureText = "";
        foreach (Word word in _words)
        {
            _scriptureText += $"{word.GetWord()} ";
        }
        return _scriptureText;
    }

    //picks the index of one word from the word list and returns it
    private int RemoveRandomWords()
    {
        int selectedWordIndex;
        //runs until a word that has not been already hidden is chosen
        while (true)
        {
            selectedWordIndex = random.Next(0, _words.Count);
            if (!_words[selectedWordIndex].GetIsHidden())
            {
                break;
            }
        }
        return selectedWordIndex;
    }

    //Returns whether the complete scripture is hidden or not
    public bool IsScriptureHidden()
    {
        // if(wordTotal >= _words.Count)
        // {
        //     return true;
        // }
        // return false;
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }
        return true;
    }
}