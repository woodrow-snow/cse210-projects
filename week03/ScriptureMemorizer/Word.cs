class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
        _text = "";
        _isHidden = false;
    }

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }   

    public void Show()
    {
        Console.Write(GetDisplayText());
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (IsHidden())
        {
            string returnString = "";
            // if the string is hidden, the return a string that contains only underscore equal to the length of the string
            for (int i = 0; i < _text.Length; i++)
            {
                returnString += '_';
            }

            return returnString;
        }
        else
        {
            return _text;
        }
    }
}