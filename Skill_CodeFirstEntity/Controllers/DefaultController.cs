using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skill_CodeFirstEntity.Models.siniflar;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace Skill_CodeFirstEntity.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Models.siniflar.Context cn = new Models.siniflar.Context();
            var deger = cn.Yetenklers.ToList();
            return View(deger);
        }
    }
}