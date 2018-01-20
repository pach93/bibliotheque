using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibliotheque.Models
{
    public class LecteurRepository : ILecteur
    {
        private BDContext bd = new BDContext();

        public void AddLecteur(DAL.Lecteur lec)
        {
            try
            {
                bd.lecteurs.Add(lec);
                bd.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
        }


        public string GenererCode()
        {

            Int32 max = bd.lecteurs.Max(l => l.UtilisateurId);
            if (max == null)
                return "L000001";
            return "L" + "000000".Substring(0, 6 - (max + 1).ToString().Length) + (max + 1).ToString();
        }


        public List<Lecteur> AllLecteur()
        {
            return bd.lecteurs.ToList();
        }
    }
}