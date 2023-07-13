using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Skill_CodeFirstEntity.Models.siniflar;
namespace Skill_CodeFirstEntity.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context cn = new Context();

        public ActionResult Index()
        {
            var degerler = cn.Yetenklers.ToList();

            
            return View(degerler); 
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(Yetenekler y)
        {
            cn.Yetenklers.Add(y);
            cn.SaveChanges();
            return View();
        }
        public ActionResult YetenekSil(int id)
        {
            var sil = cn.Yetenklers.Find(id);
            cn.Yetenklers.Remove(sil);
            cn.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekGuncelle(int id)
        {
            var guncellle = cn.Yetenklers.Find(id);
           return View("YetenekGuncelle",guncellle);

        }
        [HttpPost]
        public ActionResult YetenekGuncelle(Yetenekler y)
        {
            var guncelle = cn.Yetenklers.Find(y.Id);
            guncelle.Deger = y.Deger;
            guncelle.Aciklama = y.Aciklama;
            cn.SaveChanges();
            return RedirectToAction("Index");



        }
    }
}