using BootstrapGridSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapGridSystem.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Proje()
        {
            return View();
        }



        [HttpPost]
        public ActionResult KayitOl(string txtKayitOlAd, string txtKayitOlSoyad, string txtKayitOlTelNo, string txtKayitOlMail, string txtKayitOlKullaniciAdi, string txtKayitOlSifre, string txtKayitOlAdres, string txtKayitOlIl, string txtKayitOlIlce)
        {
            Kullanici kullanici = new Kullanici();


           
            kullanici.Soyad = txtKayitOlSoyad;
            kullanici.TelefonNo = txtKayitOlTelNo;
            kullanici.Email = txtKayitOlMail;
            kullanici.KullaniciAdi = txtKayitOlKullaniciAdi;
            kullanici.Sifre = txtKayitOlSifre;
            kullanici.Adres = txtKayitOlAdres;
            kullanici.Il = txtKayitOlIl;
            kullanici.Ilce = txtKayitOlIlce;

            kullanici.KayitOl();




            return RedirectToAction("Proje","Test");
        }

      
    }
}