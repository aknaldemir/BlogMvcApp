using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Bll.Abstract;
using Blog.Bll.Concrete;

namespace Blog.WebUI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUowManager _uowManager;

        public HomeController()
        {
            _uowManager = new UowManager();
        }

        public ActionResult Index()
        {
            var model = _uowManager.NewsManager.GetNewsWithCategory();
            return View(model);
        }
    }
}