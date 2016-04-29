using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Elev
    {
        public Elev()
        {
            Id = new Random().Next(1, 5000);

        }
        public int Id { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public int Personnummer { get; set; }
        public virtual Klass ElevKlass { get; set; }
        public int KlassId { get; set; }
    }
  
}
