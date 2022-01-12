using Estate_agency.data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.data
{
    public class DBobjects
    {
        public static void Initial(AppDBContent content)
        {
           

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Apartments.Any())
            {
                content.Apartments.AddRange(new Apartments { Address = "Район Центральный", Square = "54.6 м²", Level = 5, img = "/img/1.jpg", Price = 30000, isFavorite = true, CategoryName = Categories["Однокомнатная"], },
                    new Apartments { Address = "Район Центральный", Square = "55.6 м²", Level = 5, img = "/img/2.jpg", Price = 30000, isFavorite = true, CategoryName = Categories["Студия"], },
                    new Apartments { Address = "Район Центральный", Square = "56.2 м²", Level = 5, img = "/img/3.jpg", Price = 30000, isFavorite = true, CategoryName = Categories["Студия"], },
                    new Apartments { Address = "Район Центральный", Square = "53.3 м²", Level = 5, img = "/img/4.jpg", Price = 30000, isFavorite = true, CategoryName = Categories["Студия"], });
            }

            content.SaveChanges();

        }
        private static Dictionary<string, Categorycs> category;
        public static Dictionary<string, Categorycs> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Categorycs[] {
                    new Categorycs {CategoryName = "Студия", CategoryDesc = "Студия" },
                    new Categorycs {CategoryName = "Однокомнатная", CategoryDesc = "1 комната" }
                    };

                    category = new Dictionary<string, Categorycs>();
                    foreach (Categorycs elem in list)
                        category.Add(elem.CategoryName, elem);

                }
                return category;
            }

        }
    }
}
