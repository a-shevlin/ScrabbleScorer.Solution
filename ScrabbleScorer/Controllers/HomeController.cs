using Microsoft.AspNetCore.Mvc;
using System;
using ScrabbleScorer.Model;

namespace ScrabbleScorer.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("/score")]
    public ActionResult Score(string word) 
    { 
      Word newWord = new Word();
      newWord.Input = word; 
      newWord.Generate();
      return View(newWord);
    }
  }
}