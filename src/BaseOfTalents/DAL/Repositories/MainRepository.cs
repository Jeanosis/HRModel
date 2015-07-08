using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseOfTalents.Models;

namespace BaseOfTalents.DAL.Repositories
{
    public class MainRepository
    {
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


        public Candidate GetCandidateById(Guid id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var list = session.QueryOver<Candidate>().Where(x => x.Id == id).List();
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