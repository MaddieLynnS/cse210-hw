using System.IO;

class Word
{
    private string _word;
    private bool _isHidden;

    //Constructor to make a word object
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    //string word getter and setter
    public string GetWord()
    {
        return _word;
    }
    private void SetWord(string newWord)
    {
        _word = newWord;
    }

    //bool isHidden getter
    public bool GetIsHidden()
    {
        return _isHidden;
    }

    //Replaces the string word of a Word object with underscores
    public void HideWord()
    {
        _isHidden = true;
        string hiddenWord = "";
        for (int i = 0; i < _word.Length; i++)
        {
            hiddenWord += "_";
        }
        if(_word.Contains(";"))
        {
            hiddenWord += ";";
        }
        else if (_word.Contains(","))
        {
            hiddenWord += ",";
        }
        else if (_word.Contains("."))
        {
            hiddenWord += ".";
        }
        SetWord(hiddenWord);
    }
}