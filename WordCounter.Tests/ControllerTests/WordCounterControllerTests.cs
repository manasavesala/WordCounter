using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterMVC.Controllers;
using WordCounterMVC.Models;
using System;

namespace WordCounterMVC.Tests
{
    [TestClass]
    public class WordCounterControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            IActionResult view = controller.Output("cat","my cat");

            //Assert
            Assert.IsInstanceOfType(view, typeof(ViewResult));
            var viewResult = view as ViewResult;

            Assert.IsInstanceOfType(viewResult.Model, typeof(WordCounter));
            var model = viewResult.Model as WordCounter;
            
            Assert.AreEqual(model.GetWord(), "cat");
            Assert.AreEqual(model.GetSentence(), "my cat");

        }

    }
}