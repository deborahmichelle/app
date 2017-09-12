using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using fine_art.Models;

namespace fine_art.Controllers
{
    public class FineController : Controller
    {
        
        public ActionResult Index()
        {
            List<Admin> ls = new List<Admin>();
            var ad = new Admin();
            ad.ID = 1;
            ad.Name = "Choudhary";
            ad.Email = "choudhary420@gmail.com";
            return View(ls);
        }
	}
}