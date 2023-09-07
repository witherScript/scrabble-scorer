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
    public Dictionary<char, int> CharScore = new Dictionary<char, int>()
    {
      {'a', 1},
      {'b', 3},
      {'c', 3},
      {'d', 2},
      {'e', 1},
      {'f', 4},
      {'g', 2},
      {'h', 4},
      {'i', 1},
      {'j', 8},
      {'k', 5},
      {'l', 1},
      {'m', 3},
      {'n', 1},
      {'o', 1},
      {'p', 3},
      {'q', 10},
      {'r', 1},
      {'s', 1},
      {'t', 1},
      {'u', 1},
      {'v', 4},
      {'w', 4},
      {'x', 8},
      {'y', 4},
      {'z', 10}
      };


      public int CalcScore()
      {
        char[] arr = this.GetArray(this.Input);
        int score =0;
        int toSum = 0;
        foreach(char letter in arr )
        {
          char lowerLetter = char.ToLower(letter);
          toSum = CharScore[Char.ToLower(lowerLetter)];
          score+=toSum; 
        }
        return score;

      }
  }
}