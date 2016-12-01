using Xunit;
using System.Collections.Generic;
using System;

namespace ScrabbleGame.Objects
{
  public class ScrabbleTest
  {
    [Fact]
    public void AddScore_ForSingleLetterReturnValueScore_1()
    {
      Scrabble originalWord = new Scrabble("");
      Assert.Equal(5, originalWord.AddScore());
    }
  }
}
