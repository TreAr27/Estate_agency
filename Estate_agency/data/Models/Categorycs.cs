using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.data.Models
{
    public class Categorycs
    {
        public int id { set; get; }
        public string CategoryName { set; get; }
        public string CategoryDesc { set; get; }
        public List<Apartments> Apartment { set; get; }
    }
}
