using Microsoft.AspNetCore.Mvc;
using AnagramMVC.Models;

namespace WordCounterMVC.Controllers
{
  public class AnagramController : Controller
  {

    [HttpGet("/anagram")]
    public ActionResult Index() 
    { 
      return View();
    }

    [HttpPost("/anagram/output")]
    public ActionResult Output(string word, string words)
    {
      Anagram myLetterVariable = new Anagram(word,words);
      myLetterVariable.SetWord(word);
      myLetterVariable.SetWords(words);
      return View(myLetterVariable);
    }
  }
}
