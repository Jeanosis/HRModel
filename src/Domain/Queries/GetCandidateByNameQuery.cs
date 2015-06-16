using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Queries
{
    [Serializable]
    public class GetCandidateByNameQuery : IQuery
    {
        public string Name { get; set; }

        public Guid ClientId { get; set; }

        public GetCandidateByNameQuery(string name)
        {
            Name = name;
        }

        public object Process(IQueryHandler handler)
        {
            return handler.Process(this);
        }
    }
}
