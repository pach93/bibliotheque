using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Bibliotheque.Models
{
    public interface IUser
    {
         Utilisateur Logon(string login, string pass);
    }
}
