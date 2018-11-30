using System;
using System.Linq;
using System.Collections.Generic;

namespace WordCounterMVC.Models
{
  public class WordCounter
  {
    private string _word;
    private string _sentence;

    public WordCounter(string word, string sentence){
      _word = word;
      _sentence = sentence.ToLower();
    }

    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string newWord)
    {
      _word = newWord;
    }

    public string Getsentence()
    {
      return _sentence;
    }

    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }

    public int GetRepeatCounter()
    { 

      int count = 0;
      string[] sentenceWords = _sentence.Split();

      for(int i = 0; i < sentenceWords.Length; i++)
      {
        if(_word == sentenceWords[i])
        {
          count = count + 1;
        }
      }
      
      if(count == 0)
      {
        Console.WriteLine("No Match Found.");
      }
      return count;
    }
  }
}
