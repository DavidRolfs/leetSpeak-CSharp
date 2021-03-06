using Xunit;
using System;
using System.Collections.Generic;
using LeetSpeak.Objects;

namespace LeetSpeakTest
{
  public class LeetSpeakTest
  {
    // [Fact]
    // public void Translate_forCharacterSplitIntoArray_splitArray()
    // {
    //   //Arrange
    //   LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
    //
    //   //Act
    //   char[] array = {'h','h','h','h','h'};
    //   //Assert
    //   Assert.Equal(array, testLeetSpeak.Translate("hhhhh"));
    // }
    // [Fact]
    // public void Translate_forCharacterE_replaceWith3()
    // {
    //   LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
    //   char[] expected = {'3', '3'};
    //
    //   Assert.Equal(expected, testLeetSpeak.Translate("eE"));
    // }
    // [Fact]
    // public void Translate_forCharacterO_replaceWith0()
    // {
    //   LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
    //   char[] expected = {'0', '0'};
    //
    //   Assert.Equal(expected, testLeetSpeak.Translate("oO"));
    // }
    // [Fact]
    // public void Translate_forCharacterI_replacewith1()
    // {
    //   LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
    //   char[] expected = {'1'};
    //
    //   Assert.Equal(expected, testLeetSpeak.Translate("I"));
    // }
    // [Fact]
    // public void Translate_forCharacterT_replacewith7()
    // {
    //   LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
    //   char[] expected = {'7', '7'};
    //
    //   Assert.Equal(expected, testLeetSpeak.Translate("tT"));
    // }
    // [Fact]
    // public void Translate_forAllCharactersToBeReplaced_returnReplacement()
    // {
    //   LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
    //   char[] expected = {'3', '0', '1', '7'};
    //
    //   Assert.Equal(expected, testLeetSpeak.Translate("eoIt"));
    // }
    [Fact]
    public void Translate_forAllCharactersToBeReplaced_returnReplacement()
    {
      LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();

      Assert.Equal("3017", testLeetSpeak.Translate("eoIt"));
    }
  }
}
