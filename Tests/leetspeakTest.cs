using Xunit;
using System;
using System.Collections.Generic;
using LeetSpeakTest;

namespace LeetSpeak.Objects
{
  public class LeetSpeakTest
  {
    [Fact]
    public void Translate_forCharacterSplitIntoArray_splitArray()
    {
      //Arrange
      LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();

      //Act
      char[] array = {'h','h','h','h','h'};
      //Assert
      Assert.Equal(array, testLeetSpeak.Translate("hhhhh"));
    }
    [Fact]
    public void Translate_forCharacterE_replaceWith3()
    {
      LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
      char[] expected = {'h','3','l','l','o'};

      Assert.Equal(expected, testLeetSpeak.Translate("hello"));
    }
  }
}
