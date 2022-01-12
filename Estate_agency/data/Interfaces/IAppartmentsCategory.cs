using Estate_agency.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.data.Interfaces
{
   public interface IAppartmentsCategory
    {
        IEnumerable<Categorycs> AllCategories { get; }
    }
}
