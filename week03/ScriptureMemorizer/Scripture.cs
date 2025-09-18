public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        foreach (string pickedText in text.Split(' '))
        {
            _words.Add(new Word(pickedText));
        }

        
    }
    public void HideRandomWords(int numberToHide)
    {
        int hiddenCounter = 0;
        while (hiddenCounter < numberToHide && !IsCompletelyHidden())
        {
            Random random = new Random();
            int indexPositionToHide = random.Next(_words.Count);
            if (!_words[indexPositionToHide].IsHidden())
            {
                _words[indexPositionToHide].Hide();
                hiddenCounter++;
            }
        }
        
    }
    public string GetDisplayText()
    {
        string displayedText = _reference.GetDisplayText() + " ";
        foreach (Word selectedWord in _words)
        {
            displayedText += selectedWord.GetDisplayText() + " ";
        }
        return displayedText.Trim();
        
    }
    public bool IsCompletelyHidden()
    {
       return _words.All(selectedWord => selectedWord.IsHidden());
        
    }
}