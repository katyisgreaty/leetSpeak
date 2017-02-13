using Nancy;
using System;
using System.Collections.Generic;
using LeetSpeakApp.Objects;

namespace LeetSpeakApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
        Get["/"] = _ => {
          return View["index.cshtml"];
        };

        Post["/output"] = _ => {
          LeetSpeak leetSpeak = new LeetSpeak();
          leetSpeak.toArray(Request.Form["phrase"]);
          char[] translatedArray = leetSpeak.adjustArray(leetSpeak._charArray);
          string finalWord = string.Join("",translatedArray);
          return View["output.cshtml", finalWord];
        };
      }
    }
  }
