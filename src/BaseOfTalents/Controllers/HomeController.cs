using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseOfTalents.DAL;

namespace BaseOfTalents.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Candidate = null;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Name)
        {
            ViewBag.Candidate = RepositoryService.Repository.GetCandidateByName(Name);
            return View();
        }
    }
}
