using Nancy;
using System.Collections.Generic;
using System.Diagnostics;
using LeetSpeakTest;

namespace LeetSpeak.Objects
{
  public class LeetSpeakTranslator
  {
    private static List<char> _letters = new List<char>{};

    public string Translate(string userInput)
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
        else if(array[i] == 't' || array[i] == 'T')
        {
          array[i] = '7';
        }
        _letters.Add(array[i]);
      }
      string result = string.Join("", _letters.ToArray());
      return result;
    }
    public static void DeleteAll()
    {
      _letters.Clear();
    }
  }
}
