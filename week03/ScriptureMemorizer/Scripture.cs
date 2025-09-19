using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    Random rand = new Random();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // splitting text into list of word objects
        text = text.Trim();

        // split text into array
        string[] textInArray = text.Split(" ");

        // use for loop to first create word object and them assign from array to word list
        for (int i = 0; i < textInArray.Length; i++)
        {
            Word newWord = new Word(textInArray[i]);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        
        // Calculating how many words are hidden
        int hiddenCount = getHiddenCount();

        // creating var to hold the next hidden number index
        int newHidden;

        // if there are more unhidden words than numbers to hide at a time
        if ((_words.Count() - hiddenCount) >= numberToHide)
        {
            Console.WriteLine("In if statement");
            for (int i = 0; i < numberToHide; i++)
            {
                // choosing the next number
                newHidden = rand.Next(_words.Count());

                // while the choosen word is hidden (basically, making sure that the number chosen is not a word that is already hidden)
                while (_words[newHidden].IsHidden() == true)
                {
                    Console.WriteLine("searching for new word");
                    newHidden = rand.Next(_words.Count());
                }
                Console.WriteLine("Found word!");

                // hidding word
                _words[newHidden].Hide();
            }
        }
        // else, basically, there are less shown numbers than the requested amount to be hidden
        else
        {
            // get amound of words hidden
            int hiddenAmount = getHiddenCount();

            // subtract amound hidden from the numberToHide var
            int unhiddenWordCount = _words.Count() - hiddenAmount;

            Console.WriteLine($"In else statement, amount left: {unhiddenWordCount}");

            // hide results amount of words
            for (int i = 0; i < unhiddenWordCount; i++)
            {
                newHidden = rand.Next(_words.Count());

                // while the choosen word is hidden (basically, making sure that the number chosen is not a word that is already hidden)
                while (_words[newHidden].IsHidden() == true)
                {
                    Console.WriteLine("finding word to hide");
                    newHidden = rand.Next(_words.Count());
                }
                Console.WriteLine("Found word!");

                // hidding word
                _words[newHidden].Hide();
            }

        }
    }

    private int getHiddenCount()
    {
        int hiddenCount = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenCount++;
            }
        }

        return hiddenCount;
    }

    public string GetDisplayText()
    {
        // creating string to return
        string fullScripture = "";

        // getting display text from reference
        fullScripture += _reference.GetDisplayText() + " ";


        // getting display text from each word using foreach loop
        foreach (Word word in _words)
        {
            fullScripture += word.GetDisplayText() + " ";
        }

        return fullScripture;

    }

    public bool IsCompletelyHidden()
    {
        // creating bool to return
        bool allHidden = false;
        int hiddenCounter = getHiddenCount();

        if (hiddenCounter == _words.Count())
        {
            allHidden = true;
        }

        return allHidden;
    }
}