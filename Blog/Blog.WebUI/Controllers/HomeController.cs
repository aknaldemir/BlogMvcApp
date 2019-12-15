using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Bll.Abstract;
using Blog.Bll.Concrete;

namespace Blog.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUowManager _uowManager;
        public HomeController()
        {
            _uowManager =new UowManager();
        }
        // GET: Home
        public ActionResult Index()
        {
            var model = _uowManager.NewsManager.GetAll();
            return View(model);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var model = _uowManager.NewsManager.GetById(id);
            return View(model);
        }
       
    }
}
