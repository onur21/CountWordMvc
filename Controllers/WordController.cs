using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WordsinMobyDick.Controllers
{
    public class WordController : Controller
    {
        //
        // GET: /ProductList/
        public ActionResult Index()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.RetrunListOfProducts();
            return View(data.ToList());  
            return View();
        }
	}
}