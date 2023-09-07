using System.Collections.Generic;
using System;


namespace Scrabble.Models
{
  public class WordScore
  {
    public string Input {get; set;}
    
    public WordScore(string word)
    {
      Input = word;
    }

    public char[] GetArray(string word)
    {
      char[] charArray = word.ToCharArray();
      return charArray;
    }
  }
}