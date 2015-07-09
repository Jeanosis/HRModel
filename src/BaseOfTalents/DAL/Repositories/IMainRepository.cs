using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseOfTalents.Models;

namespace BaseOfTalents.DAL.Repositories
{
    public interface IMainRepository
    {
        void SaveCandidate(Candidate candidate);
        Candidate GetCandidateById(Guid id);
        Candidate GetCandidateByName(String name);
        List<Candidate> GetAllCandidates();
    }
}
