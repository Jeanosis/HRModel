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
            var vacancies = RepositoryService.Repository.GetAllVacancies();

            if (args.MaxEndDate != null)
            {
                
            }

            if (args.MinStartDate != null)
            {
            
            }


            return new EmptyResult();
        }
    }
}
