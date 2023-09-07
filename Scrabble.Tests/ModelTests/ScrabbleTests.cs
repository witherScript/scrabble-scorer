using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordScoreTests
  {
    [TestMethod]
    public void ScrabbleConstructor_CreatesInstanceOfScrabble_Scrabble()
      {
        WordScore newScrabble = new WordScore("word");
        Assert.AreEqual(typeof(WordScore), newScrabble.GetType());
      }
      
    [TestMethod]
    public void ScrabbleInput_ReturnsScrabbleInput_String()
    {
      string wordInput = "statistics";
      WordScore newScrabble = new WordScore(wordInput);
      Assert.AreEqual(wordInput, newScrabble.Input);
    }
    [TestMethod]
    public void GetArray_ReturnsCharArray_CharArray()
    {
      string wordInput = "star";
      WordScore newScrabble = new WordScore(wordInput);
      char[] wordArr = newScrabble.GetArray(newScrabble.Input);
      Assert.AreEqual(typeof(char[]), wordArr.GetType()); 
    }
    [TestMethod]
    public void GetScore_ShouldCalcScoreFromWord_Int()
    {
      WordScore newScrabble = new WordScore("star");
      int expected =4;
      Assert.AreEqual(expected, newScrabble.CalcScore());
    }
  }
}