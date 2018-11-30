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
            Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
        }

        // [TestMethod]
        // public void Create_RedirectsToCorrectAction_Index()
        // {
        //     //Arrange
        //     WordCounterController controller = new WordCounterController();
        //     RedirectToActionResult actionResult = controller.Create("dog","Walk the dog") as RedirectToActionResult;

        //     //Act
        //     string result = actionResult.ActionName;

        //     //Assert
        //     Assert.AreEqual(result, "Index");
        // }
    }
}