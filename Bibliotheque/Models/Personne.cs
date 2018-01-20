using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibliotheque.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Tel {get; set;}
    }
}