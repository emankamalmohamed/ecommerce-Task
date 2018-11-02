using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvceman.Controllers
{
    public class emanController : Controller
    {
        


        public string Index()
        {
            return "Hello my name is eman";
        }
        

       
        public string Welcome()
        {
            return "This is my welcome page";
        }
    }
}