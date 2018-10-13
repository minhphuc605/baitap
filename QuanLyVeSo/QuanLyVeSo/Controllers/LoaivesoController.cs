using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyVeSo.Controllers
{
    public class LoaivesoController : Controller
    {
        // GET: Loaiveso
        public ActionResult Index()
        {
            var dao = new LOAIVESODAO();
            var model = dao.ListAll();
            return View(model);
        }
    }
}