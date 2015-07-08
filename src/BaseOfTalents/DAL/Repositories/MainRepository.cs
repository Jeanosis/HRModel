using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseOfTalents.Models;

namespace BaseOfTalents.DAL.Repositories
{
    public class MainRepository : IMainRepository
    {
        public MainRepository()
        {
            Candidate fCandidate = new Candidate(), sCandidate = new Candidate(), tCandidate = new Candidate();
            fCandidate.FirstName = "PUPS";
            sCandidate.FirstName = "PEPS";
            tCandidate.FirstName = "Pikachu";

            SaveCandidate(fCandidate);
            SaveCandidate(sCandidate);
            SaveCandidate(tCandidate);
        }

        public void SaveCandidate(Candidate candidate)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(candidate);
                    transaction.Commit();
                }
            }
        }


        public Candidate GetCandidateByName(String name)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var list = session.QueryOver<Candidate>().Where(x => x.FirstName == name).List();
                return list.Count != 0 ? list[0] : null;
            }
        }

        public List<Candidate> GetAllCandidates()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                return session.QueryOver<Candidate>().List() as List<Candidate>;
            }
        }
    }
}