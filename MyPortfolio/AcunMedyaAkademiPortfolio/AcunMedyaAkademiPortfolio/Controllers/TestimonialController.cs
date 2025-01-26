using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        DbDominicPortfolioEntities1 db = new DbDominicPortfolioEntities1 ();
        public ActionResult TestimonialList()
        {
            var values = db.TblTestimonial.Where(x => x.Status == true).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial p)
        {
            p.Status = true;
            db.TblTestimonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        public ActionResult DeleteTestimonial(int ID)
        {
            var testimonial = db.TblTestimonial.Find(ID);
            if (testimonial != null)
            {
                testimonial.Status = false;
                db.SaveChanges();
            }
            return RedirectToAction("TestimonialList");
        }
    }
}