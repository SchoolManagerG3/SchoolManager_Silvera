using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Klass
    {
       
        public int Id { get; set; }
        public string Namn { get; set; }
        public virtual Elev KlassElev { get; set; }
        public int ElevId { get; set; }
    }
}
