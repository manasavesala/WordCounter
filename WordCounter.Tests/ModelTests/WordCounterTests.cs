using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    
    [TestMethod]
    public void RepeatCounterMethod_ForOne_Word()
    { 
      //Arrange
      string word = "manasa";

      //Act
      int result = WordCounter.Models.WordCounter.GetRepeatCounter(word,word);

      //Assert
      Assert.AreEqual(result, WordCounter.Models.WordCounter.GetRepeatCounter(word,word));
    }

    [TestMethod]
    public void GetRepeatCounterMethod_ForTwo_Words()
    { 
      //Arrange
      string word = "cat";
      string sentence = "I am walking my cat to the cathedral.I love my cat .";

      //Act
      int result = WordCounter.Models.WordCounter.GetRepeatCounter(word,sentence);

      //Assert
      Assert.AreEqual(result, WordCounter.Models.WordCounter.GetRepeatCounter(word,sentence));
    }

    [TestMethod]
    public void GetRepeatCounterMethod_ForOne_capitalletter()
    { 
      //Arrange
      string word = "cat";
      string sentence = "I am walking my cat to the cathedral.I love my CAT .";

      //Act
      int result = WordCounter.Models.WordCounter.GetRepeatCounter(word,sentence);

      //Assert
      Assert.AreEqual(result, WordCounter.Models.WordCounter.GetRepeatCounter(word,sentence));
    }

    [TestMethod]
    public void GetRepeatCounterMethod_ForFour_Words()
    { 
      //Arrange
      string word = "the";
      string sentence = "the The THe thE .";

      //Act
      int result = WordCounter.Models.WordCounter.GetRepeatCounter(word,sentence);

      //Assert
      Assert.AreEqual(result, WordCounter.Models.WordCounter.GetRepeatCounter(word,sentence));
    }

    [TestMethod]
    public void GetRepeatCounterMethod_ForNoSentence()
    { 
      //Arrange
      string word = "the";
      string sentence = "";

      //Act
      int result = WordCounter.Models.WordCounter.GetRepeatCounter(word,sentence);

      //Assert
      Assert.AreEqual(result, WordCounter.Models.WordCounter.GetRepeatCounter(word,sentence));
    }
  }
}
