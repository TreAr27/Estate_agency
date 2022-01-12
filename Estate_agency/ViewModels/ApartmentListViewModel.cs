using Estate_agency.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.ViewModels
{
    public class ApartmentListViewModel
    {
        public IEnumerable<Apartments> allApartments { get; set; }

        public string appartCategory { get; set; }

    }
}
