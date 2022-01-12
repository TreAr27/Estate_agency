using Microsoft.AspNetCore.Mvc;
using Estate_agency.data.Interfaces;
using Estate_agency.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estate_agency.Controllers
{
    public class ApartmentsController : Controller
    {
        private readonly IAppartaments _allAppartaments;
        private readonly IAppartmentsCategory _allCategeries;

            public ApartmentsController(IAppartaments iAppartaments, IAppartmentsCategory iAppartCat)
        { _allAppartaments = iAppartaments;
          _allCategeries = iAppartCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с апартаментами";
            ApartmentListViewModel obj = new ApartmentListViewModel();
            obj.allApartments = _allAppartaments.Apartments;
            obj.appartCategory = "Аппартаменты";

            return View(obj);
        }

    }
}
