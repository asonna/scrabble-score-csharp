using System.Collections.Generic;
using System;

namespace ScrabbleGame.Objects
{
  public class Scrabble
  {
    private string _originalWord;
    private int _userScore;

    public Scrabble(string originalWord)
    {
      _originalWord = originalWord;
    }

    public int AddScore()
    {
      int _userScore = 0;
      char[] letters = _originalWord.ToCharArray();
      // Console.WriteLine(letters[0]);
      for(int i = 0; i < letters.Length; i++)
      {
        if (letters[i] == 'A' || letters[i] == 'E' || letters[i] == 'I' || letters[i] == 'O' || letters[i] == 'U' || letters[i] == 'L' || letters[i] == 'N' || letters[i] == 'R' || letters[i] == 'S' || letters[i] == 'T')
        {
          _userScore += 1;
        }
        else if (letters[i] == 'D' || letters[i] == 'G')
        {
          _userScore += 2;
        }
        else if (letters[i] == 'B' || letters[i] == 'C' || letters[i] == 'M' || letters[i] == 'P')
        {
          _userScore += 3;
        }
        else if (letters[i] == 'F' || letters[i] == 'H' || letters[i] == 'V' || letters[i] == 'W' || letters[i] == 'Y')
        {
          _userScore += 4;
        }
        else if (letters[i] == 'K')
        {
          _userScore += 5;
        }
        else if (letters[i] == 'J' || letters[i] == 'X')
        {
          _userScore += 8;
        }
        else if (letters[i] == 'Q' || letters[i] == 'Z')
        {
          _userScore += 10;
        }
      }
      return _userScore;
    }
  }
}
