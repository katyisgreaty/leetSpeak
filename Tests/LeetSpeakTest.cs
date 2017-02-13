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
      string resultTest = "h3ll01";
      string inputWord = "helloI";
      // char[] testArray;
      testLeetSpeak.toArray(inputWord);
      char[] translatedArray = testLeetSpeak.adjustArray(testLeetSpeak._charArray);

      testLeetSpeak.toString(translatedArray);
      Assert.Equal(translatedArray, resultTest);


      //Act
      //Assert
      //Arrange
      // PingPong testPingPong = new PingPong(15);
      // List<string> expected = new List<string>{"1","2","ping","4","pong","ping", "7", "8", "ping","pong", "11","ping", "13", "14", "pingpong"};
      // //Act
      // List<string> output = testPingPong.PrintArray();
      // //Assert
      // Assert.Equal(expected, output);
    }
  }
}
