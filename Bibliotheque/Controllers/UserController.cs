using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Bibliotheque.Models;

namespace Bibliotheque.Controllers
{
    public class UserController : Controller
    {
        IUser iuser =new UserRepository();
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View(new DAL.Utilisateur());
        }

        [HttpPost]
        public ActionResult Index(Utilisateur user)
        {
            Utilisateur us = iuser.Logon(user.Login, user.Pass);
            if (us == null)
            {
                ViewBag.message = " Login ou pass incorrect";
                return View();
            }
            if (us.profil.Equals("lecteur"))
            { 
            return PartialView("acceuilLecteur");
            }
            return PartialView("acceuilGerant");
        }
    }
}
