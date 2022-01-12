using Estate_agency.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.data.Interfaces
{
    public interface IAppartaments
    {
        IEnumerable<Apartments> Apartments { get; }
        IEnumerable<Apartments> getFavApartments { get; }
        Apartments getObjectApartment(int ApartmentID);
    }
}
