using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMC.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

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