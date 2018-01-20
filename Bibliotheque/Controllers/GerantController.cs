using Bibliotheque.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bibliotheque.Controllers
{
    public class GerantController : Controller
    {
        //
        // GET: /Gerant/
         ILecteur ilect = new LecteurRepository();

        public ActionResult Index()
        {
            //RedirectToAction("inscription", "User");
            return PartialView("acceuilGerant");
        }

        public ActionResult Inscription()
        {
            Lecteur l = new Lecteur();
            l.Code = ilect.GenererCode();
            return View(l);       
        }

        [HttpPost]
        public ActionResult Inscription(Lecteur lec)
        {
            //lec.Utilisateur.Pass = "passer";
            //lec.Utilisateur.profil = "lecteur";
            //lec.Utilisateur.Login = lec.Code;
            

            if (!ModelState.IsValid)
            {
                return View(lec);
            }
            
            
            try
            {
                ilect.AddLecteur(lec);
            }
            catch (Exception ex)
            {

                ViewBag.message = "Erreur" + ex.Message;
            }
            return View(lec);
        }
        public ActionResult ListeLecteur()
        {
            return View(ilect.AllLecteur());
        }
    }
}
