using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMC.Data;
using TMC.Shared;

namespace TMC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string permalink)
        {
         /*   var blogDAC = new BlogDAC();
            List<BlogDTO> blogs = new List<BlogDTO>();
            blogs = blogDAC.ReadAllBlogs();
         */   
            return View();
        }
    }
}