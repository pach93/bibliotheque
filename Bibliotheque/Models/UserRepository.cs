using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace Bibliotheque.Models
{
    public class UserRepository : IUser
    {
        private BDContext bd = new BDContext();

        public Utilisateur Logon(string login, string pass)
        {
            return bd.utilisateurs.Where(u => u.Login == login && u.Pass == pass).FirstOrDefault();
        }
    }
}