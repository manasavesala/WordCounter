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
      WordCounter myCountVariableModel = new WordCounter(word,sentence);
      myCountVariableModel.SetWord(word);
      myCountVariableModel.SetSentence(sentence);
      return View(myCountVariableModel);
    }
  }
}
