using Demo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListTopTenWeb.Controllers
{
    public class ProductListController : Controller
    {
        // GET: ProductList
        public ActionResult Index()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.RetrunListOfProducts().Take(10);
            return View(data.ToList());
            

        }
    }
}