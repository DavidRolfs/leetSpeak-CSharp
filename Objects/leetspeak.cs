using Nancy;
using System.Collections.Generic;
using System.Diagnostics;
using LeetSpeak.Objects;

namespace LeetSpeakTest
{
  public class LeetSpeakTranslator
  {
    private static List<char> _letters = new List<char>{};

    public char[] Translate(string userInput)
    {
      char[] array = userInput.ToCharArray();
      //string result = string.Join("", array);
      return array;
    }
  }
}
