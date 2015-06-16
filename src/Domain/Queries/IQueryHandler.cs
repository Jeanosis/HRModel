using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Queries
{
    public interface IQueryHandler
    {
        object Process(IQuery query);
        Candidate Process(GetCandidateByNameQuery query);
    }
}
