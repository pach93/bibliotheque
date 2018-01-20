using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.Models
{
   public interface ILecteur
    {
       void AddLecteur(Lecteur lec);
       string GenererCode();
       List<Lecteur> AllLecteur();
    }
}
