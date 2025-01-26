using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        DbDominicPortfolioEntities1 db = new DbDominicPortfolioEntities1 ();
        public ActionResult FeatureList()
        {
            var values = db.TblFeature.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateFeature(TblFeature p)
        {
            db.TblFeature.Add(p);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        public ActionResult DeleteFeature(int ID)
        {
            var values = db.TblFeature.Find(ID);
            db.TblFeature.Remove(values);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}