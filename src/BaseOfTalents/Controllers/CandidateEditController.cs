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

        [HttpGet]
        public ActionResult Index(Guid candidateId)//Guid candidateId)
        {
            return View("CandidateEdit", RepositoryService.Repository.GetCandidateById(candidateId));
        }

        [HttpPost]
        public ActionResult Index(Candidate candidate, Guid Id)
        {
            System.Diagnostics.Debug.WriteLine("RedactId: {0}", candidate.Id);
            System.Diagnostics.Debug.WriteLine("Id: {0}", Id);
            RepositoryService.Repository.SaveCandidate(candidate);
            System.Diagnostics.Debug.WriteLine("RedactId: {0}", candidate.Id);
            return RedirectToAction("Index", "Home");//, candidate.Id);//View();
        }
    }
}
