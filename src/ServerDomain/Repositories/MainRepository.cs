using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;

namespace ServerDomain.Repositories
{
    internal class MainRepository : IMainRepository
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


        public Candidate GetCandidateByName(string name)
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
