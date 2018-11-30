using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterMVC.Controllers;
using AnagramMVC.Models;
using System;

namespace AnagramMVC.Tests
{
    [TestClass]
    public class AnagramControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            //Arrange
            AnagramController controller = new AnagramController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            //Arrange
            AnagramController controller = new AnagramController();

            //Act
            IActionResult view = controller.Output("cat","atc tac");

            //Assert
            Assert.IsInstanceOfType(view, typeof(ViewResult));
            var viewResult = view as ViewResult;

            Assert.IsInstanceOfType(viewResult.Model, typeof(Anagram));
            var model = viewResult.Model as Anagram;
            
            Assert.AreEqual(model.GetWord(), "cat");
            Assert.AreEqual(model.GetWords(), "atc tac");

        }

    }
}