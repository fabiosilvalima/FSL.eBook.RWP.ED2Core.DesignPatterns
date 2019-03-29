using Microsoft.AspNetCore.Mvc;
using System;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.SingletonChapter
{
    public sealed class SingletonController : 
        Controller
    {
        public IActionResult Index()
        {
            Log.Instance.LogException(new Exception("test"));

            return Content("Singleton"); 
        }
    }
}