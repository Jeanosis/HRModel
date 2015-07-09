using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseOfTalents.DAL;
using BaseOfTalents.Models;

namespace BaseOfTalents.Controllers
{
    public class CandidateEditController : Controller
    {
        //
        // GET: /CandidateEdit/

        public ActionResult Index()
        {
            return View("CandidateEdit");
        }

        /*[HttpGet]
        public ActionResult Index(Guid candidateId)
        {
            ViewBag.Candidate = RepositoryService.Repository.GetCandidateById(candidateId);
            return View();
        }*/

        [HttpPost]
        public ActionResult Index(Candidate candidate)
        {
            //RepositoryService.Repository.SaveCandidate(candidate);
            return RedirectToAction("Index", "Home", candidate.Id);//View();
        }
    }
}
