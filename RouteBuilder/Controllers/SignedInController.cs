using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class SignedInController : Controller
    {
        // 
        // GET: /SignedIn/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /SignedIn/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
    
}