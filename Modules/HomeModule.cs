using Nancy;
using System.Collections.Generic;
using System.Diagnostics;


namespace LeetSpeak.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Post["/result"] = _ =>{
        LeetSpeakTranslator newLeet = new LeetSpeakTranslator();
        string result = newLeet.Translate(Request.Form["new-word"]);
        return View["results.cshtml", result];
      };
    }
  }
}
