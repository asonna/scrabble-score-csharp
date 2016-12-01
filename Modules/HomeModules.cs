using Nancy; //tells the module to use Nancy;
using System.Collections.Generic; //tells the module to use the generic c# commands and methods
using ScrabbleGame.Objects; //tells the module to use the namespace from Scrabble.cs

namespace Scrabble
{
  {
    public class HomeModule : NancyModule
    {
      public HomeModule()
      {
        Get["/"] = _ =>
        {
          return View[index.cshtml];
        };
      }
    }
  }
}
