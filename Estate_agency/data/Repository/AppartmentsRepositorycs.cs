using Microsoft.EntityFrameworkCore;
using Estate_agency.data.Interfaces;
using Estate_agency.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.data.Repository
{
    public class AppartmentsRepositorycs : IAppartaments
    {
        private readonly AppDBContent appDBContent;

        public AppartmentsRepositorycs(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Apartments> Apartments => appDBContent.Apartments.Include(c => c.CategoryName);

        public IEnumerable<Apartments> getFavApartments => appDBContent.Apartments.Where(p => p.isFavorite).Include(c => c.CategoryName);

        public Apartments getObjectApartment(int ApartmentID) => appDBContent.Apartments.FirstOrDefault(p => p.id == ApartmentID);


    }
}
