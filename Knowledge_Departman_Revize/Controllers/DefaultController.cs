using Knowledge_Departman_Revize.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Knowledge_Departman_Revize.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();

        public IActionResult Index()
        {
            var degerler = context.Birims.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniBirim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniBirim(Birim departman)
        {
            context.Birims.Add(departman);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BirimSil(int id)
        {
            var degerler = context.Birims.Find(id);
            context.Birims.Remove(degerler);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult BirimGetir(int id)
        {
            var degerler = context.Birims.Find(id);
            return View(degerler);
        }


        public IActionResult BirimGuncelle(Birim departman)
        {
            var degerler = context.Birims.Find(departman.BirimID);
            degerler.BirimAd = departman.BirimAd;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BirimDetay(int id)
        {
            var degerler = context.Personels.Where(x => x.BirimID == id).ToList();
            
            
            var brmad = context.Birims.Where(x => x.BirimID == id).Select(y => y.BirimAd).FirstOrDefault();

            ViewBag.brm = brmad;
            return View(degerler);
        }
    }
}