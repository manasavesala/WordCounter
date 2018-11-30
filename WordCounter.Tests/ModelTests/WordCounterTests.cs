using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterMVC.Models;

namespace WordCounterMVC.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    
    [TestMethod]
    public void RepeatCounterMethod_ForOne_Word()
    { 
      //Arrange
      string word = "manasa";
      WordCounter word1 = new WordCounter(word,word);

      //Act
      int result = word1.GetRepeatCounter();

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetRepeatCounterMethod_ForTwo_Words()
    { 
      //Arrange
      string word = "cat";
      string sentence = "I am walking my cat to the cathedral.I love my cat .";
      WordCounter word1 = new WordCounter(word,sentence);

      //Act
      int result = word1.GetRepeatCounter();

      //Assert
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetWord()
    { 
      //Arrange
      string word = "cat";
      WordCounter word1 = new WordCounter(word,word);

      //Act
      string result = word1.GetWord();

      //Assert
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void GetRepeatCounterMethod_ForFour_Words()
    { 
      //Arrange
      string word = "the";
      string sentence = "the The THe thE .";
      WordCounter word1 = new WordCounter(word,sentence);

      //Act
      int result = word1.GetRepeatCounter();

      //Assert
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void GetRepeatCounterMethod_ForNoSentence()
    { 
      //Arrange
      string word = "the";
      string sentence = "";
      WordCounter word1 = new WordCounter(word,sentence);

      //Act
      int result = word1.GetRepeatCounter();

      //Assert
      Assert.AreEqual(0, result);
    }
  }
}
