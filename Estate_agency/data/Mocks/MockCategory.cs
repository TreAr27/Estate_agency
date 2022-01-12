using Estate_agency.data.Interfaces;
using Estate_agency.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.data.Mocks
{
    public class MockCategory : IAppartmentsCategory
    {
        public IEnumerable<Categorycs> AllCategories
        {
            get {
                return new List<Categorycs>
                {
                    new Categorycs {CategoryName = "Студия", CategoryDesc = "Студия" },
                    new Categorycs {CategoryName = "Однокомнатная", CategoryDesc = "1 комната" }
                };
            }
        }
    }
}
