using Estate_agency.data.Interfaces;
using Estate_agency.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.data.Mocks
{
    public class MockAppartments : IAppartaments
    {
        private readonly IAppartmentsCategory _categoryApp = new MockCategory();

        public IEnumerable<Apartments> Apartments
        {
            get
            {
                return new List<Apartments>
                {
                    new Apartments {Address = "Район Центральный", Square = "54.6 м²", Level = 5, img = "/img/1.jpg", Price = 30000, isFavorite = true, CategoryName = _categoryApp.AllCategories.First(), },
                    new Apartments {Address = "Район Центральный", Square = "54.6 м²", Level = 5, img = "/img/2.jpg", Price = 30000, isFavorite = true, CategoryName = _categoryApp.AllCategories.First(), },
                    new Apartments {Address = "Район Центральный", Square = "54.6 м²", Level = 5, img = "/img/3.jpg", Price = 30000, isFavorite = true, CategoryName = _categoryApp.AllCategories.First(), },
                    new Apartments {Address = "Район Центральный", Square = "54.6 м²", Level = 5, img = "/img/4.jpg", Price = 30000, isFavorite = true, CategoryName = _categoryApp.AllCategories.First(), }
                };
            }
        }
        public IEnumerable<Apartments> getFavApartments { get; set; }

        public Apartments getObjectApartment(int carsID)
        {
            throw new NotImplementedException();
        }
    }
}
