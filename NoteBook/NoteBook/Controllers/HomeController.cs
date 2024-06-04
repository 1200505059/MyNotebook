using NoteBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace NoteBook.Controllers
{
    public class HomeController : Controller
    {
        Context db=new Context();
       
        public IActionResult Index()
        {
            var noteCount = db.tblNotlars.Count();
            var passwordCount = db.tblSifrelers.Count();

            // Verileri View'a gönder
            ViewBag.NoteCount = noteCount;
            ViewBag.PasswordCount = passwordCount;

            return View();
        }
       
        public IActionResult Notlar()
        {
            var degerler=db.tblNotlars.ToList();
            return View(degerler);
        }
       
        [HttpGet]
        public IActionResult NotEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NotEkle(TblNotlar not ) 
        {
             db.tblNotlars.Add(not);
            db.SaveChanges();
            return RedirectToAction("Notlar", "Home");


        }
        public IActionResult NotSil(int id)
        {
            var sil=db.tblNotlars.Find(id);
            db.tblNotlars.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Notlar", "Home");
        }
       
        [HttpGet]
        public IActionResult NotGuncelle(int id)
        {
            var deger = db.tblNotlars.Find(id);
            return View(deger);

        }
        [HttpPost]
        public IActionResult NotGuncelle(TblNotlar not)
        {
            var deger=db.tblNotlars.Find(not.NotID);
            deger.NotID = not.NotID;
            deger.NotTitle= not.NotTitle;
            deger.NotText = not.NotText;
            db.SaveChanges();
            return RedirectToAction("Notlar", "Home");


        }

        public IActionResult TumunuOku(int id)
        {
            var deger = db.tblNotlars.Find(id);
            return View(deger);

        }
        /*Şifre işlemleri*/
        
        public IActionResult Sifreler()
        {
            var sifreler=db.tblSifrelers.ToList();
            return View(sifreler);
        }
      
        [HttpGet]
        public IActionResult SifreEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SifreEkle(TblSifreler sifre)
        {
            db.tblSifrelers.Add(sifre);
            db.SaveChanges();
            return RedirectToAction("Sifreler", "Home");


        }
        public IActionResult SifreSil(int id)
        {
            var sil = db.tblSifrelers.Find(id);
            db.tblSifrelers.Remove(sil);
            db.SaveChanges();
            return RedirectToAction("Sifreler", "Home");
        }
        
        [HttpGet]
        public IActionResult SifreGuncelle(int id)
        {
            var deger = db.tblSifrelers.Find(id);
            return View(deger);

        }
        [HttpPost]
        public IActionResult SifreGuncelle(TblSifreler not)
        {
            var deger = db.tblSifrelers.Find(not.SifreId);
            deger.SifreId = not.SifreId;
            deger.SifreTitle = not.SifreTitle;
            deger.SifreText = not.SifreText;
            db.SaveChanges();
            return RedirectToAction("Sifreler", "Home");


        }

        [HttpGet]
        public IActionResult GirisYap()
        {

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(TblAdmin admin)
        {
            var degerler = db.tblAdmins.FirstOrDefault(x => x.AdminUserName == admin.AdminUserName
                              &&
            x.AdminPassword == admin.AdminPassword);
            if (degerler != null)
            {
                var istek = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.AdminUserName),
                };

                return RedirectToAction("GirisYap", "Home");
            }
            return RedirectToAction("Index", "Home");

        }
    
        public IActionResult Admin()
        {
            var degerler = db.tblAdmins.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AdminGuncelle(int id)
        {
            var ag = db.tblAdmins.Find(id);
            return View(ag);
        }
        [HttpPost]
        public ActionResult AdminGuncelle(TblAdmin p)
        {
            var ag = db.tblAdmins.Find(p.AdminID);
            ag.AdminUserName = p.AdminUserName;
            ag.AdminPassword = p.AdminPassword;
            db.tblAdmins.Update(ag);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }

    }
}
