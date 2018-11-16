using System;
using System.Linq;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public static class WordCounter
  {
    public static int RepeatCounter(string word, string sentence)
    { 
      int count = 0;
      string[] sentenceWords = sentence.Split();

      for(int i = 0; i < sentenceWords.Length; i++)
      {
        if(word == sentenceWords[i])
        {
          count = count + 1;
        }
      }
      return count;
    }

    public static void Main()
    {
      Console.WriteLine("Please enter a Word that you want to count in a sentence:");
      string userInputword = Console.ReadLine();
      Console.WriteLine("Please enter a sentence:");
      string userInputSentence = Console.ReadLine();
      Console.WriteLine("The word " + "'" + userInputword + "'" + " appered " + RepeatCounter(userInputword.ToUpper(),userInputSentence.ToUpper()) + " times.");
    }
  }
}
