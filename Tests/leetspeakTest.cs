using Xunit;
using System;
using System.Collections.Generic;
using LeetSpeakTest;

namespace LeetSpeak.Objects
{
  public class LeetSpeakTest
  {
    [Fact]
    public void Translate_forCharacterE_3()
    {
      //Arrange
      LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();

      //Act
      char[] array = {'h','e','l','l','o'};
      //Assert
      Assert.Equal(array, testLeetSpeak.Translate("hello"));

    }
  }
}
