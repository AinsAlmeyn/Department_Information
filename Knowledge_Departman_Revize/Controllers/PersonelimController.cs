using Knowledge_Departman_Revize.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Knowledge_Departman_Revize.Controllers
{
    public class PersonelimController : Controller
    {
        Context context = new();

        [Authorize]
        public IActionResult Index()
        {
            var degerler = context.Personels.Include(x=>x.Birim).ToList();
            return View(degerler);
        }

        public IActionResult YeniPersonel()
        {
            List<SelectListItem> degerler = (from x in context.Birims.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.BirimAd,
                                                 Value = x.BirimID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }

        [HttpPost]
        public IActionResult YeniPersonel(Personel p)
        {
            var per = context.Birims.Where(x => x.BirimID == p.Birim.BirimID).FirstOrDefault();
            p.Birim = per;
            context.Personels.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}