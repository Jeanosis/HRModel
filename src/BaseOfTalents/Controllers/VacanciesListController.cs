using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseOfTalents.Models;
using BaseOfTalents.DAL;

namespace BaseOfTalents.Controllers
{
    public class VacanciesListController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Search", "VacanciesList");
        }

        [HttpGet]
        public ActionResult Search(VacancySearchArguments args)
        {
            return View(SearchImpl(args));
        }

        private IEnumerable<VacancyListEntry> SearchImpl(VacancySearchArguments args)
        {
            var vacancies = (IEnumerable<Vacancy>)RepositoryService.Repository.GetAllVacancies();
            
            if (args.MinEndDate != null)
            {
                vacancies = vacancies.Where(vacancy => vacancy.EndDate >= args.MinEndDate);
            }

            if (args.MaxEndDate != null)
            {
                vacancies = vacancies.Where(vacancy => vacancy.EndDate <= args.MaxEndDate);
            }

            if (args.MinStartDate != null)
            { 
                vacancies = vacancies.Where(vacancy => vacancy.StartDate >= args.MinStartDate);
            }

            if (args.MaxStartDate != null)
            {
                vacancies = vacancies.Where(vacancy => vacancy.StartDate <= args.MaxStartDate);
            }

            if (args.Name != null)
            {
                vacancies = vacancies.Where(vacancy => vacancy.Name.ToLower().Contains(args.Name.ToLower()));
            }

            return vacancies.ToList().ConvertAll(vacancy => new VacancyListEntry(vacancy));
        }
    }
}
