using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2001202045_VuNgoDat_Buoi6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int? page)
        {
            var list = new Core.Services.DAL().GetProducts();
            return View(list.ToPagedList(page ?? 1, 10));
        }
        public ActionResult ShowBrands()
        {
            return View(new Core.Services.DAL().GetBrandForProds());
        }
        public ActionResult SearchProduct()
        {
            return View(new Core.Services.DAL().GetProducts());
        }
        [HttpPost]
        public ActionResult SearchProduct(string txtSearch)
        {
            return View(new Core.Services.DAL().GetProducts(txtSearch));
        }
    }
}