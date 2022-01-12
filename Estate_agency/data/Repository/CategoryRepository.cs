using Microsoft.EntityFrameworkCore;
using Estate_agency.data.Interfaces;
using Estate_agency.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.data.Repository
{
    public class CategoryRepository : IAppartmentsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Categorycs> AllCategories => appDBContent.Category;
    }
}
