using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Lärare
    {

        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string  Efternamn { get; set; }
        public virtual Kurs LärarKurser { get; set; }
        public int KursId { get; set; }
    }
}
