using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnagramMVC.Models;

namespace WordCounterMVC.Tests
{
  [TestClass]
  public class AnagramTest
  {
    
    [TestMethod]
    public void GetAnagram_Method_ForOne_Word()
    { 
      //Arrange
      string word = "manasa";
      string[] words = new string[] {word};
      Anagram anagram = new Anagram(word, word);

      //Act
      string[] result = anagram.GetAnagrams();

      //Assert
      CollectionAssert.AreEqual(words, result);
    }

    [TestMethod]
    public void AnagramsMethod_ForGet_Words()
    { 
      //Arrange
      string word = "cat";
      string words = "cat atc";
      Anagram word1 = new Anagram(word,words);

      //Act
      string result = word1.GetWords();

      //Assert
      Assert.AreEqual("cat atc", result);
    }

    [TestMethod]
    public void Method_For_GetWord()
    { 
      //Arrange
      string word = "cat";
      Anagram word1 = new Anagram(word,word);

      //Act
      string result = word1.GetWord();

      //Assert
      Assert.AreEqual(word, result);
    }
  }
}
