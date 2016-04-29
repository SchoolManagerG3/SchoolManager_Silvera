using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Kurs
    {
        public Kurs()
        {
            Id = new Random().Next(1, 51);
        }

        public int Id { get; set; }
        public string Namn { get; set; }
        public virtual Lärare kursLärare { get; set; }
        public int LärarId { get; set; }
        public DateTime DatumStart { get; set; }
        public DateTime DatumSlut { get; set; }
    }
}
