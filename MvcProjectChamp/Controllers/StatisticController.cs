using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectChamp.Controllers
{
    public class StatisticController : Controller
    {
        Context db = new Context();


        // GET: Statistic
        public ActionResult Statistics()
        {
            // Toplam kategori sayısı
            var cevap1 = db.Categories.Count().ToString();
            ViewBag.dgr1 = cevap1;

            // Başlık tablosunda "yazılım" kategorisine ait başlık sayısı 
            var cevap2 = db.Headings.Where(x => x.Category.CategoryName == "yazılım").Count().ToString();
            ViewBag.dgr2 = cevap2;

            // Yazar adında 'a' harfi geçen yazar sayısı
            var cevap3 = db.Writers.Where(x => x.WriterName.Contains("a")).Count().ToString();
            ViewBag.dgr3 = cevap3;

            // En fazla başlığa sahip kategori adı

            //var cevap4 = db.Headings.Max(x => x.CategoryId).ToString();
            //var cevap4 = db.Headings.GroupBy(x => x.CategoryId).Count().ToString();
            //ViewBag.dgr4 = cevap4;

            foreach (var item in db.Headings.GroupBy(x => x.CategoryId).Select(group => new { Metric = group.Key, Count = group.Count()}).OrderBy(x => x.Metric))
            {
                ViewBag.dgr4 = item.Count; //YAPAMADIM...

            }

            //var result=db.Headings.GroupBy(x => x.CategoryId).Where(w => w.Count() > 1).Select(s => new { s.FirstOrDefault().Category.CategoryName }).Distinct().Take(1); 

            //    ViewBag.dgr4 = result;


            //Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark

            var cevap5 = (db.Categories.Where(x => x.CategoryStatus == true).Count() - db.Categories.Where(x => x.CategoryStatus == false).Count()).ToString();
            ViewBag.dgr5 = cevap5;

            return View();
        }
    }
}