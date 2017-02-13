using System;
using System.Collections.Generic;

namespace LeetSpeakApp.Objects
{
  public class LeetSpeak
  {
    public string _inputWord;
    public string _result;
    public char[] _charArray;

    // public LeetSpeak()
    // {
    //
    // }

  public char[] toArray(string inputWord)
  {
    _charArray = inputWord.ToCharArray();
    return _charArray;
  }

  public string toString(char[] charArray)
  {
    _result = string.Join("",charArray);
    return _result;
  }

  }
}
