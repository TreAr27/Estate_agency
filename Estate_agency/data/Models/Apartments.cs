using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.data.Models
{
    public class Apartments
    {
        public int id { set; get; }
        public string Address { set; get; }
        public string Square { set; get; }
        public int Level { set; get; }
        public string img { set; get; }
        public ulong Price { set; get; }
        public string Furniture { set; get; }
        public string With_children { set; get; }
        public string With_animals { set; get; }
        public bool isFavorite { set; get; }
        public int idCategory { set; get; }
        public virtual Categorycs CategoryName { set; get; }  




    }
}
