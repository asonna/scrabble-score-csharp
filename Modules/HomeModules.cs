using Nancy;
using System.Collections.Generic;
using ScrabbleGame.Objects;

namespace ScrabbleGame
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Post["/result"] = _ =>
      {
        Scrabble originalWord = new Scrabble(Request.Form["word"]);
        return View["result.cshtml", originalWord];
      };
    }
  }
}
