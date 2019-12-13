using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using konyvaruhaz.Models;

namespace konyvaruhaz.Controllers
{
    public class KonyvekController : Controller
    {
        // GET: Konyvek
        readonly ApplicationDbContext _context;
        public KonyvekController() => _context = new ApplicationDbContext();
        [Authorize(Roles = RoleNevek.Admin)]
        public ActionResult Uj()
        {
            var vm = new KonyvFormViewModel()
            {
                Konyv = new Konyv()
            };
            return View("Felvetel", vm);
        }
        [Authorize(Roles = RoleNevek.Admin)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Mentes(Konyv konyv)
        {
            if (!ModelState.IsValid)
            {
                var vm = new KonyvFormViewModel
                {
                    Konyv = konyv

                };

                return View("Felvetel", vm);
            }

            if (konyv.Id == 0)
            {
                _context.konyv.Add(konyv);

            }
            else
            {
                var letezoUgyfel =
                    _context.konyv.Single(k => k.Id == konyv.Id);


                letezoUgyfel.Cim = konyv.Cim;
                letezoUgyfel.Szerzo = konyv.Szerzo;
                letezoUgyfel.Kategoria = konyv.Kategoria;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Konyvfelvetel");
        }

        public ActionResult Index()
        {
            var konyv = _context.Konyv.ToList();
            return View(konyv);
        }
    }
    }
