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
      for (int i = 0; i < array.Length; i++)
      {
         if(array[i] == 'e' || array[i] == 'E')
        {
           array[i] = '3';
        }
        else if(array[i] == 'o' || array[i] == 'O')
        {
          array[i] = '0';
        }
        else if(array[i] == 'I')
        {
          array[i] = '1';
        }
      }
      return array;
    }
  }
}
