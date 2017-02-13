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

  public char[] adjustArray(char[] array)
  {
    for (int i = 0; i < array.Length; i ++)
    {
      if ((array[i].Equals('e')) || (array[i].Equals('E')))
      {
        array[i] = '3';
      } else if ((array[i].Equals('o')) || (array[i].Equals('O')))
      {
        array[i] = '0';
      }
    }
    return array;

  }

  public string toString(char[] charArray)
  {
    _result = string.Join("",charArray);
    return _result;
  }

  }
}
