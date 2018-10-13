using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model;
using Model.EntityFramework;


namespace QuanLyVeSo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int page = 1, int pageSize = 3)
        {
            var dao = new LOAIVESODAO(); 
            var model = dao.ListAll();
            
            return View(model);
        }

        public ActionResult Insert()
        {

            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

    }
}