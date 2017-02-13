using Xunit;
using System.Collections.Generic;
using LeetSpeakApp.Objects;
using LeetSpeakApp;

namespace LeetSpeakApp.Test
{
  public class LeetSpeakTest
  {
    [Fact]
    public void IsLeet_true()
    {
      //Arrange
      LeetSpeak testLeetSpeak = new LeetSpeak();
      string resultTest = "shz3ll01";
      string inputWord = "shselloI";
      // char[] testArray;
      testLeetSpeak.toArray(inputWord);
      char[] translatedArray = testLeetSpeak.adjustArray(testLeetSpeak._charArray);

      testLeetSpeak.toString(translatedArray);
      Assert.Equal(translatedArray, resultTest);
      
    }
  }
}
