using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterMVC.Models;

namespace WordCounterMVC.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index() 
    { 
      return View();
    }

    [HttpPost("/wordcounter/output")]
    public ActionResult Output(string word, string sentence)
    {
      WordCounter myCountVariable = new WordCounter(word,sentence);
      myCountVariable.SetWord(word);
      myCountVariable.SetSentence(sentence);
      return View(myCountVariable);
    }
  }
}
