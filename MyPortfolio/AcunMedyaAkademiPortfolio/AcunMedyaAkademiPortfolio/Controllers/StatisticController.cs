using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbDominicPortfolioEntities1 db = new DbDominicPortfolioEntities1();
        public ActionResult Index()
        {
            ViewBag.CategorySayisi = db.TblCategory.Count();
            ViewBag.ProjeSayisi = db.TblProject.Count();
            return View();
        }
    }
}