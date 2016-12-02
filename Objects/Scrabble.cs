using System.Collections.Generic;
using System;

namespace ScrabbleGame.Objects
{
  public class Scrabble
  {
    private string _originalWord;
    private int _userScore;
    private Dictionary<list<string>, int> myDictionary = new Dictionary<list<string>, int>();

    public Scrabble(string originalWord)
    {
      _originalWord = originalWord;
    }

    public int AddScore()
    {
      int _userScore = 0;
      myDictionary =
      {
        {{"A","E","I","O","U",""L"","N","T"}, 1},
        {{"D","G"}, 2},
        {{"B","C","M","P"}, 3},
        {{"F","H","V","W","Y"}, 4},
        {{"K"}, 5},
        {{"J","X"}, 8},
        {{"Q","Z"}, 10},
        {{" ", ",", ".", "-", "/", "'", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}, 0}
      }
      string upperWord = _originalWord.ToUpper();

      char[] letters = upperWord.ToCharArray();   dolphin
      // Console.WriteLine(letters[0]);
      for(int i = 0; i < letters.Length; i++)
      {
        foreach (string element in Dictionary<list<string>, int> myDictionary)
        {
          if (letters[i] == element)
          {
            _userScore += element.value
          }
        }
      }
      return _userScore;
    }
  }
}
