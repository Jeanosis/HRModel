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
        public ActionResult Index(string Name, bool Check)
        {
            ViewBag.Candidate = RepositoryService.Repository.GetCandidateByName(Name);
            return Check ? (ActionResult)RedirectToAction("Index", "CandidateEdit", new { candidateId = ViewBag.Candidate.Id }) : View();
        }
    }
}
