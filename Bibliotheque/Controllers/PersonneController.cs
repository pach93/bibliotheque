using Bibliotheque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bibliotheque.Controllers
{
    public class PersonneController : Controller
    {
        //
        // GET: /Personne/

        public ActionResult Index()
        {
            DAL.BDContext Db = new DAL.BDContext();
            Db.utilisateurs.ToList();
            return View(new Personne ());
        }

    [HttpPost]
        public ActionResult Index(Personne p)
        {
            return View(p);
        }

    }
}
