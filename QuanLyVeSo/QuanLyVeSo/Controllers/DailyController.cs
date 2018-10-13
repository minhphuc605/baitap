using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyVeSo.Controllers
{
    public class DailyController : Controller
    {
        // GET: Daily
        public ActionResult Index()
        {
            var dao = new DailyDAO();
            var model = dao.ListAll();
            return View(model);
        }
    }
}