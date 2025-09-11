public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        foreach (string pickedText in text.Split(' '))
        {
            _words.Add(new Word(pickedText));
        }

        //foreach (string wordText in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
       // {
          //  _words.Add(new Word(wordText));
        //}
    }
    public void HideRandomWords(int numberToHide)
    {
        int hiddenCounter = 0;
        while (hiddenCounter < numberToHide && !IsCompletelyHidden())
        {
            int indexPositionToHide = _random.Next(_words.Count);
            if (!_words[indexPositionToHide].IsHidden())
            {
                _words[indexPositionToHide].Hide();
                hiddenCounter++;
            }
        }
        //List<Word> unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();
        //int wordsToHideCount = Math.Min(numberToHide, unhiddenWords.Count);

        //for (int i = 0; i < wordsToHideCount; i++)
       // {
            //int indexToHide = _random.Next(unhiddenWords.Count);
            //unhiddenWords[indexToHide].Hide();
           // unhiddenWords.RemoveAt(indexToHide);
        //}
    }
    public string GetDisplayText()
    {
        string displayedText = _reference.GetDisplayText() + " ";
        foreach (Word selectedWord in _words)
        {
            displayedText += selectedWord.GetDisplayText() + " ";
        }
        return displayedText.Trim();
        //string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        //return $"{_reference.GetDisplayText()} {scriptureText}";
    }
    public bool IsCompletelyHidden()
    {
       return _words.All(selectedWord => selectedWord.IsHidden());
        //return _words.All(w => w.IsHidden());
    }
}