using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterMVC.Models;

namespace WordCounterMVC.Controllers
{
  public class WordController : Controller
  {

    [HttpGet("/wordcounter")]
    public ActionResult Index() 
    { 
      return View();
    }

    [HttpPost("/wordcounter/output")]
    public ActionResult Output(string word, string sentence)
    {
      WordCounter myCountVariable = new WordCounter();
      myCountVariable.SetWord(word);
      myCountVariable.SetSentence(sentence);
      return View(myCountVariable);
    }
  }
}
