using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RocketNet.Models;

namespace RocketNet.Controllers
{
    public class ItemsController : Controller
    {
        private PokeDBContext db = new PokeDBContext();

        // GET: Items

        public ActionResult List(string type, string search)
        {
            var Types = new List<string> {"Bug", "Dark", "Dragon", "Electric", "Fairy", "Fighting", "Fire", "Flying", 
                "Ghost", "Grass", "Ground", "Ice", "Normal", "Poison", "Psychic", "Rock", "Steel", "Water"};

            ViewBag.type = new SelectList(Types);

            var pokes = from m in db.Pokes
                        select m;
            if (!String.IsNullOrEmpty(search))
            {
                pokes = pokes.Where(n => n.Name.Contains(search));
            }

            if (!String.IsNullOrEmpty(type))
            {
                pokes = pokes.Where(x => x.Type1 == type || x.Type2 == type);
            }


            return View(pokes);
        }
        // GET: Items/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pokemon pokemon = db.Pokes.Find(id);
            if (pokemon == null)
            {
                return HttpNotFound();
            }
            return View(pokemon);
        }

        public ActionResult Purchase(Pokemon pokemon)
        {
            return View(pokemon);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
