using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fine_art.Models;

namespace fine_art.Controllers
{
    public class ArtController : Controller
    {
        List<Student> list = new List<Student>();
        
        public ActionResult Index()
        {
            return View();
        }
	}
}